using System;
using System.Collections.Generic;
using System.Text;

namespace NoteView
{
  internal struct Field
  {
    public readonly string type;
    public readonly string name;
    public readonly bool required;
    public string refTable;
    public string refField;
    public readonly bool autoIncrement;

    public Field(
      string type, string name, bool required, bool autoIncrement
    )
    {
      this.type = type;
      this.name = name;
      this.required = required;
      this.refTable = null;
      this.refField = null;
      this.autoIncrement = autoIncrement;
    }

    override public string ToString()
    {
      return $"(name={name}, type={type}, required={required}, autoincr={autoIncrement}, refTable={refTable ?? "<none>"}, refField={refField ?? "<none>"})";
    }
  }

  internal static class IgnoreCaseExtension
  {
    public static bool EqualsIgnoreCase(this string lhs, string rhs)
    {
      return lhs.ToUpper() == rhs.ToUpper();
    }
  }

  internal struct Table
  {
    public readonly string name;
    public readonly List<Field> fields;
    private string primary;

    public Table(string name)
    {
      this.name = name;
      this.fields = new List<Field>();
      this.primary = null;
    }

    public int Seek(string field)
    {
      for (int i = 0; i < fields.Count; ++i)
      {
        if (fields[i].name.EqualsIgnoreCase(field)) return i;
      }
      return -1;
    }

    public int Seek(string field, string type, bool required, bool autoIncr)
    {
      int found = Seek(field);
      if (found == -1) return -1;

      Field theField = fields[found];
      if (theField.type.EqualsIgnoreCase(type) && theField.required == required && theField.autoIncrement == autoIncr)
      {
        return found;
      }
      return -1;
    }

    public string Primary
    {
      get { return primary; }
      set
      {
        int i = Seek(value);
        if (i == -1)
        {
          throw new ValidationException("Invalid field");
        }
        primary = value;
      }
    }

    override public string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append($"Table {name}\n");
      sb.Append($"  primary={primary}\n");
      foreach (Field field in fields)
      {
        sb.Append($"  {field}\n");
      }
      return sb.ToString();
    }
  }

  internal enum TokenKind
  {
    Create,
    Table,
    If,
    Not,
    Exists,
    Primary,
    Foreign,
    Key,
    Null,
    AutoIncrement,
    References,

    LeftParen,
    RightParen,
    Comma,
    Semicolon,
    EOF,

    Id,
    Int
  }

  internal struct Token
  {
    public readonly TokenKind kind;
    public readonly string lexeme;

    public Token(TokenKind kind, string lexeme)
    {
      this.kind = kind;
      this.lexeme = lexeme;
    }
  }

  internal class TableParser
  {
    private string sql;
    private int length;
    // Lexer data
    private int lexStart = 0;
    private int lexCurrent = 0;

    private void Error(string msg)
    {
      throw new ValidationException(msg);
    }

    // Scanning

    private bool AtEnd
    {
      get { return lexCurrent >= length; }
    }

    private char CurrentChar
    {
      get
      {
        return AtEnd ? '\0' : sql[lexCurrent];
      }
    }

    private void NextChar()
    {
      if (!AtEnd) ++lexCurrent;
    }

    private bool CheckChar(char ch)
    {
      return ch == CurrentChar;
    }
    private bool MatchChar(char ch)
    {
      if (CheckChar(ch))
      {
        NextChar();
        return true;
      }
      return false;
    }
    private char PeekChar(int lookahead = 1)
    {
      int target = lexCurrent + lookahead;
      if (target >= length)
      {
        return '\0';
      }
      return sql[target];
    }

    private void SkipIgnoredChars()
    {
      while (!AtEnd)
      {
        char ch = CurrentChar;
        switch (ch)
        {
          case '-':
            if (PeekChar() == '-')
            {
              // Skip over "--"
              NextChar(); NextChar();
              while (!AtEnd && CurrentChar != '\n')
              {
                NextChar();
              }
            }
            break;
          case ' ':
          case '\n':
          case '\t':
          case '\r':
            NextChar();
            break;
          default: return;
        }
      }
    }

    private TokenKind GetIdType(string s)
    {
      switch (s.ToUpper())
      {
        case "CREATE": return TokenKind.Create;
        case "TABLE": return TokenKind.Table;
        case "IF": return TokenKind.If;
        case "NOT": return TokenKind.Not;
        case "EXISTS": return TokenKind.Exists;
        case "PRIMARY": return TokenKind.Primary;
        case "FOREIGN": return TokenKind.Foreign;
        case "KEY": return TokenKind.Key;
        case "NULL": return TokenKind.Null;
        case "AUTO_INCREMENT": return TokenKind.AutoIncrement;
        case "REFERENCES": return TokenKind.References;
        default: return TokenKind.Id;
      }
    }

    private Token MakeToken(TokenKind kind)
    {
      return new Token(kind, sql.Substring(lexStart, lexCurrent - lexStart));
    }

    private Token IdentifierToken
    {
      get
      {
        char ch = CurrentChar;
        while (char.IsLetterOrDigit(ch) || ch == '_')
        {
          NextChar();
          ch = CurrentChar;
        }
        string lexeme = sql.Substring(lexStart, lexCurrent - lexStart);
        return new Token(GetIdType(lexeme), lexeme);
      }
    }

    private Token IntToken
    {
      get
      {
        char ch = CurrentChar;
        while (char.IsDigit(ch))
        {
          NextChar();
          ch = CurrentChar;
        }
        return MakeToken(TokenKind.Int);
      }
    }

    private Token NextToken
    {
      get
      {
        SkipIgnoredChars();
        lexStart = lexCurrent;

        if (AtEnd) return MakeToken(TokenKind.EOF);

        char ch = CurrentChar;
        NextChar();

        switch (ch)
        {
          case '(': return MakeToken(TokenKind.LeftParen);
          case ')': return MakeToken(TokenKind.RightParen);
          case ',': return MakeToken(TokenKind.Comma);
          case ';': return MakeToken(TokenKind.Semicolon);
          default:
            if (char.IsDigit(ch)) return IntToken;
            else if (char.IsLetter(ch) || ch == '_') return IdentifierToken;
            else Error("Invalid character");
            break;
        }

        throw new InvalidProgramException();
      }
    }

    // Parsing

    private Token prevToken;
    private Token thisToken;
    private Token nextToken;

    private void AdvanceToken()
    {
      prevToken = thisToken;
      thisToken = nextToken;
      nextToken = NextToken;
    }

    private bool CheckToken(TokenKind kind)
    {
      return thisToken.kind == kind;
    }

    private bool MatchToken(TokenKind kind)
    {
      if (CheckToken(kind))
      {
        AdvanceToken();
        return true;
      }
      return false;
    }

    private Token ExpectToken(TokenKind kind, string msg = "Expected token")
    {
      if (!CheckToken(kind)) Error($"Near '{thisToken.lexeme}': {msg}");
      AdvanceToken();
      return prevToken;
    }

    private Table ParseTable()
    {
      // SQLTable => "CREATE" "TABLE" ("IF" "NOT" "EXISTS")? ID ...
      ExpectToken(TokenKind.Create);
      ExpectToken(TokenKind.Table);
      if (MatchToken(TokenKind.If))
      {
        ExpectToken(TokenKind.Not);
        ExpectToken(TokenKind.Exists);
      }

      Token name = ExpectToken(TokenKind.Id);
      Table table = new Table(name.lexeme);

      ExpectToken(TokenKind.LeftParen);
      do
      {
        if (CheckToken(TokenKind.Id))
        {
          table.fields.Add(ParseField(table));
        }
        else if (MatchToken(TokenKind.Primary))
        {
          ExpectToken(TokenKind.Key);
          if (table.Primary != null) Error("Duplicate primary key");
          ExpectToken(TokenKind.LeftParen);
          string fieldName = ExpectToken(TokenKind.Id).lexeme;
          if (table.Seek(fieldName) == -1) throw new InvalidProgramException("Invalid field");
          table.Primary = fieldName;
          ExpectToken(TokenKind.RightParen, "Unmatched parenthesis");
        }
        else if (MatchToken(TokenKind.Foreign))
        {
          ExpectToken(TokenKind.Key);
          ExpectToken(TokenKind.LeftParen);
          Token field = ExpectToken(TokenKind.Id);
          ExpectToken(TokenKind.RightParen);
          ExpectToken(TokenKind.References);
          Token tableName = ExpectToken(TokenKind.Id);
          ExpectToken(TokenKind.LeftParen);
          Token fieldTable = ExpectToken(TokenKind.Id);
          ExpectToken(TokenKind.RightParen);

          int i = table.Seek(field.lexeme);
          if (i == -1)
          {
            Error("Invalid field");
          }

          Field newField = table.fields[i];
          newField.refTable = tableName.lexeme;
          newField.refField = fieldTable.lexeme;
          table.fields[i] = newField;
        }
      }
      while (MatchToken(TokenKind.Comma));

      ExpectToken(TokenKind.RightParen, "Unmatched parenthesis");
      ExpectToken(TokenKind.Semicolon);

      return table;
    }

    private void ParseType(ref string name)
    {
      Token type = ExpectToken(TokenKind.Id, "Missing type name");
      if (MatchToken(TokenKind.LeftParen))
      {
        do
        {
          AdvanceToken(); // Skip the arguments.
        }
        while (MatchToken(TokenKind.Comma));

        ExpectToken(TokenKind.RightParen, "Unmatched parenthesis");
      }

      name = type.lexeme;
    }

    private Field ParseField(Table table)
    {
      // SQLField => ID SQL_TYPE [ ("NOT" "NULL"), "AUTO_INCREMENT", "PRIMARY_KEY" ]
      Token name = ExpectToken(TokenKind.Id, "Missing field name");
      string type = null;
      ParseType(ref type);
      // Modifiers data
      bool required = false;
      bool autoIncrement = false;
      for (; ; )
      {
        if (MatchToken(TokenKind.Not))
        {
          ExpectToken(TokenKind.Null);
          required = true;
        }
        else if (MatchToken(TokenKind.AutoIncrement))
        {
          autoIncrement = true;
        }
        else if (MatchToken(TokenKind.Primary))
        {
          ExpectToken(TokenKind.Key);
          if (table.Primary != null)
          {
            Error("Duplicate primary key");
          }
          table.Primary = name.lexeme;
        }
        else break;
      }

      return new Field(type, name.lexeme, required, autoIncrement);
    }

    public void Parse(List<Table> res, string sql)
    {
      this.sql = sql;
      this.length = sql.Length;
      lexStart = 0;
      lexCurrent = 0;
      AdvanceToken();
      AdvanceToken();

      while (thisToken.kind != TokenKind.EOF)
      {
        res.Add(ParseTable());
      }
    }

    // Test
    public static void Test(string sql)
    {
      TableParser parser = new TableParser();
      List<Table> tables = new List<Table>();

      parser.Parse(tables, sql);

      foreach (Table table in tables)
      {
        Console.WriteLine(table.ToString());
      }
    }
  }

}
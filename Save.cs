using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace NoteView
{
  [Serializable]
  internal class DBConnectionSave
  {
    public const string SaveName = "dbconn.dat";
    public ConnectionArgs connData;

    public DBConnectionSave()
    {
      connData = new ConnectionArgs();
    }

    public static string GetSavePath()
    {
      return $"./{SaveName}";
    }

    public void Serialize()
    {
      using (Stream stream = File.OpenWrite(GetSavePath()))
      {
        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Serialize(stream, this);
      }
    }

    public static DBConnectionSave Deserialize()
    {
      using (FileStream fs = File.Open(GetSavePath(), FileMode.Open))
      {
        BinaryFormatter formatter = new BinaryFormatter();
        return (DBConnectionSave) formatter.Deserialize(fs);
      }
    }
  }
}

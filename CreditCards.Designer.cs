namespace NoteView
{
    partial class CreditCards
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_number = new System.Windows.Forms.Label();
            this.lbl_expiryDate = new System.Windows.Forms.Label();
            this.lbl_cardHolder = new System.Windows.Forms.Label();
            this.cb_cardType = new System.Windows.Forms.ComboBox();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.tb_cardHolder = new System.Windows.Forms.TextBox();
            this.dtp_expiryDate = new System.Windows.Forms.DateTimePicker();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.type_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiry_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardHolder_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationID_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUsed_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tokenized_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(12, 12);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(66, 33);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(84, 12);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(66, 33);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(156, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(66, 33);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.type_col,
            this.number_col,
            this.expiry_col,
            this.cardHolder_col,
            this.reservationID_col,
            this.lastUsed_col,
            this.tokenized_col});
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 211);
            this.dataGridView1.TabIndex = 3;
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.Location = new System.Drawing.Point(12, 277);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(45, 16);
            this.lbl_type.TabIndex = 4;
            this.lbl_type.Text = "Type:";
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_number.Location = new System.Drawing.Point(12, 306);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(62, 16);
            this.lbl_number.TabIndex = 5;
            this.lbl_number.Text = "Number:";
            // 
            // lbl_expiryDate
            // 
            this.lbl_expiryDate.AutoSize = true;
            this.lbl_expiryDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_expiryDate.Location = new System.Drawing.Point(12, 335);
            this.lbl_expiryDate.Name = "lbl_expiryDate";
            this.lbl_expiryDate.Size = new System.Drawing.Size(88, 16);
            this.lbl_expiryDate.TabIndex = 6;
            this.lbl_expiryDate.Text = "Expiry Date:";
            // 
            // lbl_cardHolder
            // 
            this.lbl_cardHolder.AutoSize = true;
            this.lbl_cardHolder.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cardHolder.Location = new System.Drawing.Point(12, 362);
            this.lbl_cardHolder.Name = "lbl_cardHolder";
            this.lbl_cardHolder.Size = new System.Drawing.Size(105, 16);
            this.lbl_cardHolder.TabIndex = 7;
            this.lbl_cardHolder.Text = "Name on Card:";
            // 
            // cb_cardType
            // 
            this.cb_cardType.FormattingEnabled = true;
            this.cb_cardType.Location = new System.Drawing.Point(118, 277);
            this.cb_cardType.Name = "cb_cardType";
            this.cb_cardType.Size = new System.Drawing.Size(152, 21);
            this.cb_cardType.TabIndex = 8;
            // 
            // tb_number
            // 
            this.tb_number.Location = new System.Drawing.Point(119, 306);
            this.tb_number.Name = "tb_number";
            this.tb_number.Size = new System.Drawing.Size(151, 20);
            this.tb_number.TabIndex = 9;
            // 
            // tb_cardHolder
            // 
            this.tb_cardHolder.Location = new System.Drawing.Point(119, 358);
            this.tb_cardHolder.Name = "tb_cardHolder";
            this.tb_cardHolder.Size = new System.Drawing.Size(151, 20);
            this.tb_cardHolder.TabIndex = 10;
            // 
            // dtp_expiryDate
            // 
            this.dtp_expiryDate.CustomFormat = "";
            this.dtp_expiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_expiryDate.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtp_expiryDate.Location = new System.Drawing.Point(118, 333);
            this.dtp_expiryDate.MinDate = new System.DateTime(2023, 6, 9, 0, 0, 0, 0);
            this.dtp_expiryDate.Name = "dtp_expiryDate";
            this.dtp_expiryDate.Size = new System.Drawing.Size(91, 20);
            this.dtp_expiryDate.TabIndex = 33;
            this.dtp_expiryDate.Value = new System.DateTime(2023, 6, 15, 0, 0, 0, 0);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(340, 342);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(66, 33);
            this.btn_save.TabIndex = 34;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(412, 342);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(66, 33);
            this.btn_cancel.TabIndex = 35;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // type_col
            // 
            this.type_col.HeaderText = "Type";
            this.type_col.Name = "type_col";
            this.type_col.ReadOnly = true;
            // 
            // number_col
            // 
            this.number_col.HeaderText = "Number";
            this.number_col.Name = "number_col";
            this.number_col.ReadOnly = true;
            // 
            // expiry_col
            // 
            this.expiry_col.HeaderText = "Exp.";
            this.expiry_col.Name = "expiry_col";
            this.expiry_col.ReadOnly = true;
            // 
            // cardHolder_col
            // 
            this.cardHolder_col.HeaderText = "Name on Card";
            this.cardHolder_col.Name = "cardHolder_col";
            this.cardHolder_col.ReadOnly = true;
            // 
            // reservationID_col
            // 
            this.reservationID_col.HeaderText = "Reservation";
            this.reservationID_col.Name = "reservationID_col";
            this.reservationID_col.ReadOnly = true;
            // 
            // lastUsed_col
            // 
            this.lastUsed_col.HeaderText = "Last Used";
            this.lastUsed_col.Name = "lastUsed_col";
            this.lastUsed_col.ReadOnly = true;
            // 
            // tokenized_col
            // 
            this.tokenized_col.HeaderText = "Tokenized";
            this.tokenized_col.Name = "tokenized_col";
            this.tokenized_col.ReadOnly = true;
            // 
            // CreditCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 391);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dtp_expiryDate);
            this.Controls.Add(this.tb_cardHolder);
            this.Controls.Add(this.tb_number);
            this.Controls.Add(this.cb_cardType);
            this.Controls.Add(this.lbl_cardHolder);
            this.Controls.Add(this.lbl_expiryDate);
            this.Controls.Add(this.lbl_number);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_new);
            this.Name = "CreditCards";
            this.Text = "Credit Cards";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.Label lbl_expiryDate;
        private System.Windows.Forms.Label lbl_cardHolder;
        private System.Windows.Forms.ComboBox cb_cardType;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.TextBox tb_cardHolder;
        private System.Windows.Forms.DateTimePicker dtp_expiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiry_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardHolder_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationID_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUsed_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn tokenized_col;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}
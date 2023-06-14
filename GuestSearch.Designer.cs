namespace NoteView
{
    partial class GuestSearch
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fullName_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loyaltyNumber_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.lbl_loyaltyNum = new System.Windows.Forms.Label();
            this.tb_firstName = new System.Windows.Forms.TextBox();
            this.tb_loyaltyNum = new System.Windows.Forms.TextBox();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullName_col,
            this.phone_col,
            this.address_col,
            this.city_col,
            this.loyaltyNumber_col,
            this.email_col});
            this.dataGridView1.Location = new System.Drawing.Point(7, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(768, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // fullName_col
            // 
            this.fullName_col.HeaderText = "Full Name";
            this.fullName_col.Name = "fullName_col";
            this.fullName_col.ReadOnly = true;
            this.fullName_col.Width = 150;
            // 
            // phone_col
            // 
            this.phone_col.HeaderText = "Phone";
            this.phone_col.Name = "phone_col";
            this.phone_col.ReadOnly = true;
            this.phone_col.Width = 125;
            // 
            // address_col
            // 
            this.address_col.HeaderText = "Address";
            this.address_col.Name = "address_col";
            this.address_col.ReadOnly = true;
            this.address_col.Width = 125;
            // 
            // city_col
            // 
            this.city_col.HeaderText = "City";
            this.city_col.Name = "city_col";
            this.city_col.ReadOnly = true;
            // 
            // loyaltyNumber_col
            // 
            this.loyaltyNumber_col.HeaderText = "Loyalty Number";
            this.loyaltyNumber_col.Name = "loyaltyNumber_col";
            this.loyaltyNumber_col.ReadOnly = true;
            // 
            // email_col
            // 
            this.email_col.HeaderText = "Email";
            this.email_col.Name = "email_col";
            this.email_col.ReadOnly = true;
            this.email_col.Width = 125;
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstName.Location = new System.Drawing.Point(31, 336);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(83, 16);
            this.lbl_firstName.TabIndex = 1;
            this.lbl_firstName.Text = "First Name:";
            // 
            // lbl_loyaltyNum
            // 
            this.lbl_loyaltyNum.AutoSize = true;
            this.lbl_loyaltyNum.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loyaltyNum.Location = new System.Drawing.Point(31, 365);
            this.lbl_loyaltyNum.Name = "lbl_loyaltyNum";
            this.lbl_loyaltyNum.Size = new System.Drawing.Size(115, 16);
            this.lbl_loyaltyNum.TabIndex = 2;
            this.lbl_loyaltyNum.Text = "Loyalty Number:";
            // 
            // tb_firstName
            // 
            this.tb_firstName.Location = new System.Drawing.Point(145, 335);
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.Size = new System.Drawing.Size(209, 20);
            this.tb_firstName.TabIndex = 3;
            // 
            // tb_loyaltyNum
            // 
            this.tb_loyaltyNum.Location = new System.Drawing.Point(145, 364);
            this.tb_loyaltyNum.Name = "tb_loyaltyNum";
            this.tb_loyaltyNum.Size = new System.Drawing.Size(209, 20);
            this.tb_loyaltyNum.TabIndex = 4;
            // 
            // tb_lastName
            // 
            this.tb_lastName.Location = new System.Drawing.Point(469, 336);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(209, 20);
            this.tb_lastName.TabIndex = 6;
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastName.Location = new System.Drawing.Point(385, 337);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(82, 16);
            this.lbl_lastName.TabIndex = 5;
            this.lbl_lastName.Text = "Last Name:";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(469, 365);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(209, 20);
            this.tb_email.TabIndex = 8;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(422, 366);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(46, 16);
            this.lbl_email.TabIndex = 7;
            this.lbl_email.Text = "Email:";
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(597, 406);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(91, 32);
            this.btn_ok.TabIndex = 9;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(697, 406);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(91, 32);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(685, 303);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(91, 32);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // GuestSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.tb_lastName);
            this.Controls.Add(this.lbl_lastName);
            this.Controls.Add(this.tb_loyaltyNum);
            this.Controls.Add(this.tb_firstName);
            this.Controls.Add(this.lbl_loyaltyNum);
            this.Controls.Add(this.lbl_firstName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GuestSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guest Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn address_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn city_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn loyaltyNumber_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_col;
        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.Label lbl_loyaltyNum;
        private System.Windows.Forms.TextBox tb_firstName;
        private System.Windows.Forms.TextBox tb_loyaltyNum;
        private System.Windows.Forms.TextBox tb_lastName;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_search;
    }
}
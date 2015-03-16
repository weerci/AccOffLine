namespace AcOffLine
{
    partial class FormPrintAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrintAccount));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbBasic = new System.Windows.Forms.TextBox();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.tbParent = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbAccountDate = new System.Windows.Forms.TextBox();
            this.tbNumberAccount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBank = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 57);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(389, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Печать счета";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(477, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbBasic
            // 
            this.tbBasic.Location = new System.Drawing.Point(166, 246);
            this.tbBasic.Multiline = true;
            this.tbBasic.Name = "tbBasic";
            this.tbBasic.Size = new System.Drawing.Size(381, 58);
            this.tbBasic.TabIndex = 35;
            // 
            // tbSum
            // 
            this.tbSum.Location = new System.Drawing.Point(166, 217);
            this.tbSum.Name = "tbSum";
            this.tbSum.Size = new System.Drawing.Size(381, 20);
            this.tbSum.TabIndex = 34;
            // 
            // tbParent
            // 
            this.tbParent.Location = new System.Drawing.Point(166, 189);
            this.tbParent.Name = "tbParent";
            this.tbParent.Size = new System.Drawing.Size(381, 20);
            this.tbParent.TabIndex = 33;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(166, 161);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(381, 20);
            this.tbName.TabIndex = 32;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(166, 133);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(381, 20);
            this.tbSurname.TabIndex = 31;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(166, 68);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(381, 20);
            this.tbLogin.TabIndex = 30;
            // 
            // tbAccountDate
            // 
            this.tbAccountDate.Location = new System.Drawing.Point(166, 40);
            this.tbAccountDate.Name = "tbAccountDate";
            this.tbAccountDate.Size = new System.Drawing.Size(381, 20);
            this.tbAccountDate.TabIndex = 29;
            // 
            // tbNumberAccount
            // 
            this.tbNumberAccount.Location = new System.Drawing.Point(166, 12);
            this.tbNumberAccount.Name = "tbNumberAccount";
            this.tbNumberAccount.Size = new System.Drawing.Size(381, 20);
            this.tbNumberAccount.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Основание платежа:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Сумма счета:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Отчество:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Имя:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Фамилия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Логин клиента:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Дата счета:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Выставлен счет №:";
            // 
            // tbBank
            // 
            this.tbBank.Location = new System.Drawing.Point(166, 99);
            this.tbBank.Name = "tbBank";
            this.tbBank.Size = new System.Drawing.Size(381, 20);
            this.tbBank.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(111, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Банк:";
            // 
            // FormPrintAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 377);
            this.Controls.Add(this.tbBank);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbBasic);
            this.Controls.Add(this.tbSum);
            this.Controls.Add(this.tbParent);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbAccountDate);
            this.Controls.Add(this.tbNumberAccount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrintAccount";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр и печать счета";
            this.Load += new System.EventHandler(this.FormPrintAccount_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbBasic;
        private System.Windows.Forms.TextBox tbSum;
        private System.Windows.Forms.TextBox tbParent;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbAccountDate;
        private System.Windows.Forms.TextBox tbNumberAccount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBank;
        private System.Windows.Forms.Label label9;
    }
}
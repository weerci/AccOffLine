namespace AcOffLine
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnFindAccount = new System.Windows.Forms.Button();
            this.btnBillAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFindAccount
            // 
            this.btnFindAccount.Location = new System.Drawing.Point(67, 12);
            this.btnFindAccount.Name = "btnFindAccount";
            this.btnFindAccount.Size = new System.Drawing.Size(173, 50);
            this.btnFindAccount.TabIndex = 0;
            this.btnFindAccount.Text = "Найти счет";
            this.btnFindAccount.UseVisualStyleBackColor = true;
            this.btnFindAccount.Click += new System.EventHandler(this.btnFindAccount_Click);
            // 
            // btnBillAccount
            // 
            this.btnBillAccount.Location = new System.Drawing.Point(67, 81);
            this.btnBillAccount.Name = "btnBillAccount";
            this.btnBillAccount.Size = new System.Drawing.Size(173, 50);
            this.btnBillAccount.TabIndex = 1;
            this.btnBillAccount.Text = "Выставить счет";
            this.btnBillAccount.UseVisualStyleBackColor = true;
            this.btnBillAccount.Click += new System.EventHandler(this.btnBillAccount_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 159);
            this.Controls.Add(this.btnBillAccount);
            this.Controls.Add(this.btnFindAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Счета off-line";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFindAccount;
        private System.Windows.Forms.Button btnBillAccount;
    }
}


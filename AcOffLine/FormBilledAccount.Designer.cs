namespace AcOffLine
{
    partial class FormBilledAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBilledAccount));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFindAccount = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnNumberAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSummAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatusAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBasisPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 130);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.btnFindAccount);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(157, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(468, 130);
            this.panel3.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(127, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(127, 72);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(224, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(127, 50);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(224, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Статус счета:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Сумма счета:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Фамилия клиента:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата счета:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "№ Счета:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 299);
            this.panel2.TabIndex = 1;
            // 
            // btnFindAccount
            // 
            this.btnFindAccount.Location = new System.Drawing.Point(374, 54);
            this.btnFindAccount.Name = "btnFindAccount";
            this.btnFindAccount.Size = new System.Drawing.Size(75, 23);
            this.btnFindAccount.TabIndex = 10;
            this.btnFindAccount.Text = "Найти счет";
            this.btnFindAccount.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnChoose);
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 242);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(703, 57);
            this.panel4.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumberAccount,
            this.ColumnDateAccount,
            this.ColumnFIO,
            this.ColumnSummAccount,
            this.ColumnStatusAccount,
            this.ColumnBasisPayment});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(703, 242);
            this.dataGridView1.TabIndex = 1;
            // 
            // ColumnNumberAccount
            // 
            this.ColumnNumberAccount.HeaderText = "Номер счета";
            this.ColumnNumberAccount.Name = "ColumnNumberAccount";
            this.ColumnNumberAccount.ReadOnly = true;
            // 
            // ColumnDateAccount
            // 
            this.ColumnDateAccount.HeaderText = "Дата счета";
            this.ColumnDateAccount.Name = "ColumnDateAccount";
            this.ColumnDateAccount.ReadOnly = true;
            // 
            // ColumnFIO
            // 
            this.ColumnFIO.HeaderText = "Фамилия клиента";
            this.ColumnFIO.Name = "ColumnFIO";
            this.ColumnFIO.ReadOnly = true;
            // 
            // ColumnSummAccount
            // 
            this.ColumnSummAccount.HeaderText = "Сумма счета";
            this.ColumnSummAccount.Name = "ColumnSummAccount";
            this.ColumnSummAccount.ReadOnly = true;
            // 
            // ColumnStatusAccount
            // 
            this.ColumnStatusAccount.HeaderText = "Статус счета";
            this.ColumnStatusAccount.Name = "ColumnStatusAccount";
            this.ColumnStatusAccount.ReadOnly = true;
            // 
            // ColumnBasisPayment
            // 
            this.ColumnBasisPayment.HeaderText = "Основание платежа";
            this.ColumnBasisPayment.Name = "ColumnBasisPayment";
            this.ColumnBasisPayment.ReadOnly = true;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(605, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Выход";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(524, 17);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 23);
            this.btnChoose.TabIndex = 1;
            this.btnChoose.Text = "Выбрать";
            this.btnChoose.UseVisualStyleBackColor = true;
            // 
            // FormBilledAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 429);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBilledAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выставленные счета";
            this.Resize += new System.EventHandler(this.FormBilledAccount_Resize);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFindAccount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumberAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSummAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatusAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBasisPayment;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnClose;
    }
}
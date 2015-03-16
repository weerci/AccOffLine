using AcOffLine.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcOffLine
{
    public partial class FormBilledAccount : Form
    {
        public FormBilledAccount()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormBilledAccount_Resize(object sender, EventArgs e)
        {

        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            FormStateAccount formStateAccount = new FormStateAccount(dgvBilledAccount.SelectedRows);
            formStateAccount.ShowDialog();
        }

        private void FormBilledAccount_Load(object sender, EventArgs e)
        {
            cbStatusAccount.Items.AddRange(CsvPrototype.Item.Status.Select().Select(n=>n["name"]).ToArray());
        }

        private void btnFindAccount_Click(object sender, EventArgs e)
        {
            dgvBilledAccount.Columns.Clear();
            DataTable dt = CsvPrototype.Item.Test;

            dgvBilledAccount.DataSource = dt;
            foreach (DataColumn dc in dt.Columns)
                dgvBilledAccount.Columns[dc.ColumnName].HeaderText = dc.Caption;
            dgvBilledAccount.Columns["bank"].Visible = false;
            dgvBilledAccount.Columns["name"].Visible = false;
            dgvBilledAccount.Columns["patronymic"].Visible = false;
            dgvBilledAccount.Columns["phone"].Visible = false;
            dgvBilledAccount.Columns["login"].Visible = false;

        }
    }
}

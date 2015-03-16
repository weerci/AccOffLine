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
    public partial class FormFindClient : Form
    {
        public FormFindClient()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormInvoiceAccount formInvoiceAccount = new FormInvoiceAccount(null);
            formInvoiceAccount.ShowDialog();
        }
        private void btnChoose_Click(object sender, EventArgs e)
        {
            FormInvoiceAccount formInvoiceAccount = new FormInvoiceAccount(dgvFindClient.SelectedRows);
            formInvoiceAccount.ShowDialog();
        }

        private void FormFindClient_Load(object sender, EventArgs e)
        {

        }


        private void btnFindClient_Click(object sender, EventArgs e)
        {
            dgvFindClient.Columns.Clear();
            DataTable dt = CsvPrototype.Item.Test;

            dgvFindClient.DataSource = dt;
            
            foreach (DataColumn dc in dt.Columns)
                dgvFindClient.Columns[dc.ColumnName].HeaderText = dc.Caption;

            dgvFindClient.Columns["number"].Visible = false;
            dgvFindClient.Columns["dt"].Visible = false;
            dgvFindClient.Columns["bank"].Visible = false;
            dgvFindClient.Columns["sum"].Visible = false;
            dgvFindClient.Columns["status"].Visible = false;
            dgvFindClient.Columns["basis"].Visible = false;
            dgvFindClient.Columns["login"].Visible = false;

        }
    }
}

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
    public partial class FormInvoiceAccount : Form
    {
        private DataGridViewSelectedRowCollection _dataRow; 
        public FormInvoiceAccount(DataGridViewSelectedRowCollection dataRow)
        {
            _dataRow = dataRow;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPrintAccount formPrintAccount = new FormPrintAccount(_dataRow);
            formPrintAccount.ShowDialog();
        }

        private void FormInvoiceAccount_Load(object sender, EventArgs e)
        {
            if (_dataRow != null)
            {
                cbBank.Text = _dataRow[0].Cells["bank"].Value.ToString();
                tbLogin.Text = _dataRow[0].Cells["login"].Value.ToString();        
            }

            cbBank.Items.AddRange(CsvPrototype.Item.Banks.Select().Select(n=>n["name"]).Distinct().ToArray());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_dataRow != null)
            {
                showCurrentAccountProperties();
            }
            else
            {
                IsClient();
            }
        }

        private void IsClient  ()
        {

            tbSum.Enabled = true;
            tbSum.ReadOnly = false;

            tbBasic.Enabled = true;
            tbBasic.ReadOnly = false;
        }

        private void showCurrentAccountProperties()
        {
            tbSurname.Enabled = true;
            tbSurname.ReadOnly = false;
            tbSurname.Text = _dataRow[0].Cells["surname"].Value.ToString();

            tbName.Enabled = true;
            tbName.ReadOnly = false;
            tbName.Text = _dataRow[0].Cells["name"].Value.ToString();

            tbPatronic.Enabled = true;
            tbPatronic.ReadOnly = false;
            tbPatronic.Text = _dataRow[0].Cells["patronymic"].Value.ToString();

            tbPhone.Enabled = true;
            tbPhone.ReadOnly = false;
            tbPhone.Text = _dataRow[0].Cells["phone"].Value.ToString();

            tbSum.Enabled = true;
            tbSum.ReadOnly = false;
            tbSum.Text = _dataRow[0].Cells["sum"].Value.ToString();

            tbBasic.Enabled = true;
            tbBasic.ReadOnly = false;
            tbBasic.Text = _dataRow[0].Cells["basis"].Value.ToString();
        }
    }
}

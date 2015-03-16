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
    public partial class FormPrintAccount : Form
    {
        DataGridViewSelectedRowCollection _dataRow;
        public FormPrintAccount(DataGridViewSelectedRowCollection dataRow)
        {
            _dataRow = dataRow;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormPrintAccount_Load(object sender, EventArgs e)
        {
            if (_dataRow != null)
            {
                tbNumberAccount.Text = _dataRow[0].Cells["number"].Value.ToString();
                tbAccountDate.Text = _dataRow[0].Cells["dt"].Value.ToString();
                tbLogin.Text = _dataRow[0].Cells["login"].Value.ToString();
                tbBank.Text = _dataRow[0].Cells["bank"].Value.ToString();
                tbSurname.Text = _dataRow[0].Cells["surname"].Value.ToString();
                tbName.Text = _dataRow[0].Cells["name"].Value.ToString();
                tbParent.Text = _dataRow[0].Cells["patronymic"].Value.ToString();
                tbSum.Text = _dataRow[0].Cells["sum"].Value.ToString();
                tbBasic.Text = _dataRow[0].Cells["basis"].Value.ToString();
            }
        }
    }
}

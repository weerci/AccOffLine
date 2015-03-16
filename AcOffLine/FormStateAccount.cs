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
    public partial class FormStateAccount : Form
    {
        private DataGridViewSelectedRowCollection _dataRow;
        public FormStateAccount(DataGridViewSelectedRowCollection dt)
        {
            _dataRow = dt;
            InitializeComponent();
        }

        private void FormStateAccount_Load(object sender, EventArgs e)
        {
            if (_dataRow != null)
            {
                tbNumberAccount.Text = _dataRow[0].Cells["number"].Value.ToString();
                tbDateAccount.Text = _dataRow[0].Cells["dt"].Value.ToString();
                tbBank.Text = _dataRow[0].Cells["bank"].Value.ToString();
                tbSurname.Text = _dataRow[0].Cells["surname"].Value.ToString();
                tbName.Text = _dataRow[0].Cells["name"].Value.ToString();
                tbPatronic.Text = _dataRow[0].Cells["patronymic"].Value.ToString();
                tbSum.Text = _dataRow[0].Cells["sum"].Value.ToString();
                tbStatus.Text = _dataRow[0].Cells["status"].Value.ToString();
                tbBasic.Text = _dataRow[0].Cells["basis"].Value.ToString();
            }
        }
    }
}

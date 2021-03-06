﻿using AcOffLine.Db;
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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnFindAccount_Click(object sender, EventArgs e)
        {
            new FormBilledAccount().ShowDialog();
        }

        private void btnBillAccount_Click(object sender, EventArgs e)
        {
            new FormFindClient().ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CsvPrototype.Item.LoadFile();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcOffLine.Db
{
    /// <summary>
    /// Считывает данные из файлов csv (расположены в каталоге программы)
    /// Предоставляет доступ к данным через 3 таблицы (bank, Status, Test)
    /// </summary>
    public class CsvPrototype
    {
        public static CsvPrototype Item
        {
            get
            {
                if (item == null)
                {
                    item = new CsvPrototype();
                }
                return item;
            }
        }

        /// <summary>
        /// Возвращается таблица банков
        /// </summary>
        public DataTable Banks
        {
            get
            {
                DataTable dt = new DataTable("banks");
                DataColumn colName;
                colName = new DataColumn("name", typeof(String));
                dt.Columns.AddRange(new DataColumn[] { colName });

                try
                {
                    DataRow dr = null;
                    string[] bankValues = null;

                    for (int i = 0; i < mBanks.Length; i++)
                    {
                        if (!String.IsNullOrEmpty(mBanks[i]))
                        {
                            bankValues = mBanks[i].Split(',');
                            dr = dt.NewRow();
                            dr["name"] = bankValues[0];
                            dt.Rows.Add(dr);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return dt;
            }
        }

        /// <summary>
        /// Возвращается таблица статусов
        /// </summary>
        public DataTable Status
        {
            get
            {
                DataTable dt = new DataTable("statuses");
                DataColumn colName;
                colName = new DataColumn("name", typeof(String));
                dt.Columns.AddRange(new DataColumn[] { colName });

                try
                {
                    DataRow dr = null;
                    string[] bankValues = null;

                    for (int i = 0; i < mBanks.Length; i++)
                    {
                        if (!String.IsNullOrEmpty(mBanks[i]))
                        {
                            bankValues = mBanks[i].Split(',');
                            dr = dt.NewRow();
                            dr["name"] = bankValues[0];
                            dt.Rows.Add(dr);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return dt;
            }
        }

        /// <summary>
        /// Возвращаются тестовые данные
        /// </summary>
        public DataTable Test
        {
            get
            {
                DataTable dt = new DataTable("tests");

                #region Create columns

                DataColumn colNumber;
                colNumber = new DataColumn("number", typeof(String));
                colNumber.Caption = "Номер счета";

                DataColumn colDate;
                colDate = new DataColumn("dt", typeof(DateTime));
                colDate.Caption = "Дата счета";

                DataColumn colBank;
                colBank = new DataColumn("bank", typeof(String));
                colBank.Caption = "Банк";

                DataColumn colSurname;
                colSurname = new DataColumn("surname", typeof(String));
                colSurname.Caption = "Фамилия";

                DataColumn colName;
                colName = new DataColumn("name", typeof(String));
                colName.Caption = "Имя";

                DataColumn colPatronymic;
                colPatronymic = new DataColumn("patronymic", typeof(String));
                colPatronymic.Caption = "Отчество";

                DataColumn colSum;
                colSum = new DataColumn("sum", typeof(String));
                colSum.Caption = "Сумма счета";

                DataColumn colBasis;
                colBasis = new DataColumn("basis", typeof(String));
                colBasis.Caption = "Основание платежа";

                DataColumn colStatus;
                colStatus = new DataColumn("status", typeof(String));
                colStatus.Caption = "Статус счета";

                DataColumn colPhone;
                colPhone = new DataColumn("phone", typeof(String));
                colPhone.Caption = "Телефон";

                DataColumn colLogin;
                colLogin = new DataColumn("login", typeof(String));
                colLogin.Caption = "Логин";

                #endregion

                dt.Columns.AddRange(new DataColumn[] { colNumber, colDate, colBank, colSurname, colName, colPatronymic, 
                    colSum, colStatus, colBasis, colPhone, colLogin});

                try
                {
                    DataRow dr = null;
                    string[] testValues = null;

                    for (int i = 0; i < mTest.Length; i++)
                    {
                        if (!String.IsNullOrEmpty(mTest[i]))
                        {
                            testValues = mTest[i].Split(';');
                            dr = dt.NewRow();

                            dr["number"] = testValues[0];
                            dr["dt"] = testValues[1];
                            dr["bank"] = testValues[2];
                            dr["surname"] = testValues[3];
                            dr["name"] = testValues[4];
                            dr["patronymic"] = testValues[5];
                            dr["sum"] = testValues[6];
                            dr["status"] = testValues[8];
                            dr["basis"] = testValues[7];
                            dr["phone"] = testValues[9];
                            dr["login"] = testValues[10];

                            dt.Rows.Add(dr);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return dt;
            }
        }

        /// <summary>
        /// Считывает данные из файлов
        /// </summary>
        public void LoadFile()
        {
            try
            {
                mBanks = File.ReadAllLines(Application.StartupPath + @"\Banks.csv", Encoding.Default);
                mStatus = File.ReadAllLines(Application.StartupPath + @"\Status.csv", Encoding.Default);
                mTest = File.ReadAllLines(Application.StartupPath + @"\Test.csv", Encoding.Default);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        #region Fields

        private string[] mBanks;
        private string[] mStatus;
        private string[] mTest;
        private static CsvPrototype item;

        #endregion

    }

}

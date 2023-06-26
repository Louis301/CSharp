using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace Test_lesson
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;
        private Excel.Application xlApp; //Екземпляр приложения Excel
        private Excel.Worksheet xlSheet; //Лист
        private Excel.Range xlSheetRange; //Выделеная область

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);

            sqlConnection.Open();

            ////if(sqlConnection.State == ConnectionState.Open)
            //{
            //    MessageBox.Show("Подключение установлено");
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"" +
                $"INSERT INTO[payments](ticket, _total, _value, _comission) " +
                $"VALUES" +
                $"({ textBox1.Text }, {textBox2.Text}, {textBox3.Text}, {textBox4.Text})", sqlConnection);

            command.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"" +
                $"INSERT INTO[attr4payments](payment_id, _name, _value) " +
                $"VALUES" +
                $"({ textBox5.Text }, N'{textBox6.Text}', N'{textBox7.Text}')", sqlConnection);

            command.ExecuteNonQuery();
        }

        private DataTable GetData()
        {
            DataTable dataTable = new DataTable();

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);

            try
            {
                string query = @"DECLARE @r_account NVARCHAR(MAX);
                    DECLARE @r_address NVARCHAR(MAX);
                    DECLARE @month NVARCHAR(MAX);
                    DECLARE @year NVARCHAR(MAX);
 
                    SELECT DISTINCT
	                    p.row_id AS N'Ид. платежа',
	                    p.ticket AS N'Номер квитанции',
	                    p._total AS N'Сумма платежа',
	                    p._comission AS N'Комиссия плательщика',

	                    (SELECT a._value
		                    FROM attr4payments AS a 
		                    WHERE a._name = 'R_account' AND a.payment_id = p.row_id) AS N'Лицевой счёт',

	                    (SELECT a._value
		                    FROM attr4payments AS a 
		                    WHERE a._name = 'R_address' AND a.payment_id = p.row_id) AS N'Адрес',

	                    CONCAT(
		                    (SELECT a._value 
		                    FROM attr4payments AS a 
		                    WHERE a._name = 'Month' AND a.payment_id = p.row_id), 
		                    '.', 
		                    (SELECT a._value 
		                    FROM attr4payments AS a 
		                    WHERE a._name = 'Year' AND a.payment_id = p.row_id)) AS N'Период оплаты'
                    FROM 
	                    payments AS p, attr4payments AS a
					WHERE 
						p.row_Id = a.payment_id;";

                var command = new SqlCommand(query, sqlConnection);
                var dataAdapter = new SqlDataAdapter(command);
                var dataSet = new DataSet();

                sqlConnection.Open();

                dataAdapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
            return dataTable;
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show(ex.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                GC.Collect();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            xlApp = new Excel.Application();

            try
            {
                //добавляем книгу
                xlApp.Workbooks.Add(Type.Missing);

                //делаем временно неактивным документ
                xlApp.Interactive = false;
                xlApp.EnableEvents = false;

                //выбираем лист на котором будем работать (Лист 1)
                xlSheet = (Excel.Worksheet)xlApp.Sheets[1];

                //Название листа
                xlSheet.Name = "Данные";

                //Выгрузка данных
                DataTable dataTable = GetData();

                int collInd = 0;
                int rowInd = 0;
                string data = "";

                //называем колонки
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    data = dataTable.Columns[i].ColumnName.ToString();
                    xlSheet.Cells[1, i + 1] = data;

                    //выделяем первую строку
                    xlSheetRange = xlSheet.get_Range("A1:Z1", Type.Missing);

                    //делаем полужирный текст и перенос слов
                    xlSheetRange.WrapText = true;
                    xlSheetRange.Font.Bold = true;
                }

                //заполняем строки
                for (rowInd = 0; rowInd < dataTable.Rows.Count; rowInd++)
                {
                    for (collInd = 0; collInd < dataTable.Columns.Count; collInd++)
                    {
                        data = dataTable.Rows[rowInd].ItemArray[collInd].ToString();
                        xlSheet.Cells[rowInd + 2, collInd + 1] = data;
                    }
                }

                //выбираем всю область данных
                xlSheetRange = xlSheet.UsedRange;

                //выравниваем строки и колонки по их содержимому
                xlSheetRange.Columns.AutoFit();
                xlSheetRange.Rows.AutoFit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //Показываем ексель
                xlApp.Visible = true;
                xlApp.Interactive = true;
                xlApp.ScreenUpdating = true;
                xlApp.UserControl = true;

                //Отсоединяемся от Excel
                releaseObject(xlSheetRange);
                releaseObject(xlSheet);
                releaseObject(xlApp);
            }
        }
    }
}

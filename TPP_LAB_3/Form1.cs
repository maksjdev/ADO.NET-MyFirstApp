using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Mono.Security;

namespace TPP_LAB_3
{
    public partial class Form1 : Form
    {

        //Ссылка на подключение
        private NpgsqlConnection connection = null;
        //Ссылка на DataSet
        private DataSet dataSet = null;
        //Ссылки на DataAdapter для группы и студента
        private NpgsqlDataAdapter providerDataAdapter = null;
        private NpgsqlDataAdapter productDataAdapter = null;

        //Ссылки на вспомогательные формы
        private Form2 form2 = null;
        private Form3 form3 = null;
        private Form4 form4 = null;

        public string tableMain = "Providers";
        public string tableTwo = "Products";

        public Form1()
        {
            InitializeComponent();
        }


        //Создание DataSet
        private DataSet getDataSet()
        {
            if (dataSet == null)
            {
                dataSet = new DataSet();
                dataSet.Tables.Add(tableMain);
                dataSet.Tables.Add(tableTwo);
            }
            return dataSet;
        }

        //Получить форму установления соединения
        public Form2 getForm2()
        {
            if (form2 == null)
            {
                form2 = new Form2();
                form2.setPerent(this);
            }
            return form2;
        }

        //Получить форму добавления и замены группы
        public Form3 getForm3()
        {
            if (form3 == null)
            {
                form3 = new Form3();
                form3.setPerent(this);
            }
            return form3;
        }

        //Получить форму добавления и замены товара
        public Form4 getForm4()
        {
            if (form4 == null)
            {
                form4 = new Form4();
                form4.setPerent(this);
            }
            return form4;
        }

        public void setConnection(NpgsqlConnection connection)
        {
            this.connection = connection;
        }

        //Установить соединение с базой
        public NpgsqlConnection Connect(string host, int port, string database, string user, string parol)
        {
            NpgsqlConnectionStringBuilder stringBuilder = new NpgsqlConnectionStringBuilder();
            stringBuilder.Host = host;
            stringBuilder.Port = port;
            stringBuilder.UserName = user;
            stringBuilder.Password = parol;
            stringBuilder.Database = database;
            stringBuilder.Timeout = 50;
            NpgsqlConnection connection = new NpgsqlConnection(stringBuilder.ConnectionString);
            try {
                connection.Open();
                return connection;
            } catch (Exception error) {
                Console.WriteLine(error);
                return null;
            }
        }


        //Заполнить DataGridView1 поставщиками
        public void FillDataGridView1ByProviders()
        {
            getDataSet().Tables[tableMain].Clear();
            providerDataAdapter = new NpgsqlDataAdapter("SELECT * FROM " + tableMain + " ORDER BY id ASC", connection);
            new NpgsqlCommandBuilder(providerDataAdapter);
            providerDataAdapter.Fill(getDataSet(), tableMain);
            dataGridView1.DataSource = getDataSet().Tables[tableMain];
        }

        //Заполнить DataGridView2 товарами заданного поставщика
        public void FillDataGridView2ByProducts(string providerName)
        {
            getDataSet().Tables[tableTwo].Clear();
            productDataAdapter = new NpgsqlDataAdapter(
                 "SELECT "+ tableTwo + ".id, name, description, releasedate, price, providerid " +
                 "FROM "+ tableMain + ", "+ tableTwo + " " +
                 "WHERE "+ tableMain + ".id = Products.providerid AND providername = '" +
                  providerName + "' ORDER BY id ASC", connection);
            new NpgsqlCommandBuilder(productDataAdapter);
            productDataAdapter.Fill(dataSet, tableTwo);
            dataGridView2.DataSource = getDataSet().Tables[tableTwo];
        }




        //Добавить группу
        public void AddProvider(string providerName, string ownerName, string notes)
        {
            getDataSet().Tables[tableMain].Rows.Add(0, providerName, ownerName, notes);
            providerDataAdapter.Update(getDataSet(), tableMain);
        }
        //Заменить группу
        public void UpdateGroup(int row, string providerName, string ownerName, string notes)
        {
            getDataSet().Tables[tableMain].Rows[row]["providername"] = providerName;
            getDataSet().Tables[tableMain].Rows[row]["ownername"] = ownerName;
            getDataSet().Tables[tableMain].Rows[row]["notes"] = notes;
            providerDataAdapter.Update(getDataSet(), tableMain);
        }


        //Обработчик нажатия на "Добавить поставщика"
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getForm3().Visible = true;
            getForm3().setButton1Visible(true);
            getForm3().setButton2Visible(false);
            getForm3().setTextBox1Text("");
            getForm3().setTextBox2Text("");
            getForm3().setTextBox3Text("");

        }
        //Нажатие на "Удалить поставщика"
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridView1.CurrentCell.RowIndex;
            Console.WriteLine(dataGridView1.CurrentCell.Value.ToString());
            DialogResult dr = MessageBox.Show("Удалить поставщика? (" + selectedRow + ")", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                getDataSet().Tables[tableMain].Rows[selectedRow].Delete();
                providerDataAdapter.Update(getDataSet(), tableMain);
                getDataSet().Clear();
                FillDataGridView1ByProviders();
            }

        }
        //Нажатие на "Заменить поставщика"
        private void заменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridView1.CurrentCell.RowIndex;
            try {
                string providerName = (string)getDataSet().Tables[tableMain].Rows[selectedRow].ItemArray[1];
                string ownerName = (string)getDataSet().Tables[tableMain].Rows[selectedRow].ItemArray[2];
                string notes = (string)getDataSet().Tables[tableMain].Rows[selectedRow].ItemArray[3];

                getForm3().Visible = true;
                getForm3().setButton1Visible(false);
                getForm3().setButton2Visible(true);
                getForm3().setTextBox1Text(providerName);
                getForm3().setTextBox2Text(ownerName);
                getForm3().setTextBox3Text(notes);
                getForm3().setRow(selectedRow);
            } catch (Exception error) {
                Console.WriteLine(error);
            }
        }

        //Обработчик нажатия на строчку DataGridView1
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = dataGridView1.CurrentCell.RowIndex;
            string providerName = (string) dataGridView1.Rows[selectedRow].Cells[1].Value;
            FillDataGridView2ByProducts(providerName);
        }




        //Добавить товар
        public void AddProduct(string name, string description, DateTime releaseDate, int price, long providerId)
        {
            try
            {
                // Перевод времени в timestamp
                getDataSet().Tables[tableTwo].Rows.Add(0, name, description, releaseDate, price, providerId);
                productDataAdapter.Update(getDataSet(), tableTwo);
            } catch (Exception error) {
                Console.WriteLine(error);
            }
        }
        //Заменить товар
        public void UpdateProduct(int row, string name, string description, DateTime releaseDate, int price)
        {
            getDataSet().Tables[tableTwo].Rows[row]["name"] = name;
            getDataSet().Tables[tableTwo].Rows[row]["description"] = description;
            getDataSet().Tables[tableTwo].Rows[row]["releasedate"] = releaseDate;
            getDataSet().Tables[tableTwo].Rows[row]["price"] = price;
            productDataAdapter.Update(getDataSet(), tableTwo);
        }



        // Вспомагательные методы
        // "Сброс формы при открытии товара
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try {
                getForm4().Visible = true;
                getForm4().setButton1Visible(true);
                getForm4().setButton2Visible(false);
                getForm4().setTextBox1Text("");
                getForm4().setTextBox2Text("");
                getForm4().setDateTimePicker1(DateTime.Today);
                getForm4().setTextBox4Text("");

                int selectedRow = dataGridView1.CurrentCell.RowIndex;
                long providerId = (long)getDataSet().Tables[tableMain].Rows[selectedRow].ItemArray[0];
                string providerName = (string)getDataSet().Tables[tableMain].Rows[selectedRow].ItemArray[1];

                getForm4().setProviderName(providerName);
                getForm4().setTitle("Добавление", providerName);
                getForm4().setProviderId(providerId);
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }
        // Удаление товара и "перерендер"
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = dataGridView2.CurrentCell.RowIndex;
                DialogResult dr = MessageBox.Show("Удалить товар? (" + selectedRow + ")", "", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    getDataSet().Tables[tableTwo].Rows[selectedRow].Delete();
                    productDataAdapter.Update(getDataSet(), tableTwo);
                    string providerName = (string)dataGridView1.Rows[selectedRow].Cells[1].Value;
                    FillDataGridView2ByProducts(providerName);
                }
            } catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }
        // Установка формы при открытии товара
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = dataGridView2.CurrentCell.RowIndex;
                string name = (string)getDataSet().Tables[tableTwo].Rows[selectedRow].ItemArray[1];
                string description = (string)getDataSet().Tables[tableTwo].Rows[selectedRow].ItemArray[2];
                DateTime releaseDate = (DateTime)getDataSet().Tables[tableTwo].Rows[selectedRow].ItemArray[3];
                int price = (int)getDataSet().Tables[tableTwo].Rows[selectedRow].ItemArray[4];
                string sPrice = System.Convert.ToString(price);

                getForm4().Visible = true;
                getForm4().setButton1Visible(false);
                getForm4().setButton2Visible(true);
                getForm4().setTextBox1Text(name);
                getForm4().setTextBox2Text(description);
                getForm4().setDateTimePicker1(releaseDate);
                getForm4().setTextBox4Text(sPrice);
                getForm4().setRow(selectedRow);

                int selectedRow1 = dataGridView1.CurrentCell.RowIndex;
                string providerName = (string)getDataSet().Tables[tableMain].Rows[selectedRow1].ItemArray[1];
                getForm4().setProviderName(providerName);
                getForm4().setTitle("Изменение", providerName);

            } catch (Exception error)
            {
                Console.WriteLine(error);
            }
            
        }

        private void подключениеКБазеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getForm2().Visible = true;
        }
        private void отключениеОтБазыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try{
                connection.Close();
            } catch (Exception error) {
                Console.WriteLine(error);
            }
        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}

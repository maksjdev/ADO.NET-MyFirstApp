using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPP_LAB_3
{
    public partial class Form4 : Form
    {

        private Form1 perent = null;
        private string providerName;
        private long providerId;
        private int row;


        public Form4()
        {
            //dateTimePicker1.MaxDate = DateTime.Today;
            InitializeComponent();
        }



        //методы по установлению вышеописанных полей
        public void setPerent(Form1 perent)
        {
            this.perent = perent;
        }

        public void setProviderName(string name)
        {
            this.providerName = name;
        }
        public void setProviderId(long id)
        {
            this.providerId = id;
        }
        public void setRow(int row)
        {
            this.row = row;
        }
        public void setTitle(string operation,string provider)
        {
            provider = provider.Length > 0 ? provider : "...";
            this.Text = operation + " товара (" + provider + ")";
        }

        //методы для установления свойств компонентов формы
        public void setTextBox1Text(string text)
        {
            textBox1.Text = text;
        }

        public void setTextBox2Text(string text)
        {
            textBox2.Text = text;
        }

        public void setDateTimePicker1(DateTime date)
        {
            dateTimePicker1.Value = date;
        }

        public void setTextBox4Text(string text)
        {
            textBox4.Text = text;
        }

        public void setButton1Visible(bool value)
        {
            this.button1.Visible = value;
        }

        public void setButton2Visible(bool value)
        {
            this.button2.Visible = value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                DateTime release = dateTimePicker1.Value;
                int price = Int16.Parse(textBox4.Text);
                perent.AddProduct(textBox1.Text, textBox2.Text, release, price, providerId);
                perent.FillDataGridView2ByProducts(providerName);
                this.Visible = false;
            } catch (Exception error)
            {
                Console.WriteLine(error);
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {  
            try
            {
                DateTime release = dateTimePicker1.Value;
                int price = Convert.ToInt32(textBox4.Text);
                perent.UpdateProduct(row, textBox1.Text, textBox2.Text, release, price);
                perent.FillDataGridView2ByProducts(providerName);
                this.Visible = false;
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

    }
}

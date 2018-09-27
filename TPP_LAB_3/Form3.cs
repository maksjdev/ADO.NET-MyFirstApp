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
    public partial class Form3 : Form
    {

        private Form1 perent = null;
        private int row;


        public Form3()
        {
            InitializeComponent();
        }


        // методы по установлению значений полей
        public void setPerent(Form1 perent)
        {
            this.perent = perent;
        }

        public void setRow(int row)
        {
            this.row = row;
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

        public void setTextBox3Text(string text)
        {
            textBox3.Text = text;
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
            perent.AddProvider(textBox1.Text, textBox2.Text, textBox3.Text);
            perent.FillDataGridView1ByProviders();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            perent.UpdateGroup(row, textBox1.Text, textBox2.Text, textBox3.Text);
            perent.FillDataGridView1ByProviders();
            this.Visible = false;

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winForm_1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addInvoice_Button_Click(object sender, EventArgs e)
        {
           string supName = combo_SupName.Text;
            string invID = text_InvID.Text;
            string invDate = date_InvDate.Value.ToShortDateString();
            float invPrice = float.Parse(text_Price.Text);
            string invNote = text_Note.Text;
            MessageBox.Show("Invoice Added! " + supName + " " + invID + " "+ date_InvDate + " " + invPrice + " " + invNote);
        }
    }
}

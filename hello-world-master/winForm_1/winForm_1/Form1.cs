using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            float invSum = float.Parse(text_Price.Text);
            string invNote = text_Note.Text;

            string tocmd = "INSERT INTO Invoices VALUES ('" + invID + "', '" + supName + "', '" + invDate + "', " + invSum + ", '" + invNote + "')";
            addInvoice(tocmd);
           // string connetionString;
           // SqlConnection cnn;
           // connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\pluginDataBase1.mdf;Integrated Security=True";
          //  cnn = new SqlConnection(connetionString);
            //string tocmd = "INSERT INTO Invoices VALUES ('" + invID + "', '" + supName + "', '" + invDate + "', " + invSum + ", '" + invNote + "')";
           // MessageBox.Show("string tocmd is: " + tocmd);
           // SqlCommand cmd = new SqlCommand(tocmd, cnn);
        }

        private void addSupplier_Click(object sender, EventArgs e)
        {
            Form2 addSup = new Form2();
            addSup.Show();
        }

        private void Exit_Btn1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void addInvoice(string tocmd)
        {
            using (SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\pluginDataBase1.mdf;Integrated Security=True"))
            {
                cnn.Open();
                MessageBox.Show("Connection Open");
                try
                {
                    SqlCommand cmd = new SqlCommand(tocmd, cnn);
                    cmd.ExecuteNonQuery();
                }
                catch(Exception exc)
                {
                    Console.WriteLine(exc.ToString());
                    MessageBox.Show("Some error accord, check console output for more info");
                }
                //cnn.Close();
             //   MessageBox.Show("Connection Closed");
            }
        }
    }
}

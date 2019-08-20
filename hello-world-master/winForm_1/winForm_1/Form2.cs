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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void text_InvID_TextChanged(object sender, EventArgs e)
        {

        }

        private void combo_SupName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addInvoice_Button_Click(object sender, EventArgs e)
        {
            string supName = supName_textBox.Text;
            string supCat = SupCategory_combobox.Text;
            string supMail = supMail_textBox.Text;
            string supContact = supContact_textBox.Text;
            string supPhone = supPhone_textBox.Text;

            // string connetionString;
            //  SqlConnection cnn;
            //  connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\pluginDataBase1.mdf;Integrated Security=True";
            //  cnn = new SqlConnection(connetionString);
            string addSupCmd = "INSERT INTO Suppliers VALUES ('" + supName + "', '" + supCat + "', '" + supMail + "', '" + supContact + "', '" + supPhone + "')";
            addSupplier(addSupCmd);
            //   MessageBox.Show("string tocmd is: " + tocmd);
            //   SqlCommand cmd = new SqlCommand(tocmd, cnn);
        }

        public static void addSupplier(string addSupCmd)
        {
            using (SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\pluginDataBase1.mdf;Integrated Security=True"))
            {
                cnn.Open();
                MessageBox.Show("Connection Open");
                try
                {
                    SqlCommand cmd = new SqlCommand(addSupCmd, cnn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.ToString());
                    MessageBox.Show("Some error accord, check console output for more info");
                }
                //cnn.Close();
                //   MessageBox.Show("Connection Closed");
            }
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConsoleApp1
{
    public partial class UserControl6 : UserControl
    {

        string connection = @"DATA SOURCE=ZA;Initial Catalog=REGISTRATION;Integrated Security=True;";

        public UserControl6()
        {
            InitializeComponent();
           
        }

        private void label_Firstname(object sender, EventArgs e)
        {

        }

        
        void Clear()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
        }

        private void textBox_Firstname(object sender, EventArgs e)
        {

        }

        private void textBox_Lastname(object sender, EventArgs e)
        {

        }

        private void textBox_Gsm(object sender, EventArgs e)
        {

        }

        private void textBox_Adress(object sender, EventArgs e)
        {

        }

        private void xButton_Submit(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connection))
                {

                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("Userdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@FirstName", textBox1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LastName", textBox2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Contact", textBox3.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Address", textBox4.Text.Trim());
                    MessageBox.Show("registartion succesfull");
                    sqlCmd.ExecuteNonQuery();
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            

         
        }

        private void UserControl6_Load(object sender, EventArgs e)
        {

        }

        private void label_Lastname(object sender, EventArgs e)
        {

        }

        private void label_Gsm(object sender, EventArgs e)
        {

        }

        private void label_Adress(object sender, EventArgs e)
        {

        }

        private void xButton_Cancel(object sender, EventArgs e)
        {

        }
    }
}

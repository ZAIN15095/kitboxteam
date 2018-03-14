using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    public partial class UserControl6 : UserControl
    {

        string connection = @"DATA SOURCE=ZA;Initial Catalog=REGISTRATION;Integrated Security=True;";

        public UserControl6()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        void Clear()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void xButton1_Click(object sender, EventArgs e)
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
    }
}

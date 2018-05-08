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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonModified1_Click(object sender, EventArgs e)
        {

        }
        private void buttonModified2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void xButton1_Click(object sender, EventArgs e)
        {
                try
                {


                    SqlConnection con = new SqlConnection("server=ZA;database=LOGIN;Integrated Security=true");
                    SqlCommand conn = new SqlCommand("SELECT * FROM log WHERE USERNAME=@user and PASSWORD=@pw", con);
                    con.Open();
                    conn.Parameters.AddWithValue("@user", textBox1.Text);
                    conn.Parameters.AddWithValue("@pw", textBox2.Text);
                    SqlDataReader Dr = conn.ExecuteReader();

                    Form4 f4 = new Form4();
                    f4.Show();
                    Form2 f2 = new Form2();
                    f2.Close();


            }

            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

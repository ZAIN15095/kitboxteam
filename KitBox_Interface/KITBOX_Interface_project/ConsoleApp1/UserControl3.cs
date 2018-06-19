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
                if (Login.Text == "groupe5")
                {
                    if ( Mdp.Text == "123")
                    {
                        this.BackgroundImage = null;
                        this.Controls.Clear();
                        this.Controls.Add(new InterfaceManager());
                    }

                    else
                    {
                        LoginI.Visible = false;
                        MdpI.Visible = true;
                        Mdp.Clear();
                    }
                }
                else
                {
                    LoginI.Visible = true;
                    Login.Clear();
                    Mdp.Clear();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new Home());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void UserControl3_Load(object sender, EventArgs e)
        {

        }
    }
}

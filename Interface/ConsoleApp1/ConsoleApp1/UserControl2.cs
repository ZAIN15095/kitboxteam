using System;
using KITBOX_project;
using System.Windows.Forms;

namespace ConsoleApp1
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void label_Width(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_Help(object sender, EventArgs e)
        {

        }

        private void button2_Back(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new Home());
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UserControl6());
        }

        private void button_Back(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new Home());
        }

        private void Label_Next(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_Width(object sender, EventArgs e)
        {
            int width = Convert.ToInt32(this.width);
            int depth = Convert.ToInt32(this.depth);
            Dimensions UDpanel_dim = new Dimensions(0, width, depth);
            Dimensions LRpanel_dim = new Dimensions(0, 0, depth);
            Dimensions Battens_dim = new Dimensions(0, 0, 0);
            Dimensions Backpannel_dim = new Dimensions(0, width, 0);
            Dimensions FBcrossbar_dim = new Dimensions(0, width, 0);
            Dimensions LRcrossbar_dim = new Dimensions(0, 0, depth);
        }

        private void label_Dimensions(object sender, EventArgs e)
        {

        }

        private void label_Depth(object sender, EventArgs e)
        {

        }

        private void comboBox_Depth(object sender, EventArgs e)
        {

        }
    }
}

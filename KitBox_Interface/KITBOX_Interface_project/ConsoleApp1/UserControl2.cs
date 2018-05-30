using System;
using KITBOX_project;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConsoleApp1
{
    public partial class UserControl2 : UserControl
    {
        //declaration of variables
        public static Dictionary<string, Rack> command = new Dictionary<string, Rack>();//declaration of rack
        public static int widthValue;
        public static int depthValue;
        public static Dimensions dimensions;


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

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new Home());
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //width value
            Object selectedWithBox = width.SelectedItem;
            widthValue = Convert.ToInt32(selectedWithBox);

            //depth value
            Object selectedDepthBox = depth.SelectedItem;
            int depthValue = Convert.ToInt32(selectedDepthBox);

            //Object Dimensions
            dimensions = new Dimensions(0, widthValue, depthValue);

            if (!widthValue.Equals(0) && !depthValue.Equals(0))
            {
                this.BackgroundImage = null;
                this.Controls.Clear();
                this.Controls.Add(new InterfaceCasier1());
            }
            else
                MessageBox.Show("Veuillez entrez la largeur et la profondeur de votre armoire", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void EndButton_Click(object sender, EventArgs e)
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

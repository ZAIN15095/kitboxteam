using System;
using KITBOX_project;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    public partial class InterfaceCasier1 : UserControl
    {
        //declaration of variables
        public static int heightValue;

        public InterfaceCasier1()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //height value
            Object selectedHeightBox = HeigthText.SelectedItem;
            heightValue = Convert.ToInt32(selectedHeightBox);

            //insert height to Dimensions
            UserControl2.dimensions.Height = heightValue;
 Battens battens = new Battens(UserControl2.dimensions);

            //test de passage de variable (the object Dimensions bas)
            MessageBox.Show("height = " + Convert.ToString(UserControl2.dimensions.Height) + "  " +
                "witdh = " + Convert.ToString(UserControl2.dimensions.Width) + "  " +
                "depth = " + Convert.ToString(UserControl2.dimensions.Depth));
            

            LRpanel lrpanel = new LRpanel("brun", UserControl2.dimensions);
            MessageBox.Show(lrpanel.Color + lrpanel.Name);



            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new InterfaceCasier2());
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UserControl2());

        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new Home());
        }

        private void InterfaceCasier1_Load(object sender, EventArgs e)
        {

        }
    }
}

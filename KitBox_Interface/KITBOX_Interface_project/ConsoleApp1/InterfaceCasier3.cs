using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KITBOX_project;

namespace ConsoleApp1
{
    public partial class InterfaceCasier3 : UserControl
    {
        //declaration of variables
        public static int heightValue;
        public static string panelColor;

        public static Dimensions dimensions;
        public static AngleBar anglebar;
        public static LRpanel lrpanel;
        public static Battens battens;
        public static UDpanel udpanel;
        public static BackPanel backPanel;
        public static BCrossbar bcrossbar;
        public static FCrossbar fcrossbar;
        public static LRcrossbar lrcrossbar;
        public static Rack rack;
        public InterfaceCasier3()
        {
            InitializeComponent();
        }

        private void HeigthText_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {

            //height value
            heightValue = Convert.ToInt32(HeigthText.Text);

            //creating dimension for the rack
            dimensions = new Dimensions(heightValue, UserControl2.widthValue, UserControl2.depthValue);





            // creating objects
            panelColor = PanelColorText.Text;
            udpanel = new UDpanel(panelColor, dimensions);
            backPanel = new BackPanel(panelColor, dimensions);
            bcrossbar = new BCrossbar(dimensions);
            fcrossbar = new FCrossbar(dimensions);
            lrcrossbar = new LRcrossbar(dimensions);
            anglebar = new AngleBar(panelColor, dimensions);
            lrpanel = new LRpanel(panelColor, dimensions);
            battens = new Battens(dimensions);

            rack = new Rack(
                battens, lrpanel, udpanel, backPanel, fcrossbar, bcrossbar, lrcrossbar, anglebar);

            //display the rack create
            MessageBox.Show(
                "Rack 3 constitution" + "\n" +
                battens.ToString() + "\n" +
                udpanel.ToString() + "\n" +
                backPanel.ToString() + "\n" +
                bcrossbar.ToString() + "\n" +
                fcrossbar.ToString() + "\n" +
                fcrossbar.ToString() + "\n" +
                lrcrossbar.ToString() + "\n" +
                anglebar.ToString() + "\n" +
                lrpanel.ToString() + "\n");

            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new InterfaceCasier4());

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new InterfaceCasier2());
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new Home());
        }

        private void InterfaceCasier3_Load(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new InterfaceCommande());
        }
    }
}

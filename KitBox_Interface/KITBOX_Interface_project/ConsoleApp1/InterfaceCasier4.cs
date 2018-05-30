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
    public partial class InterfaceCasier4 : UserControl
    {
        //declaration of variables
        public static int heightValue;
        public static string panelColor;
        public static string doorColor;
        public static Rack rack;

        public static AngleBar anglebar;
        public static LRpanel lrpanel;
        public static Battens battens;
        public static UDpanel udpanel;
        public static BackPanel backPanel;
        public static BCrossbar bcrossbar;
        public static FCrossbar fcrossbar;
        public static LRcrossbar lrcrossbar;
        public static Door door = null;

        public InterfaceCasier4()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            CreateObject();

            if (!panelColor.Equals("") && !heightValue.Equals(0))
            {
                //choose door or not
                if (DoorSelect.Checked)
                {
                    doorColor = DoorColorText.Text;
                    door = new Door(doorColor, UserControl2.dimensions);
                    rack = new Rack(
                    battens, lrpanel, udpanel, backPanel, fcrossbar, bcrossbar, lrcrossbar, anglebar, door);
                    //cette partie fait mal le travail puisque quand colorDoorValue == "" il va quand meme vers 
                    //l'interface suivante
                    //donc a revoir cette partie
                    if (!doorColor.Equals(""))
                    {
                        UserControl2.command.Add("CASIER 4", rack);

                        this.BackgroundImage = null;
                        this.Controls.Clear();
                        this.Controls.Add(new InterfaceCasier5());
                    }
                    else
                    {
                        MessageBox.Show("Veuillez choisir la couleur de la porte de votre casier", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    rack = new Rack(
                    battens, lrpanel, udpanel, backPanel, fcrossbar, bcrossbar, lrcrossbar, anglebar, door);
                    UserControl2.command.Add("CASIER 4", rack);

                    this.BackgroundImage = null;
                    this.Controls.Clear();
                    this.Controls.Add(new InterfaceCasier5());
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrez la hauteur et la color des panneaux de votre casier", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new InterfaceCasier3());

        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new Home());
        }

        private void InterfaceCasier4_Load(object sender, EventArgs e)
        {
            Do_checked();
        }

        //objects initialisation
        public void CreateObject()
        {
            //height value
            heightValue = Convert.ToInt32(HeigthText.Text);

            //insert height to Dimensions
            UserControl2.dimensions.Height = heightValue;

            // creating objects
            panelColor = PanelColorText.Text;
            udpanel = new UDpanel(panelColor, UserControl2.dimensions);
            backPanel = new BackPanel(panelColor, UserControl2.dimensions);
            bcrossbar = new BCrossbar(UserControl2.dimensions);
            fcrossbar = new FCrossbar(UserControl2.dimensions);
            lrcrossbar = new LRcrossbar(UserControl2.dimensions);
            anglebar = new AngleBar(panelColor, UserControl2.dimensions);
            lrpanel = new LRpanel(panelColor, UserControl2.dimensions);
            battens = new Battens(UserControl2.dimensions);

        }

        //activation of DoorColorText
        private void Do_checked()
        {
            //activation of DoorColorText if DoorSelect is select
            DoorColorText.Enabled = DoorSelect.Checked;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            CreateObject();

            if (!panelColor.Equals("") && !heightValue.Equals(0))
            {
                if (DoorSelect.Checked)
                {
                    doorColor = DoorColorText.Text;
                    door = new Door(doorColor, UserControl2.dimensions);
                    rack = new Rack(
                    battens, lrpanel, udpanel, backPanel, fcrossbar, bcrossbar, lrcrossbar, anglebar, door);

                    UserControl2.command.Add("CASIER 4", rack);

                    this.BackgroundImage = null;
                    this.Controls.Clear();
                    this.Controls.Add(new InterfaceCommande());

                }
                else
                {
                    rack = new Rack(
                    battens, lrpanel, udpanel, backPanel, fcrossbar, bcrossbar, lrcrossbar, anglebar, door);
                    UserControl2.command.Add("CASIER 4", rack);

                    this.BackgroundImage = null;
                    this.Controls.Clear();
                    this.Controls.Add(new InterfaceCommande());
                }

            }
            else
                MessageBox.Show("Veuillez entrez la hauteur et la color des panneaux de votre casier", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void HeigthText_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DoorSelect_CheckedChanged_1(object sender, EventArgs e)
        {
            Do_checked();
        }
    }
}

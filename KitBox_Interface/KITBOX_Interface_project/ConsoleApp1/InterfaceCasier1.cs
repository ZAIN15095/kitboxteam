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
        public static Dictionary<string, List<Object>> rack = new Dictionary<string, List<Object>>();//declaration of rack
        public static List<Object> items = new List<Object>(); //declaration of items
        public static int heightValue;
        public static string colorPanelValue;
        public static string colorDoorValue;
        public static LRpanel lrpanel;
        public static Battens battens;
        public static Door door;

        public InterfaceCasier1()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //height value
            Object selectedHeightBox = HeigthText.SelectedItem;
            heightValue = Convert.ToInt32(selectedHeightBox);

            //PanelColor value
            Object selectedPanelColorBox = PanelColorText.SelectedItem;
            colorPanelValue = Convert.ToString(selectedPanelColorBox);

            //insert height to Dimensions
            UserControl2.dimensions.Height = heightValue;

            //battens object
            battens = new Battens(UserControl2.dimensions.Height, UserControl2.dimensions);

            //test de passage de variable (the object Dimensions bas)
            MessageBox.Show("height = " + Convert.ToString(UserControl2.dimensions.Height) + "  " +
                "witdh = " + Convert.ToString(UserControl2.dimensions.Width) + "  " +
                "depth = " + Convert.ToString(UserControl2.dimensions.Depth));
            
            // panels object
            lrpanel = new LRpanel (colorPanelValue, UserControl2.dimensions);
            MessageBox.Show("Les panneaux droite de gauche sont de couleurs " + colorPanelValue);

            if (colorPanelValue != ""  && heightValue != 0)
            {
                //choose door or not
                if (DoorSelect.Checked)
                {
                    //DoorColor value
                    Object selectedDoorColorBox = DoorColorText.SelectedItem;
                    colorDoorValue = Convert.ToString(selectedDoorColorBox);

                    //door object
                    door = new Door(colorDoorValue, UserControl2.dimensions);

                    MessageBox.Show("Vous avez une porte de couleur de couleur " + door.Color);

                    //cette partie fait mal le travail puisque quand colorDoorValue == "" il va quand meme vers 
                    //l'interface suivante
                    //donc a revoir cette partie
                    if (colorDoorValue == "")
                    {
                        MessageBox.Show("Veuillez choisir la couleur de la porte de votre casier");
                    }
                    else
                        this.BackgroundImage = null;
                        this.Controls.Clear();
                        this.Controls.Add(new InterfaceCasier2());


                }
                else
                    MessageBox.Show("Vous n'avez pas choisi de porte pour ce casier");
                    this.BackgroundImage = null;
                    this.Controls.Clear();
                    this.Controls.Add(new InterfaceCasier2());
            }
            else
                MessageBox.Show("Veuillez entrez la hauteur et la color des panneaux de votre casier");

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
            Do_checked();
        }

        //activation of DoorColorText
        private void Do_checked()
        {
            //activation of DoorColorText if DoorSelect is select
            DoorColorText.Enabled = DoorSelect.Checked;
        }

        private void DoorSelect_CheckedChanged(object sender, EventArgs e)
        {
            Do_checked();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            //rack and rack elements
            items.Add(lrpanel);
            items.Add(battens);
            items.Add(door);
            rack.Add("casier1", items);
        }
    }
}

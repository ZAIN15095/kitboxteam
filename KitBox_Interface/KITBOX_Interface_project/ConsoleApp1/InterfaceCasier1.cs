﻿using System;
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


        public InterfaceCasier1()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Nextstep();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UserControl2());

        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            InterfacePayment.total_price = 0;
            UserControl2.command.Clear();
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new Home());
        }

        private void InterfaceCasier1_Load(object sender, EventArgs e)
        {
            Do_checked();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Finalisation();
        }

        private void PanelColorText_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //objects initialisation
        public void CreateObject()
        {
            //height value
            Object selectedHeightBox = HeigthText.SelectedItem;
            heightValue = Convert.ToInt32(selectedHeightBox);

            //insert height to Dimensions
            UserControl2.dimensions.Height = heightValue;

            // creating objects
            panelColor = PanelColorText.Text;
            udpanel = new UDpanel(panelColor, UserControl2.dimensions);
            backPanel = new BackPanel(heightValue, panelColor, UserControl2.dimensions);
            bcrossbar = new BCrossbar(UserControl2.dimensions);
            fcrossbar = new FCrossbar(UserControl2.dimensions);
            lrcrossbar = new LRcrossbar(UserControl2.dimensions);
            anglebar = new AngleBar(UserControl2.color_Angle, UserControl2.dimensions);
            lrpanel = new LRpanel(heightValue, panelColor, UserControl2.dimensions);
            battens = new Battens(heightValue, UserControl2.dimensions);
            
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

        // Next step
        public void Nextstep()
        {
            CreateObject();

            if (!panelColor.Equals("") && !heightValue.Equals(0))
            {
                //choose door or not
                if (DoorSelect.Checked)
                {
                    doorColor = DoorColorText.Text;
                    door = new Door(heightValue, doorColor, UserControl2.dimensions);
                    rack = new Rack(
                    battens, lrpanel, udpanel, backPanel, fcrossbar, bcrossbar, lrcrossbar, anglebar, door);

                    if (!doorColor.Equals(""))
                    {
                        UserControl2.command.Add("RACK 1", rack);

                        this.BackgroundImage = null;
                        this.Controls.Clear();
                        this.Controls.Add(new InterfaceCasier2());
                    }
                    else
                    {
                        MessageBox.Show("Please choose the color of your rack's door", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    rack = new Rack(
                    battens, lrpanel, udpanel, backPanel, fcrossbar, bcrossbar, lrcrossbar, anglebar, door);
                    UserControl2.command.Add("RACK 1", rack);

                    this.BackgroundImage = null;
                    this.Controls.Clear();
                    this.Controls.Add(new InterfaceCasier2());
                }
            }
            else
            {
                MessageBox.Show("Please enter the height and the color of your panel's rack", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Finalisation method
        public void Finalisation()
        {

            CreateObject();

            if (!panelColor.Equals("") && !heightValue.Equals(0))
            {
                if (DoorSelect.Checked)
                {
                    doorColor = DoorColorText.Text;
                    door = new Door(heightValue, doorColor, UserControl2.dimensions);
                    rack = new Rack(
                    battens, lrpanel, udpanel, backPanel, fcrossbar, bcrossbar, lrcrossbar, anglebar, door);

                    if (!doorColor.Equals(""))
                    {
                        UserControl2.command.Add("RACK 1", rack);

                        this.BackgroundImage = null;
                        this.Controls.Clear();
                        this.Controls.Add(new InterfaceCommande());
                    }
                    else
                    {
                        MessageBox.Show("Please choose the color of your rack's door", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    rack = new Rack(
                    battens, lrpanel, udpanel, backPanel, fcrossbar, bcrossbar, lrcrossbar, anglebar, door);
                    UserControl2.command.Add("RACK 1", rack);

                    this.BackgroundImage = null;
                    this.Controls.Clear();
                    this.Controls.Add(new InterfaceCommande());
                }

            }
            else
                MessageBox.Show("Please enter the height and the color of your panel's rack", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

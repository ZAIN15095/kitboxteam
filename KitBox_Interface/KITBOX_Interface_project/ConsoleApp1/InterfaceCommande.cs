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
using System.Data.OleDb;


namespace ConsoleApp1
{
    public partial class InterfaceCommande : UserControl
    {

        Broker broker = new Broker();

        public InterfaceCommande()
        {
            
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void OrderText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            broker.deleteDoor();
            List<String> dataList = broker.viewData();

            foreach (string elemt in dataList)
            {
                OrderText.Text += elemt;
            }
            

        }

        private void InterfaceCommande_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, Rack> casier in UserControl2.command)
            {
                OrderText.Text += "\t\t" + casier.Key + "\r\n";
                OrderText.AppendText("\r\n");

                OrderText.Text += "Hauteur :\t\t\t" + UserControl2.dimensions.Height + "\r\n";
                OrderText.Text += "Largeur :\t\t\t" + UserControl2.dimensions.Width + "\r\n";
                OrderText.Text += "Profondeur\t\t" + UserControl2.dimensions.Depth + "\r\n";
                OrderText.Text += "Couleur des panneaux :\t" + casier.Value.Lrpanel.Color + "\r\n";

                if (casier.Value.Door != null)
                {
                    OrderText.Text += "Couleur de la porte :\t" + casier.Value.Door.Color + "\r\n";
                    
                }
                else
                {
                    OrderText.Text += ("Vous n'avez pas choisi de porte pour ce casier" + "\r\n");
                }
                OrderText.Text += ("------------------------------------------------------------" + "\r\n");

            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            UserControl2.command.Clear();
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new Home());
        }
    }
}

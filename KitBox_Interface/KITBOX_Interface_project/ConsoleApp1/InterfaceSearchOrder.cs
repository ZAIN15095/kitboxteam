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
    public partial class InterfaceSearchOrder : UserControl
    {
        Broker broker = new Broker();

        public InterfaceSearchOrder()
        {
            InitializeComponent();
        }

        private void InterfaceSearchOrder_Load(object sender, EventArgs e)
        {
            
        }

        private void Seek_Click(object sender, EventArgs e)
        {
            if(Search.Text !="" && Search.Text.Contains(" "))
            {
                commande.Text = broker.Order(Search.Text);
            }
            else
            {
                MessageBox.Show("Enter correctly the client's name and firstname \n Exemple : Kue Guy", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl2.command.Clear();
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new Home());
        }
    }
}

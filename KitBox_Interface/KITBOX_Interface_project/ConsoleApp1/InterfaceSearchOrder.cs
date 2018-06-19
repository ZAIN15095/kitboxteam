using System;
using KITBOX_project;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
            delete.Enabled = false;
        }

        private void Seek_Click(object sender, EventArgs e)
        {
            if((Search.Text !="" && Search.Text.Contains(" ")) || Search.Text.Length == 9)
            {
                commande.Text = broker.Order(Search.Text);
                Finalized.Text = broker.finalized(Search.Text);
                if (broker.finalized(Search.Text) == "No")
                {
                    delete.Enabled = true;
                }
            }

            else
            {
                MessageBox.Show("Enter correctly the client's name and firstname \n Exemple : Kue Guy", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                delete.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl2.command.Clear();
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new Home());
        }

        private void delete_Click(object sender, EventArgs e)
        {
            commande.Text = broker.UpdateOrder(Search.Text); //update order in database

            File.WriteAllText(@"C:\Users\user\Desktop\Ecole\ABLODOSS\3eme\P2\projet informatique\projet\kitboxteam\" + Search.Text + "Invoice.txt", broker.Order(Search.Text)); //client's invoice

            // all invoices of all clients
            using (StreamWriter file = new StreamWriter(@"C:\Users\user\Desktop\Ecole\ABLODOSS\3eme\P2\projet informatique\projet\kitboxteam\Invoices.txt", true))
            {
                file.WriteLine(broker.Order(Search.Text));
            }
            delete.Enabled = false;
            Search.Text = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new InterfaceManager());
        }
    }
}

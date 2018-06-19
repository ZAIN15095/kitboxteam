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
    public partial class InterfaceStock : UserControl
    {
        Broker broker = new Broker();

        public InterfaceStock()
        {
            InitializeComponent();
        }

        private void InterfaceStock_Load(object sender, EventArgs e)
        {
            
        }

        private void seek_Click(object sender, EventArgs e)
        {
            if ((search.Text != "" && !search.Text.Contains(" ")) || ( (search.Text.Length == 9 || search.Text.Length == 5) ||
               ( search.Text.Length == 6 || search.Text.Length == 10) || search.Text.Length == 11))
            {
                Items.Text = broker.ItemStock(search.Text); //display information about items
            }

            else
            {
                MessageBox.Show("Enter correctly the item code", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            UserControl2.command.Clear();
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new Home());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new InterfaceManager());
        }
    }
}

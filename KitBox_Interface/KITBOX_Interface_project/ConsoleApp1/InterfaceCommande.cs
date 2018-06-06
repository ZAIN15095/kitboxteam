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
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new InterfacePayment());

        }

        private void InterfaceCommande_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, Rack> casier in UserControl2.command)
            {
                OrderText.Text += "\t\t" + casier.Key + "\r\n";
                OrderText.AppendText("\r\n");

                OrderText.Text += "Height :\t\t" + casier.Value.Lrpanel.Height + "\r\n";
                OrderText.Text += "Width :\t\t" + UserControl2.dimensions.Width + "\r\n";
                OrderText.Text += "Depth\t\t" + UserControl2.dimensions.Depth + "\r\n";
                OrderText.Text += "Panel's color :\t" + casier.Value.Lrpanel.Color + "\r\n";

                if (casier.Value.Door != null)
                {
                    OrderText.Text += "Door color :\t" + casier.Value.Door.Color + "\r\n";
                    
                }
                else
                {
                    OrderText.Text += ("You don't color for this rack" + "\r\n");
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

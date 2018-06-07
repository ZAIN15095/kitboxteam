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
    public partial class InterfaceRegisterClient : UserControl
    {
        double accompte = (InterfacePayment.total_price * 50)/100;
        Broker broker = new Broker();
        public static string elements;

        public InterfaceRegisterClient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void deposit_TextChanged(object sender, EventArgs e)
        {

        }

        private void InterfaceRegisterClient_Load(object sender, EventArgs e)
        {
            deposit.Text = Convert.ToString(accompte);
        }

        private void Accompte_Click(object sender, EventArgs e)
        {
            if(nom.Text != "" && nom.Text.Contains(" "))
            {
                if (email.Text != "" && email.Text.Contains("@") && email.Text.Contains("."))
                {
                    if (phone.Text != "" && phone.Text.Contains("0") && phone.Text.Length == 10)
                    {
                        foreach (KeyValuePair<string, Rack> casier in UserControl2.command)
                        {
                            elements += casier.Key + "\r\n\r\n" + casier.Value.Lrpanel.ToString() + "\r\n" + casier.Value.Backpanel.ToString() + "\r\n" + casier.Value.Udpanel.ToString() + "\r\n" +
                            casier.Value.Bcrossbar.ToString() + "\r\n" + casier.Value.Fcrossbar.ToString() + "\r\n" + casier.Value.Lrcrossbar.ToString() + "\r\n" + casier.Value.BAttens.ToString() +
                            casier.Value.BAttens.ToString() + "\r\n\r\n";
                        }

                        broker.Insert(nom.Text, phone.Text, email.Text, accompte, elements);

                        this.BackgroundImage = null;
                        this.Controls.Clear();
                        this.Controls.Add(new InterfaceConfirmDeposit());
                    }
                    else
                    {
                        MessageBox.Show("Please enter a phone number", "Erreur",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a email adress", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a name and a firstname", "Erreur",
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

        private void nom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

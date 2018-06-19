using System;
using KITBOX_project;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
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
        Random nr = new Random();
        double accompte = (InterfacePayment.total_price * 50)/100; //deposit price
        Broker broker = new Broker();
        public string elements; //customer's rack items

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
            deposit.Text = Convert.ToString(accompte); //display deposit price
        }

        private void Accompte_Click(object sender, EventArgs e)
        {
            string random = Convert.ToString(nr.Next(100000000, 999999999));

            if (nom.Text != "" && nom.Text.Contains(" "))
            {
                if (email.Text != "" && email.Text.Contains("@") && email.Text.Contains("."))
                {
                    if (phone.Text != "" && phone.Text.Contains("0") && phone.Text.Length == 10) 
                    {
                        elements += "---------------" + DateTime.Now + "---------------\r\n\r\n";
                        elements += "Order number : " + random + "\r\n\r\n";
                        foreach (KeyValuePair<string, Rack> casier in UserControl2.command)
                        {
                            elements += casier.Key + "\r\n\r\n" + casier.Value.Lrpanel.ToString() + "\r\n" + casier.Value.Backpanel.ToString() + "\r\n" + casier.Value.Udpanel.ToString() + "\r\n" +
                            casier.Value.Bcrossbar.ToString() + "\r\n" + casier.Value.Fcrossbar.ToString() + "\r\n" + casier.Value.Lrcrossbar.ToString() + "\r\n" + casier.Value.BAttens.ToString() +
                            casier.Value.BAttens.ToString() + "\r\n\r\n";
                        }
                        elements += InterfacePayment.anglebar.ToString();

                        elements += "\r\n\r\nPrice : " + accompte + " euros";

                        broker.Insert(random, nom.Text, phone.Text, email.Text, accompte, elements, "No");// insert order in database

                        File.WriteAllText(@"C:\Users\user\Desktop\Ecole\ABLODOSS\3eme\P2\projet informatique\projet\kitboxteam\" + random + ".txt", elements); // invoice

                        // all invoices of all clients
                        using (StreamWriter file = new StreamWriter(@"C:\Users\user\Desktop\Ecole\ABLODOSS\3eme\P2\projet informatique\projet\kitboxteam\Invoices.txt", true))
                        {
                            file.WriteLine(elements);
                        }

                        InterfacePayment.total_price = 0;
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
            InterfacePayment.total_price = 0;
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

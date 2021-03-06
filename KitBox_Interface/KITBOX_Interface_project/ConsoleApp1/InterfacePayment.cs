﻿using System;
using KITBOX_project;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ConsoleApp1
{
    public partial class InterfacePayment : UserControl
    {
        Random nr = new Random(); //number of order
        public string elements; //customer's rack items
        int i;
        public static AngleBar anglebar = new AngleBar(UserControl2.color_Angle, UserControl2.dimensions);
        List<string> list = new List<string>(); // availability of each elements
        int H_angleBar;
        public static double total_price; // price of order
        Broker broker = new Broker();

        public InterfacePayment()
        {
            InitializeComponent();
        }

        private void InterfacePayment_Load(object sender, EventArgs e)
        {
            total_price = 0;
            H_angleBar = 0;

            foreach (KeyValuePair<string, Rack> casier in UserControl2.command)
            {
                H_angleBar += casier.Value.Lrpanel.Height;

                //invoice
                i = Facture.Rows.Add();
                Facture.Rows[i].Cells[0].Value = casier.Key;
                Facture.Rows[i].Cells[1].Value = "";
                Facture.Rows[i].Cells[1].Value = "";
                Facture.Rows[i].Cells[1].Value = "";

                i = Facture.Rows.Add();
                Facture.Rows[i].Cells[0].Value = casier.Value.Lrpanel.Name;
                Facture.Rows[i].Cells[1].Value = broker.printPrice(casier.Value.Lrpanel, "PanneauGD");
                Facture.Rows[i].Cells[2].Value = Convert.ToString(Convert.ToDouble(broker.printPrice(casier.Value.Lrpanel, "PanneauGD")) * 2);
                Facture.Rows[i].Cells[3].Value = broker.Available(casier.Value.Lrpanel, "PanneauGD");
                total_price += Convert.ToDouble(broker.printPrice(casier.Value.Lrpanel, "PanneauGD")) * 2;
                list.Add(broker.Available(casier.Value.Lrpanel, "PanneauGD"));

                i = Facture.Rows.Add();
                Facture.Rows[i].Cells[0].Value = casier.Value.Backpanel.Name;
                Facture.Rows[i].Cells[1].Value = broker.printPrice(casier.Value.Backpanel, "PanneauAR");
                Facture.Rows[i].Cells[2].Value = broker.printPrice(casier.Value.Backpanel, "PanneauAR");
                Facture.Rows[i].Cells[3].Value = broker.Available(casier.Value.Backpanel, "PanneauAR");
                total_price += Convert.ToDouble(broker.printPrice(casier.Value.Backpanel, "PanneauAR"));
                list.Add(broker.Available(casier.Value.Lrpanel, "PanneauAR"));

                i = Facture.Rows.Add();
                Facture.Rows[i].Cells[0].Value = casier.Value.Udpanel.Name;
                Facture.Rows[i].Cells[1].Value = broker.printPrice(casier.Value.Udpanel, "PanneauHB");
                Facture.Rows[i].Cells[2].Value = Convert.ToString(Convert.ToDouble(broker.printPrice(casier.Value.Udpanel, "PanneauHB")) * 2);
                Facture.Rows[i].Cells[3].Value = broker.Available(casier.Value.Udpanel, "PanneauHB");
                total_price += Convert.ToDouble(broker.printPrice(casier.Value.Udpanel, "PanneauHB")) * 2;
                list.Add(broker.Available(casier.Value.Udpanel, "PanneauHB"));

                i = Facture.Rows.Add();
                Facture.Rows[i].Cells[0].Value = casier.Value.Bcrossbar.Name;
                Facture.Rows[i].Cells[1].Value = broker.printPrice(casier.Value.Bcrossbar, "TraverseAr");
                Facture.Rows[i].Cells[2].Value = broker.printPrice(casier.Value.Bcrossbar, "TraverseAr");
                Facture.Rows[i].Cells[3].Value = broker.Available(casier.Value.Bcrossbar, "TraverseAr");
                total_price += Convert.ToDouble(broker.printPrice(casier.Value.Bcrossbar, "TraverseAr"));
                list.Add(broker.Available(casier.Value.Bcrossbar, "TraverseAr"));

                i = Facture.Rows.Add();
                Facture.Rows[i].Cells[0].Value = casier.Value.Fcrossbar.Name;
                Facture.Rows[i].Cells[1].Value = broker.printPrice(casier.Value.Fcrossbar, "TraverseAv");
                Facture.Rows[i].Cells[2].Value = broker.printPrice(casier.Value.Fcrossbar, "TraverseAv");
                Facture.Rows[i].Cells[3].Value = broker.Available(casier.Value.Fcrossbar, "TraverseAv");
                total_price += Convert.ToDouble(broker.printPrice(casier.Value.Fcrossbar, "TraverseAv"));
                list.Add(broker.Available(casier.Value.Fcrossbar, "TraverseAv"));

                i = Facture.Rows.Add();
                Facture.Rows[i].Cells[0].Value = casier.Value.Lrcrossbar.Name;
                Facture.Rows[i].Cells[1].Value = broker.printPrice(casier.Value.Lrcrossbar, "TraverseGD");
                Facture.Rows[i].Cells[2].Value = Convert.ToString(Convert.ToDouble(broker.printPrice(casier.Value.Lrcrossbar, "TraverseGD")) * 2);
                Facture.Rows[i].Cells[3].Value = broker.Available(casier.Value.Lrcrossbar, "TraverseGD");
                total_price += Convert.ToDouble(broker.printPrice(casier.Value.Lrcrossbar, "TraverseGD")) * 2;
                list.Add(broker.Available(casier.Value.Lrcrossbar, "TraverseGD"));

                i = Facture.Rows.Add();
                Facture.Rows[i].Cells[0].Value = casier.Value.BAttens.Name;
                Facture.Rows[i].Cells[1].Value = broker.printPrice(casier.Value.BAttens, "Tasseau");
                Facture.Rows[i].Cells[2].Value = Convert.ToString(Convert.ToDouble(broker.printPrice(casier.Value.Lrcrossbar, "TraverseGD")) * 4);
                Facture.Rows[i].Cells[3].Value = broker.Available(casier.Value.BAttens, "Tasseau");
                total_price += Convert.ToDouble(broker.printPrice(casier.Value.Lrcrossbar, "Tasseau")) * 4;
                list.Add(broker.Available(casier.Value.BAttens, "Tasseau"));

                if (casier.Value.Door != null)
                {
                    i = Facture.Rows.Add();
                    Facture.Rows[i].Cells[0].Value = casier.Value.Door.Name;
                    Facture.Rows[i].Cells[1].Value = broker.printPrice(casier.Value.Door, "Porte");
                    Facture.Rows[i].Cells[2].Value = Convert.ToString(Convert.ToDouble(broker.printPrice(casier.Value.Door, "Porte")) * 2);
                    Facture.Rows[i].Cells[3].Value = broker.Available(casier.Value.Door, "Porte");
                    total_price += Convert.ToDouble(broker.printPrice(casier.Value.Door, "Porte")) * 2;
                    list.Add(broker.Available(casier.Value.Door, "Porte"));
                }
            }

            //insert anglebar in invoice
            AngleBar.H_angle = H_angleBar;
            i = Facture.Rows.Add();
            Facture.Rows[i].Cells[0].Value = anglebar.Name;
            Facture.Rows[i].Cells[1].Value = broker.printPrice(anglebar, "Corniere");
            Facture.Rows[i].Cells[2].Value = Convert.ToString(Convert.ToDouble(broker.printPrice(anglebar, "Corniere")) * 4);
            Facture.Rows[i].Cells[3].Value = broker.Available(anglebar, "Corniere");
            total_price += Convert.ToDouble(broker.printPrice(anglebar, "Corniere")) * 4;
            list.Add(broker.Available(anglebar, "Corniere"));

            if (list.Contains("No"))//if no stock
            {
                label2.Visible = true;
                Pay.Text = "PAY DEPOSIT";
            }

            Price_total.Text = Convert.ToString(total_price);// total price
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pay_Click(object sender, EventArgs e)
        {
            string random = Convert.ToString(nr.Next(100000000, 999999999));

            if ( list.Contains("No")) //if no stock
            {
                this.BackgroundImage = null;
                this.Controls.Clear();
                this.Controls.Add(new InterfaceRegisterClient());
            }

            else // if all items are in stock
            {
                elements += "-----------------------" + DateTime.Now + "-----------------------\r\n\r\n";
                elements += "Order number : " + random + "\r\n\r\n";
                foreach (KeyValuePair<string, Rack> casier in UserControl2.command)
                {
                    elements += casier.Key + "\r\n\r\n" + casier.Value.Lrpanel.ToString() + "\r\n" + casier.Value.Backpanel.ToString() + "\r\n" + casier.Value.Udpanel.ToString() + "\r\n" +
                    casier.Value.Bcrossbar.ToString() + "\r\n" + casier.Value.Fcrossbar.ToString() + "\r\n" + casier.Value.Lrcrossbar.ToString() + "\r\n" + casier.Value.BAttens.ToString() +
                    casier.Value.BAttens.ToString() + "\r\n\r\n";
                }
                elements += anglebar.ToString();

                elements += "\r\n\r\nPrice : " + total_price + " euros";

                broker.Insert(random, null, null, null, total_price, elements, "Yes");// insert order in database
                
                File.WriteAllText(@"C:\Users\user\Desktop\Ecole\ABLODOSS\3eme\P2\projet informatique\projet\kitboxteam\" + random + ".txt", elements); //client's invoice

                // all invoices of all clients
                using (StreamWriter file = new StreamWriter(@"C:\Users\user\Desktop\Ecole\ABLODOSS\3eme\P2\projet informatique\projet\kitboxteam\Invoices.txt", true))
                {   
                    file.WriteLine(elements);
                }

                total_price = 0;
                broker.deleteItems(); //delete items in database
                UserControl2.command.Clear();
                this.BackgroundImage = null;
                this.Controls.Clear();
                this.Controls.Add(new InterfaceConfirm());
            }

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new InterfacePayment());
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            UserControl2.command.Clear();
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new Home());
        }

        private void Back_Click_1(object sender, EventArgs e)
        {

        }

        private void Cancel_Click_1(object sender, EventArgs e)
        {
            UserControl2.command.Clear();
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new Home());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            total_price = 0;
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new InterfaceCommande());
        }

        private void Price_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Click_2(object sender, EventArgs e)
        {
            total_price = 0;
            UserControl2.command.Clear();
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new Home());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

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
using System.Data.OleDb;

namespace ConsoleApp1
{
    public partial class InterfacePayment : UserControl
    {
        int i;
        bool available;
        List<string> list = new List<string>();
        // double price_anglebar = 0;
        public static double total_price = 0;
        Broker broker = new Broker();

        public InterfacePayment()
        {
            InitializeComponent();
        }

        private void InterfacePayment_Load(object sender, EventArgs e)
        {
            

            foreach (KeyValuePair<string, Rack> casier in UserControl2.command)
            {
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
                    list.Add(broker.Available(casier.Value.BAttens, "Porte"));
                }

                //check if items is available 
                /*if (new[] { broker.Available(casier.Value.Lrpanel, "PanneauGD"), broker.Available(casier.Value.Lrpanel, "PanneauAR"),
                    broker.Available(casier.Value.Udpanel, "PanneauHB"), broker.Available(casier.Value.Bcrossbar, "TraverseAr"),
                    broker.Available(casier.Value.Fcrossbar, "TraverseAv"), broker.Available(casier.Value.Lrcrossbar, "TraverseGD"),
                    broker.Available(casier.Value.BAttens, "Tasseau") }.Any(x => x == "NON"))
                {
                    available = false;
                }*/

                //price_anglebar += Convert.ToDouble(broker.printPrice(casier.Value.Anglebar, "Corniere")) * 4;
            }

            if (check(list) == false)//if no stock
            {
                label2.Visible = true;
            }

            /*i = Facture.Rows.Add();
            Facture.Rows[i].Cells[0].Value = "Cornière";
            i = Facture.Rows.Add();
            //Facture.Rows[i].Cells[1].Value = ;
            i = Facture.Rows.Add();
            Facture.Rows[i].Cells[0].Value = "Cornière";
            i = Facture.Rows.Add();
            Facture.Rows[i].Cells[0].Value = "Cornière";*/
            Price_total.Text = Convert.ToString(total_price);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pay_Click(object sender, EventArgs e)
        {
            if ( check(list) == false)//if no stock
            {
                this.BackgroundImage = null;
                this.Controls.Clear();
                this.Controls.Add(new InterfaceRegisterClient());
            }

            else
            {
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
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new InterfaceCommande());
        }

        private void Price_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Click_2(object sender, EventArgs e)
        {
            UserControl2.command.Clear();
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new Home());
        }

        //Check if all items is in stock
        public bool check(List<string> list)
        {
            foreach (string elem in list)
            {
                if (elem == "NON")
                {
                    available = false;
                    break;
                }
                else
                {
                    available = true;
                }
            }
            return available;
        }
    }
}
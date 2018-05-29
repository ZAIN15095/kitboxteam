using System;
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
            List<String> dataList = broker.viewData();

            foreach (string elemt in dataList)
            {
                OrderText.Text += elemt;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using Dapper;

namespace ConsoleApp1
{
    public partial class Form3 : MaterialSkin.Controls.MaterialForm
        
    {
        private IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.cnnVal("kitDB"));
        List<Item> items = new List<Item>();
        DATABASE db = new DATABASE();
        
       
        

        public Form3()
        {
            InitializeComponent();
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            items= db.GetItems(textBox1.Text);
            Find.Refresh();
            Find.DataSource  = items;
            Find.DisplayMember = "Info";
            find1.DataSource = items;
            find1.DisplayMember = "Enstock";
            find2.DataSource = items;
            find2.DisplayMember = "Prix_Client";
            find3.DataSource = items;
            find3.DisplayMember = "Stock_minimum";




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Find_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

           
        }




        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void find2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void find3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

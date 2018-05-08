using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        //Service for the storekeeper
        private void Service(object sender, EventArgs e)
        {
                Form2 f2 = new Form2();
                f2.Show();
                Form1 f1 = new Form1();
                f1.Close();


        }

        //begin the order
        private void StartApp(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UserControl2());
        }
    }
}

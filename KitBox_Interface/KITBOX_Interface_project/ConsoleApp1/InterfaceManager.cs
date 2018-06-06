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
    public partial class InterfaceManager : UserControl
    {
        public InterfaceManager()
        {
            InitializeComponent();
        }

        private void Stock_Click(object sender, EventArgs e)
        {

        }

        private void FoundOrder_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new InterfaceSearchOrder());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl2.command.Clear();
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new Home());
        }

        private void InterfaceManager_Load(object sender, EventArgs e)
        {

        }
    }
}

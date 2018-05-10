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
    public partial class InterfaceCasier6 : UserControl
    {
        public InterfaceCasier6()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new InterfaceCasier7());

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new InterfaceCasier5());

        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new Home());
        }

        private void InterfaceCasier6_Load(object sender, EventArgs e)
        {
            Do_checked();
        }

        private void DoorSelect_CheckedChanged(object sender, EventArgs e)
        {
            Do_checked();
        }

        //activation of DoorColorText
        private void Do_checked()
        {
            //activation of DoorColorText if DoorSelect is select
            DoorColorText.Enabled = DoorSelect.Checked;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ConsoleApp1
{
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }

        private void UserControl4_Load(object sender, EventArgs e)
        {

        }

        private void triangle1_Click(object sender, EventArgs e)
        {

        }
    }


    public partial class Triangle : Button
    {

        private GraphicsPath limite;

        private GraphicsPath limiteInterieure;

       


        protected override void OnPaint(PaintEventArgs pevent)

        {

            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;



            Rectangle rect = new Rectangle(0, 0, 150, 150);



            Brush extBrush = new SolidBrush(Color.Gray);



            limite = new GraphicsPath();

            

            g.FillPath(extBrush, limite);





           



            this.Region = new Region(limite);



            Brush clickBrush = new SolidBrush(Color.DarkGray);





            if (_clicked == false)

            {



                g.FillPath(extBrush, limite);

              

            }

            else

            {

                g.FillPath(clickBrush, limite);

              

            }



            extBrush.Dispose();

            clickBrush.Dispose();

           

        }

        protected override void OnMouseEnter(EventArgs e)

        {

            this.Cursor = Cursors.Hand;

            base.OnMouseEnter(e);

        }



        protected override void OnMouseLeave(EventArgs e)

        {

            this.Cursor = Cursors.Arrow;

            base.OnMouseLeave(e);

        }



        private bool _clicked = false;

        public bool Clicked

        {

            get { return _clicked; }

            set

            {

                _clicked = value;

                Invalidate();

            }

        }



        protected override void OnMouseDown(MouseEventArgs mevent)

        {

            _clicked = true;

            base.OnMouseDown(mevent);

        }



        protected override void OnMouseUp(MouseEventArgs mevent)

        {

            _clicked = false;

            base.OnMouseUp(mevent);

        }







    }
}

﻿using System;
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
    public partial class UserControl5 : UserControl
    {
        public UserControl5()
        {
            InitializeComponent();
        }

        private void UserControl5_Load(object sender, EventArgs e)
        {

        }
    }

        public partial class ButtonModified : Button
        {
            
            public Color BorderColor = Color.Black;
           
            public int BorderSize = 1;

            public ButtonModified()
            {
                FlatStyle = FlatStyle.Flat;
                BackColor = Color.Transparent;
                FlatAppearance.BorderColor = BorderColor;
                FlatAppearance.BorderSize = BorderSize;
                Font = new System.Drawing.Font("VAGRounded-Light",
                30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
                ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))),
                        ((int)(((byte)(33)))), ((int)(((byte)(107)))));

                this.MouseDown += new MouseEventHandler(ButtonLastest_MouseDown);
                this.MouseUp += new MouseEventHandler(ButtonLastest_MouseUp);
            }

            void ButtonLastest_MouseUp(object sender, MouseEventArgs e)
            {
                ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))),
                            ((int)(((byte)(33)))), ((int)(((byte)(107)))));
                BackColor = Color.Transparent;
            }

            void ButtonLastest_MouseDown(object sender, MouseEventArgs e)
            {
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))),
                            ((int)(((byte)(33)))), ((int)(((byte)(107)))));
                ForeColor = System.Drawing.Color.Transparent;

            }
            int top;
            int left;
            int right;
            int bottom;

            protected override void OnPaint(PaintEventArgs pevent)
            {
                
                base.OnPaint(pevent);
                
                int CornerRadius = 18;

                Pen DrawPen = new Pen(BorderColor);
                GraphicsPath gfxPath_mod = new GraphicsPath();

                top = 0;
                left = 0;
                right = Width;
                bottom = Height;

                gfxPath_mod.AddArc(left, top, CornerRadius, CornerRadius, 180, 90);
                gfxPath_mod.AddArc(right - CornerRadius, top, CornerRadius, CornerRadius, 270, 90);
                gfxPath_mod.AddArc(right - CornerRadius, bottom - CornerRadius,
                    CornerRadius, CornerRadius, 0, 90);
                gfxPath_mod.AddArc(left, bottom - CornerRadius, CornerRadius, CornerRadius, 90, 90);

                gfxPath_mod.CloseAllFigures();

                pevent.Graphics.DrawPath(DrawPen, gfxPath_mod);

                int inside = 1;

                Pen newPen = new Pen(BorderColor, BorderSize);
                GraphicsPath gfxPath = new GraphicsPath();
                gfxPath.AddArc(left + inside + 1, top + inside, CornerRadius, CornerRadius, 180, 100);

                gfxPath.AddArc(right - CornerRadius - inside - 2,
                    top + inside, CornerRadius, CornerRadius, 270, 90);
                gfxPath.AddArc(right - CornerRadius - inside - 2,
                    bottom - CornerRadius - inside - 1, CornerRadius, CornerRadius, 0, 90);

                gfxPath.AddArc(left + inside + 1,
                bottom - CornerRadius - inside, CornerRadius, CornerRadius, 95, 95);
                pevent.Graphics.DrawPath(newPen, gfxPath);

                this.Region = new System.Drawing.Region(gfxPath_mod);
            }
        }
    }


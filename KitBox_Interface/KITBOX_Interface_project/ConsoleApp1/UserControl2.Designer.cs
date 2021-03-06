﻿namespace ConsoleApp1
{
    partial class UserControl2
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.depth = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Color_Angle = new System.Windows.Forms.ComboBox();
            this.Irons_color = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(652, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Width";
            this.label1.Click += new System.EventHandler(this.label_Width);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ConsoleApp1.Properties.Resources.Chevron_Right_50px;
            this.button1.Location = new System.Drawing.Point(957, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 47);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(674, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cabinet base";
            this.label3.Click += new System.EventHandler(this.label_Dimensions);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(374, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 39);
            this.label6.TabIndex = 12;
            this.label6.Text = " Configuration";
            this.label6.Click += new System.EventHandler(this.Label_Next);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(652, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Depth";
            this.label2.Click += new System.EventHandler(this.label_Depth);
            // 
            // width
            // 
            this.width.Cursor = System.Windows.Forms.Cursors.Hand;
            this.width.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.width.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.width.FormattingEnabled = true;
            this.width.Items.AddRange(new object[] {
            "32",
            "42",
            "52",
            "62",
            "80",
            "100",
            "120"});
            this.width.Location = new System.Drawing.Point(765, 163);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(143, 31);
            this.width.TabIndex = 16;
            this.width.SelectedIndexChanged += new System.EventHandler(this.comboBox_Width);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::ConsoleApp1.Properties.Resources.Chevron_Left_50px;
            this.button4.Location = new System.Drawing.Point(554, 440);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 47);
            this.button4.TabIndex = 18;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Transparent;
            this.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Image = global::ConsoleApp1.Properties.Resources.Cancel_48px;
            this.Cancel.Location = new System.Drawing.Point(935, 9);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(48, 44);
            this.Cancel.TabIndex = 20;
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // depth
            // 
            this.depth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.depth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.depth.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depth.FormattingEnabled = true;
            this.depth.Items.AddRange(new object[] {
            "32",
            "42",
            "52",
            "62"});
            this.depth.Location = new System.Drawing.Point(765, 254);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(143, 31);
            this.depth.TabIndex = 23;
            this.depth.SelectedIndexChanged += new System.EventHandler(this.comboBox_Depth);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(599, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 39);
            this.label4.TabIndex = 24;
            this.label4.Text = "Back";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(871, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 39);
            this.label5.TabIndex = 25;
            this.label5.Text = "Next";
            // 
            // Color_Angle
            // 
            this.Color_Angle.BackColor = System.Drawing.SystemColors.Window;
            this.Color_Angle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Color_Angle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Color_Angle.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color_Angle.FormattingEnabled = true;
            this.Color_Angle.Items.AddRange(new object[] {
            "Blanc",
            "Brun",
            "Galvanisé",
            "Noir",
            "Verre"});
            this.Color_Angle.Location = new System.Drawing.Point(765, 339);
            this.Color_Angle.Name = "Color_Angle";
            this.Color_Angle.Size = new System.Drawing.Size(143, 31);
            this.Color_Angle.TabIndex = 26;
            // 
            // Irons_color
            // 
            this.Irons_color.AutoSize = true;
            this.Irons_color.BackColor = System.Drawing.Color.Transparent;
            this.Irons_color.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Irons_color.ForeColor = System.Drawing.Color.Maroon;
            this.Irons_color.Location = new System.Drawing.Point(566, 339);
            this.Irons_color.Name = "Irons_color";
            this.Irons_color.Size = new System.Drawing.Size(182, 23);
            this.Irons_color.TabIndex = 27;
            this.Irons_color.Text = "Angle irons Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(414, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 48);
            this.label7.TabIndex = 28;
            this.label7.Text = "N.B : All rack elements \r\n    are measured in cm";
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConsoleApp1.Properties.Resources.KEWLOX_HOMEPAGE_SLIDE_04_1024x5121;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Irons_color);
            this.Controls.Add(this.Color_Angle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.width);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(1024, 512);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox width;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ComboBox depth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Color_Angle;
        private System.Windows.Forms.Label Irons_color;
        private System.Windows.Forms.Label label7;
    }
}

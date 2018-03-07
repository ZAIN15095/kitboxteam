namespace ConsoleApp1
{
    partial class UserControl1
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
            ConsoleApp1.ButtonModified buttonModified2;
            this.label1 = new System.Windows.Forms.Label();
            this.buttonModified1 = new ConsoleApp1.ButtonModified();
            buttonModified2 = new ConsoleApp1.ButtonModified();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Design with passion...";
            // 
            // buttonModified2
            // 
            buttonModified2.BackColor = System.Drawing.Color.Transparent;
            buttonModified2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            buttonModified2.FlatAppearance.BorderSize = 5;
            buttonModified2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonModified2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            buttonModified2.ForeColor = System.Drawing.Color.Black;
            buttonModified2.Location = new System.Drawing.Point(784, 18);
            buttonModified2.Name = "buttonModified2";
            buttonModified2.Size = new System.Drawing.Size(160, 54);
            buttonModified2.TabIndex = 12;
            buttonModified2.Text = "Service";
            buttonModified2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            buttonModified2.UseVisualStyleBackColor = false;
            buttonModified2.Click += new System.EventHandler(this.buttonModified2_Click);
            // 
            // buttonModified1
            // 
            this.buttonModified1.BackColor = System.Drawing.Color.Transparent;
            this.buttonModified1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonModified1.FlatAppearance.BorderSize = 5;
            this.buttonModified1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModified1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonModified1.ForeColor = System.Drawing.Color.Black;
            this.buttonModified1.Location = new System.Drawing.Point(275, 256);
            this.buttonModified1.Name = "buttonModified1";
            this.buttonModified1.Size = new System.Drawing.Size(152, 54);
            this.buttonModified1.TabIndex = 11;
            this.buttonModified1.Text = "Start";
            this.buttonModified1.UseVisualStyleBackColor = false;
            this.buttonModified1.Click += new System.EventHandler(this.buttonModified1_Click_1);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ConsoleApp1.Properties.Resources.KEWLOX_HOMEPAGE_SLIDE_16_1024x512;
            this.Controls.Add(buttonModified2);
            this.Controls.Add(this.buttonModified1);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(996, 512);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private ButtonModified buttonModified1;
    }
}

namespace ConsoleApp1
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.triangle1 = new ConsoleApp1.Triangle();
            this.triangle2 = new ConsoleApp1.Triangle();
            this.SuspendLayout();
            // 
            // triangle1
            // 
            this.triangle1.Clicked = false;
            this.triangle1.Location = new System.Drawing.Point(435, 121);
            this.triangle1.Name = "triangle1";
            this.triangle1.Size = new System.Drawing.Size(172, 157);
            this.triangle1.TabIndex = 0;
            this.triangle1.Text = "triangle1";
            this.triangle1.UseVisualStyleBackColor = true;
            // 
            // triangle2
            // 
            this.triangle2.Clicked = false;
            this.triangle2.Location = new System.Drawing.Point(346, 245);
            this.triangle2.Name = "triangle2";
            this.triangle2.Size = new System.Drawing.Size(189, 120);
            this.triangle2.TabIndex = 1;
            this.triangle2.Text = "triangle2";
            this.triangle2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 509);
            this.Controls.Add(this.triangle2);
            this.Controls.Add(this.triangle1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Triangle triangle1;
        private Triangle triangle2;
    }
}
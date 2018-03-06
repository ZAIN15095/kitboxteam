namespace ConsoleApp1
{
    partial class UserControl4
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
            this.triangle1 = new ConsoleApp1.Triangle();
            this.SuspendLayout();
            // 
            // triangle1
            // 
            this.triangle1.Clicked = false;
            this.triangle1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.triangle1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.triangle1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.triangle1.Location = new System.Drawing.Point(116, 82);
            this.triangle1.Name = "triangle1";
            this.triangle1.Size = new System.Drawing.Size(221, 192);
            this.triangle1.TabIndex = 0;
            this.triangle1.Text = "hello";
            this.triangle1.UseVisualStyleBackColor = true;
            this.triangle1.Click += new System.EventHandler(this.triangle1_Click);
            // 
            // UserControl4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.triangle1);
            this.Name = "UserControl4";
            this.Size = new System.Drawing.Size(484, 386);
            this.Load += new System.EventHandler(this.UserControl4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Triangle triangle1;
    }
}

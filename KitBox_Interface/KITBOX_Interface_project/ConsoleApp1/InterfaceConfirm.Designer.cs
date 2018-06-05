namespace ConsoleApp1
{
    partial class InterfaceConfirm
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Confirm_label = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Confirm_label
            // 
            this.Confirm_label.AutoSize = true;
            this.Confirm_label.BackColor = System.Drawing.Color.Transparent;
            this.Confirm_label.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_label.Location = new System.Drawing.Point(108, 183);
            this.Confirm_label.Name = "Confirm_label";
            this.Confirm_label.Size = new System.Drawing.Size(652, 102);
            this.Confirm_label.TabIndex = 0;
            this.Confirm_label.Text = "Thank you for your purchase\r\nand see you soon for a future visit";
            this.Confirm_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Home
            // 
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Location = new System.Drawing.Point(372, 387);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(176, 62);
            this.Home.TabIndex = 1;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // InterfaceConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConsoleApp1.Properties.Resources.KEWLOX_HOMEPAGE;
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Confirm_label);
            this.Name = "InterfaceConfirm";
            this.Size = new System.Drawing.Size(951, 501);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Confirm_label;
        private System.Windows.Forms.Button Home;
    }
}

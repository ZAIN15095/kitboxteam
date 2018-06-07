namespace ConsoleApp1
{
    partial class InterfaceManager
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
            this.FoundOrder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FoundOrder
            // 
            this.FoundOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoundOrder.Location = new System.Drawing.Point(357, 232);
            this.FoundOrder.Name = "FoundOrder";
            this.FoundOrder.Size = new System.Drawing.Size(227, 131);
            this.FoundOrder.TabIndex = 0;
            this.FoundOrder.Text = "FOUND AN ORDER";
            this.FoundOrder.UseVisualStyleBackColor = true;
            this.FoundOrder.Click += new System.EventHandler(this.FoundOrder_Click);
            // 
            // button1
            // 
            this.button1.Image = global::ConsoleApp1.Properties.Resources.Cancel_48px;
            this.button1.Location = new System.Drawing.Point(819, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 62);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InterfaceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConsoleApp1.Properties.Resources.KEWLOX_HOMEPAGE;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FoundOrder);
            this.Name = "InterfaceManager";
            this.Size = new System.Drawing.Size(1024, 512);
            this.Load += new System.EventHandler(this.InterfaceManager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FoundOrder;
        private System.Windows.Forms.Button button1;
    }
}

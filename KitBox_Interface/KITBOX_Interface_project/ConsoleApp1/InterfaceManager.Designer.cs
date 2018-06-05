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
            this.Stock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FoundOrder
            // 
            this.FoundOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoundOrder.Location = new System.Drawing.Point(166, 240);
            this.FoundOrder.Name = "FoundOrder";
            this.FoundOrder.Size = new System.Drawing.Size(227, 131);
            this.FoundOrder.TabIndex = 0;
            this.FoundOrder.Text = "FOUND AN ORDER";
            this.FoundOrder.UseVisualStyleBackColor = true;
            // 
            // Stock
            // 
            this.Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock.Location = new System.Drawing.Point(619, 240);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(215, 131);
            this.Stock.TabIndex = 1;
            this.Stock.Text = "STOCK";
            this.Stock.UseVisualStyleBackColor = true;
            // 
            // InterfaceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConsoleApp1.Properties.Resources.KEWLOX_HOMEPAGE;
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.FoundOrder);
            this.Name = "InterfaceManager";
            this.Size = new System.Drawing.Size(946, 501);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FoundOrder;
        private System.Windows.Forms.Button Stock;
    }
}

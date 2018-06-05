namespace ConsoleApp1
{
    partial class InterfaceSearchOrder
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
            this.commande = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // commande
            // 
            this.commande.Location = new System.Drawing.Point(31, 85);
            this.commande.Multiline = true;
            this.commande.Name = "commande";
            this.commande.ReadOnly = true;
            this.commande.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commande.Size = new System.Drawing.Size(441, 405);
            this.commande.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(532, 88);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(177, 29);
            this.Search.TabIndex = 1;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.BackColor = System.Drawing.Color.Transparent;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.Location = new System.Drawing.Point(725, 91);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(70, 24);
            this.SearchLabel.TabIndex = 2;
            this.SearchLabel.Text = "Search";
            // 
            // InterfaceSearchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConsoleApp1.Properties.Resources.KEWLOX_HOMEPAGE;
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.commande);
            this.Name = "InterfaceSearchOrder";
            this.Size = new System.Drawing.Size(949, 503);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox commande;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label SearchLabel;
    }
}

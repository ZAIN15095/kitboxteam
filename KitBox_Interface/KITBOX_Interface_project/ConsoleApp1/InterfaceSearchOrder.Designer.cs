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
            this.Seek = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.Finalized = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // commande
            // 
            this.commande.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commande.Location = new System.Drawing.Point(31, 85);
            this.commande.Multiline = true;
            this.commande.Name = "commande";
            this.commande.ReadOnly = true;
            this.commande.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commande.Size = new System.Drawing.Size(520, 405);
            this.commande.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(634, 85);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(177, 29);
            this.Search.TabIndex = 1;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.BackColor = System.Drawing.Color.Transparent;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.Location = new System.Drawing.Point(581, 47);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(70, 24);
            this.SearchLabel.TabIndex = 2;
            this.SearchLabel.Text = "Search";
            // 
            // Seek
            // 
            this.Seek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seek.Location = new System.Drawing.Point(670, 129);
            this.Seek.Name = "Seek";
            this.Seek.Size = new System.Drawing.Size(114, 44);
            this.Seek.TabIndex = 3;
            this.Seek.Text = "Search";
            this.Seek.UseVisualStyleBackColor = true;
            this.Seek.Click += new System.EventHandler(this.Seek_Click);
            // 
            // button1
            // 
            this.button1.Image = global::ConsoleApp1.Properties.Resources.Cancel_48px;
            this.button1.Location = new System.Drawing.Point(826, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 60);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete
            // 
            this.delete.Enabled = false;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(875, 435);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(128, 55);
            this.delete.TabIndex = 5;
            this.delete.Text = "Finalized order";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Finalized
            // 
            this.Finalized.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Finalized.Location = new System.Drawing.Point(289, 47);
            this.Finalized.Name = "Finalized";
            this.Finalized.ReadOnly = true;
            this.Finalized.Size = new System.Drawing.Size(100, 29);
            this.Finalized.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Finalized ?";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::ConsoleApp1.Properties.Resources.Chevron_Left_50px;
            this.button4.Location = new System.Drawing.Point(617, 443);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 47);
            this.button4.TabIndex = 64;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // InterfaceSearchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConsoleApp1.Properties.Resources.KEWLOX_HOMEPAGE;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Finalized);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Seek);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.commande);
            this.Name = "InterfaceSearchOrder";
            this.Size = new System.Drawing.Size(1024, 512);
            this.Load += new System.EventHandler(this.InterfaceSearchOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox commande;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button Seek;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox Finalized;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
    }
}

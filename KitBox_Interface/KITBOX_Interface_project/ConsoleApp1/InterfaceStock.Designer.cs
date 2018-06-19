namespace ConsoleApp1
{
    partial class InterfaceStock
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
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.Items = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.seek = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(230, 131);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(167, 29);
            this.search.TabIndex = 1;
            // 
            // Items
            // 
            this.Items.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Items.Location = new System.Drawing.Point(62, 168);
            this.Items.Multiline = true;
            this.Items.Name = "Items";
            this.Items.ReadOnly = true;
            this.Items.Size = new System.Drawing.Size(459, 247);
            this.Items.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(744, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "place an order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // seek
            // 
            this.seek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seek.Location = new System.Drawing.Point(439, 133);
            this.seek.Name = "seek";
            this.seek.Size = new System.Drawing.Size(82, 29);
            this.seek.TabIndex = 4;
            this.seek.Text = "Search";
            this.seek.UseVisualStyleBackColor = true;
            this.seek.Click += new System.EventHandler(this.seek_Click);
            // 
            // Cancel
            // 
            this.Cancel.Image = global::ConsoleApp1.Properties.Resources.Cancel_48px;
            this.Cancel.Location = new System.Drawing.Point(798, 16);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 53);
            this.Cancel.TabIndex = 7;
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::ConsoleApp1.Properties.Resources.Chevron_Left_50px;
            this.button4.Location = new System.Drawing.Point(590, 440);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 47);
            this.button4.TabIndex = 63;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // InterfaceStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConsoleApp1.Properties.Resources.KEWLOX_HOMEPAGE;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.seek);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Items);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label1);
            this.Name = "InterfaceStock";
            this.Size = new System.Drawing.Size(1036, 512);
            this.Load += new System.EventHandler(this.InterfaceStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.TextBox Items;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button seek;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button button4;
    }
}

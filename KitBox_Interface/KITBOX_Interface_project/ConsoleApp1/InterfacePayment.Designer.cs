namespace ConsoleApp1
{
    partial class InterfacePayment
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
            this.Facture = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.Label();
            this.Pay = new System.Windows.Forms.Button();
            this.Price_total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Facture)).BeginInit();
            this.SuspendLayout();
            // 
            // Facture
            // 
            this.Facture.AllowUserToOrderColumns = true;
            this.Facture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Facture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Uprice,
            this.Tprice,
            this.Available});
            this.Facture.Location = new System.Drawing.Point(3, 57);
            this.Facture.Name = "Facture";
            this.Facture.Size = new System.Drawing.Size(606, 430);
            this.Facture.TabIndex = 0;
            this.Facture.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Item
            // 
            this.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item.HeaderText = "Items";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // Uprice
            // 
            this.Uprice.HeaderText = "Unit price (euros)";
            this.Uprice.Name = "Uprice";
            this.Uprice.ReadOnly = true;
            // 
            // Tprice
            // 
            this.Tprice.HeaderText = "Total price (euros)";
            this.Tprice.Name = "Tprice";
            this.Tprice.ReadOnly = true;
            // 
            // Available
            // 
            this.Available.HeaderText = "Availability";
            this.Available.Name = "Available";
            this.Available.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.BackColor = System.Drawing.Color.Transparent;
            this.Price.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(761, 186);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(164, 37);
            this.Price.TabIndex = 1;
            this.Price.Text = "Total Price";
            // 
            // Pay
            // 
            this.Pay.BackColor = System.Drawing.Color.Silver;
            this.Pay.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Pay.ImageKey = "(aucun)";
            this.Pay.Location = new System.Drawing.Point(790, 323);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(107, 55);
            this.Pay.TabIndex = 3;
            this.Pay.Text = "PAY";
            this.Pay.UseVisualStyleBackColor = false;
            this.Pay.Click += new System.EventHandler(this.Pay_Click);
            // 
            // Price_total
            // 
            this.Price_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_total.Location = new System.Drawing.Point(768, 252);
            this.Price_total.Name = "Price_total";
            this.Price_total.Size = new System.Drawing.Size(141, 47);
            this.Price_total.TabIndex = 4;
            this.Price_total.TextChanged += new System.EventHandler(this.Price_total_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(915, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Euros";
            // 
            // Items
            // 
            this.Items.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Items.HeaderText = "Items";
            this.Items.Name = "Items";
            this.Items.ReadOnly = true;
            // 
            // Unit_price
            // 
            this.Unit_price.HeaderText = "Unit price (euros)";
            this.Unit_price.Name = "Unit_price";
            this.Unit_price.ReadOnly = true;
            // 
            // Cancel
            // 
            this.Cancel.Image = global::ConsoleApp1.Properties.Resources.Cancel_48px;
            this.Cancel.Location = new System.Drawing.Point(891, 68);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 53);
            this.Cancel.TabIndex = 6;
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click_2);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Image = global::ConsoleApp1.Properties.Resources.Chevron_Left_50px;
            this.button2.Location = new System.Drawing.Point(666, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 62);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(615, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "                N.B : Some  items of  your racke are not in stock.\r\nYou can pay a" +
    " deposit and come back to take your order in one week";
            this.label2.Visible = false;
            // 
            // InterfacePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConsoleApp1.Properties.Resources.KEWLOX_HOMEPAGE;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Price_total);
            this.Controls.Add(this.Pay);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Facture);
            this.Name = "InterfacePayment";
            this.Size = new System.Drawing.Size(1024, 512);
            this.Load += new System.EventHandler(this.InterfacePayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Facture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Facture;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Button Pay;
        private System.Windows.Forms.TextBox Price_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Items;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_price;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Available;
        private System.Windows.Forms.Label label2;
    }
}

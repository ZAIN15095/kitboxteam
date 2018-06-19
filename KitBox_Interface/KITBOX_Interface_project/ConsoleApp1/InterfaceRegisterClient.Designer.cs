namespace ConsoleApp1
{
    partial class InterfaceRegisterClient
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
            this.Accompte = new System.Windows.Forms.Button();
            this.nom = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nom_erreur = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.Label();
            this.deposit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Accompte
            // 
            this.Accompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accompte.Location = new System.Drawing.Point(745, 434);
            this.Accompte.Name = "Accompte";
            this.Accompte.Size = new System.Drawing.Size(107, 47);
            this.Accompte.TabIndex = 0;
            this.Accompte.Text = "Pay deposit";
            this.Accompte.UseVisualStyleBackColor = true;
            this.Accompte.Click += new System.EventHandler(this.Accompte_Click);
            // 
            // nom
            // 
            this.nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(303, 131);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(246, 29);
            this.nom.TabIndex = 1;
            this.nom.TextChanged += new System.EventHandler(this.nom_TextChanged);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(303, 230);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(246, 29);
            this.email.TabIndex = 2;
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(303, 322);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(246, 29);
            this.phone.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Register your order";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name and Firstname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(197, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone number";
            // 
            // nom_erreur
            // 
            this.nom_erreur.AutoSize = true;
            this.nom_erreur.BackColor = System.Drawing.Color.Transparent;
            this.nom_erreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_erreur.ForeColor = System.Drawing.Color.Red;
            this.nom_erreur.Location = new System.Drawing.Point(356, 163);
            this.nom_erreur.Name = "nom_erreur";
            this.nom_erreur.Size = new System.Drawing.Size(193, 16);
            this.nom_erreur.TabIndex = 8;
            this.nom_erreur.Text = "Enter a good name et firstname";
            this.nom_erreur.Visible = false;
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.BackColor = System.Drawing.Color.Transparent;
            this.mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail.ForeColor = System.Drawing.Color.Red;
            this.mail.Location = new System.Drawing.Point(428, 262);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(121, 16);
            this.mail.TabIndex = 9;
            this.mail.Text = "Enter a good email";
            this.mail.Visible = false;
            // 
            // tel
            // 
            this.tel.AutoSize = true;
            this.tel.BackColor = System.Drawing.Color.Transparent;
            this.tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tel.ForeColor = System.Drawing.Color.Red;
            this.tel.Location = new System.Drawing.Point(375, 354);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(174, 16);
            this.tel.TabIndex = 10;
            this.tel.Text = "Enter a good phone number";
            this.tel.Visible = false;
            // 
            // deposit
            // 
            this.deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deposit.Location = new System.Drawing.Point(732, 366);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(127, 38);
            this.deposit.TabIndex = 11;
            this.deposit.TextChanged += new System.EventHandler(this.deposit_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(866, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "euros";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(739, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "Deposit";
            // 
            // button1
            // 
            this.button1.Image = global::ConsoleApp1.Properties.Resources.Cancel_48px;
            this.button1.Location = new System.Drawing.Point(780, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 70);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InterfaceRegisterClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConsoleApp1.Properties.Resources.KEWLOX_HOMEPAGE;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deposit);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.nom_erreur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.email);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.Accompte);
            this.Name = "InterfaceRegisterClient";
            this.Size = new System.Drawing.Size(1024, 512);
            this.Load += new System.EventHandler(this.InterfaceRegisterClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Accompte;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nom_erreur;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.Label tel;
        private System.Windows.Forms.TextBox deposit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

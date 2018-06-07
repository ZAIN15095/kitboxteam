namespace ConsoleApp1
{
    partial class InterfaceCasier3
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
            ManiXButton.Office2010Blue office2010Blue1 = new ManiXButton.Office2010Blue();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfaceCasier3));
            this.DoorSelect = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DoorColorText = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PanelColorText = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.HeigthText = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Submit = new ManiXButton.XButton();
            this.RackPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RackPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DoorSelect
            // 
            this.DoorSelect.AutoSize = true;
            this.DoorSelect.Location = new System.Drawing.Point(762, 305);
            this.DoorSelect.Name = "DoorSelect";
            this.DoorSelect.Size = new System.Drawing.Size(15, 14);
            this.DoorSelect.TabIndex = 70;
            this.DoorSelect.UseVisualStyleBackColor = true;
            this.DoorSelect.CheckedChanged += new System.EventHandler(this.DoorSelect_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(630, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 23);
            this.label7.TabIndex = 69;
            this.label7.Text = "Door color";
            // 
            // DoorColorText
            // 
            this.DoorColorText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoorColorText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DoorColorText.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoorColorText.FormattingEnabled = true;
            this.DoorColorText.Items.AddRange(new object[] {
            "Blanc",
            "Brun",
            "Verre"});
            this.DoorColorText.Location = new System.Drawing.Point(783, 290);
            this.DoorColorText.Name = "DoorColorText";
            this.DoorColorText.Size = new System.Drawing.Size(143, 31);
            this.DoorColorText.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(859, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 39);
            this.label5.TabIndex = 67;
            this.label5.Text = "Next";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(625, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 39);
            this.label4.TabIndex = 66;
            this.label4.Text = "Back";
            // 
            // PanelColorText
            // 
            this.PanelColorText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelColorText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PanelColorText.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelColorText.FormattingEnabled = true;
            this.PanelColorText.Items.AddRange(new object[] {
            "Blanc",
            "Brun"});
            this.PanelColorText.Location = new System.Drawing.Point(783, 215);
            this.PanelColorText.Name = "PanelColorText";
            this.PanelColorText.Size = new System.Drawing.Size(143, 31);
            this.PanelColorText.TabIndex = 65;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::ConsoleApp1.Properties.Resources.Cancel_48px;
            this.button3.Location = new System.Drawing.Point(921, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 44);
            this.button3.TabIndex = 64;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::ConsoleApp1.Properties.Resources.Chevron_Left_50px;
            this.button4.Location = new System.Drawing.Point(585, 449);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 47);
            this.button4.TabIndex = 62;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // HeigthText
            // 
            this.HeigthText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HeigthText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HeigthText.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeigthText.FormattingEnabled = true;
            this.HeigthText.Items.AddRange(new object[] {
            "32",
            "42",
            "52"});
            this.HeigthText.Location = new System.Drawing.Point(783, 146);
            this.HeigthText.Name = "HeigthText";
            this.HeigthText.Size = new System.Drawing.Size(143, 31);
            this.HeigthText.TabIndex = 61;
            this.HeigthText.SelectedIndexChanged += new System.EventHandler(this.HeigthText_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(651, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 60;
            this.label2.Text = "Panel color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(571, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 39);
            this.label6.TabIndex = 59;
            this.label6.Text = " Configuration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(781, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 39);
            this.label3.TabIndex = 58;
            this.label3.Text = "Rack 3";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ConsoleApp1.Properties.Resources.Chevron_Right_50px;
            this.button1.Location = new System.Drawing.Point(944, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 47);
            this.button1.TabIndex = 57;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(674, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 56;
            this.label1.Text = "Height";
            // 
            // Submit
            // 
            office2010Blue1.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            office2010Blue1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            office2010Blue1.ButtonMouseOverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Blue1.ButtonMouseOverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Blue1.ButtonMouseOverColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(137)))));
            office2010Blue1.ButtonMouseOverColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(224)))));
            office2010Blue1.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            office2010Blue1.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            office2010Blue1.ButtonNormalColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(97)))), ((int)(((byte)(181)))));
            office2010Blue1.ButtonNormalColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(125)))), ((int)(((byte)(219)))));
            office2010Blue1.ButtonSelectedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Blue1.ButtonSelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Blue1.ButtonSelectedColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(117)))));
            office2010Blue1.ButtonSelectedColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(107)))));
            office2010Blue1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Blue1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Blue1.TextColor = System.Drawing.Color.White;
            this.Submit.ColorTable = office2010Blue1;
            this.Submit.Location = new System.Drawing.Point(725, 453);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(128, 38);
            this.Submit.TabIndex = 73;
            this.Submit.Text = "Finalize the order";
            this.Submit.Theme = ManiXButton.Theme.MSOffice2010_BLUE;
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // RackPictureBox
            // 
            this.RackPictureBox.Image = global::ConsoleApp1.Properties.Resources._3;
            this.RackPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("RackPictureBox.InitialImage")));
            this.RackPictureBox.Location = new System.Drawing.Point(151, 49);
            this.RackPictureBox.Name = "RackPictureBox";
            this.RackPictureBox.Size = new System.Drawing.Size(417, 442);
            this.RackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RackPictureBox.TabIndex = 76;
            this.RackPictureBox.TabStop = false;
            // 
            // InterfaceCasier3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConsoleApp1.Properties.Resources.KEWLOX_HOMEPAGE;
            this.Controls.Add(this.RackPictureBox);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.DoorSelect);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DoorColorText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PanelColorText);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.HeigthText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "InterfaceCasier3";
            this.Size = new System.Drawing.Size(1024, 505);
            this.Load += new System.EventHandler(this.InterfaceCasier3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RackPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox DoorSelect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox DoorColorText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PanelColorText;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox HeigthText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private ManiXButton.XButton Submit;
        private System.Windows.Forms.PictureBox RackPictureBox;
    }
}

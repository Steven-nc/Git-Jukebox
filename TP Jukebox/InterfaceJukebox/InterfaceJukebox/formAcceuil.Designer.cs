namespace InterfaceJukebox
{
    partial class Acceuil
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnmenucd = new System.Windows.Forms.Button();
            this.btnmenudvd = new System.Windows.Forms.Button();
            this.btnquitter = new System.Windows.Forms.Button();
            this.btnAdh = new System.Windows.Forms.Button();
            this.btnEmprunt = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.picture2 = new System.Windows.Forms.PictureBox();
            this.picture3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENUE SUR BORABORA JUKEBOX";
            // 
            // btnmenucd
            // 
            this.btnmenucd.Location = new System.Drawing.Point(12, 258);
            this.btnmenucd.Name = "btnmenucd";
            this.btnmenucd.Size = new System.Drawing.Size(162, 44);
            this.btnmenucd.TabIndex = 2;
            this.btnmenucd.Text = "CD";
            this.btnmenucd.UseVisualStyleBackColor = true;
            this.btnmenucd.Click += new System.EventHandler(this.btnmenucd_Click);
            // 
            // btnmenudvd
            // 
            this.btnmenudvd.Location = new System.Drawing.Point(221, 258);
            this.btnmenudvd.Name = "btnmenudvd";
            this.btnmenudvd.Size = new System.Drawing.Size(162, 44);
            this.btnmenudvd.TabIndex = 3;
            this.btnmenudvd.Text = "DVD";
            this.btnmenudvd.UseVisualStyleBackColor = true;
            this.btnmenudvd.Click += new System.EventHandler(this.btnmenudvd_Click);
            // 
            // btnquitter
            // 
            this.btnquitter.Location = new System.Drawing.Point(325, 328);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(162, 44);
            this.btnquitter.TabIndex = 4;
            this.btnquitter.Text = "Quitter";
            this.btnquitter.UseVisualStyleBackColor = true;
            this.btnquitter.Click += new System.EventHandler(this.btnquitter_Click);
            // 
            // btnAdh
            // 
            this.btnAdh.Location = new System.Drawing.Point(427, 258);
            this.btnAdh.Name = "btnAdh";
            this.btnAdh.Size = new System.Drawing.Size(162, 44);
            this.btnAdh.TabIndex = 5;
            this.btnAdh.Text = "ADHERENT";
            this.btnAdh.UseVisualStyleBackColor = true;
            this.btnAdh.Click += new System.EventHandler(this.btnAdh_Click);
            // 
            // btnEmprunt
            // 
            this.btnEmprunt.Location = new System.Drawing.Point(626, 258);
            this.btnEmprunt.Name = "btnEmprunt";
            this.btnEmprunt.Size = new System.Drawing.Size(162, 44);
            this.btnEmprunt.TabIndex = 6;
            this.btnEmprunt.Text = "EMPRUNT";
            this.btnEmprunt.UseVisualStyleBackColor = true;
            this.btnEmprunt.Click += new System.EventHandler(this.btnEmprunt_Click);
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(27, 97);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(132, 146);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 7;
            this.picture.TabStop = false;
            // 
            // picture1
            // 
            this.picture1.Location = new System.Drawing.Point(221, 114);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(162, 129);
            this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture1.TabIndex = 8;
            this.picture1.TabStop = false;
            // 
            // picture2
            // 
            this.picture2.Location = new System.Drawing.Point(427, 97);
            this.picture2.Name = "picture2";
            this.picture2.Size = new System.Drawing.Size(155, 155);
            this.picture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture2.TabIndex = 9;
            this.picture2.TabStop = false;
            // 
            // picture3
            // 
            this.picture3.Location = new System.Drawing.Point(639, 97);
            this.picture3.Name = "picture3";
            this.picture3.Size = new System.Drawing.Size(135, 135);
            this.picture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture3.TabIndex = 10;
            this.picture3.TabStop = false;
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 384);
            this.Controls.Add(this.picture3);
            this.Controls.Add(this.picture2);
            this.Controls.Add(this.picture1);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.btnEmprunt);
            this.Controls.Add(this.btnAdh);
            this.Controls.Add(this.btnquitter);
            this.Controls.Add(this.btnmenudvd);
            this.Controls.Add(this.btnmenucd);
            this.Controls.Add(this.label1);
            this.Name = "Acceuil";
            this.Text = "Acceuil JukeBox";
            this.Load += new System.EventHandler(this.Acceuil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnmenucd;
        private System.Windows.Forms.Button btnmenudvd;
        private System.Windows.Forms.Button btnquitter;
        private System.Windows.Forms.Button btnAdh;
        private System.Windows.Forms.Button btnEmprunt;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.PictureBox picture2;
        private System.Windows.Forms.PictureBox picture3;
    }
}


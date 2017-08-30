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
            this.label2 = new System.Windows.Forms.Label();
            this.btnmenucd = new System.Windows.Forms.Button();
            this.btnmenudvd = new System.Windows.Forms.Button();
            this.btnquitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENUE SUR M2L-JUKEBOX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choisissez le support de votre choix";
            // 
            // btnmenucd
            // 
            this.btnmenucd.Location = new System.Drawing.Point(107, 147);
            this.btnmenucd.Name = "btnmenucd";
            this.btnmenucd.Size = new System.Drawing.Size(163, 44);
            this.btnmenucd.TabIndex = 2;
            this.btnmenucd.Text = "CD";
            this.btnmenucd.UseVisualStyleBackColor = true;
            this.btnmenucd.Click += new System.EventHandler(this.btnmenucd_Click);
            // 
            // btnmenudvd
            // 
            this.btnmenudvd.Location = new System.Drawing.Point(107, 216);
            this.btnmenudvd.Name = "btnmenudvd";
            this.btnmenudvd.Size = new System.Drawing.Size(162, 44);
            this.btnmenudvd.TabIndex = 3;
            this.btnmenudvd.Text = "DVD";
            this.btnmenudvd.UseVisualStyleBackColor = true;
            this.btnmenudvd.Click += new System.EventHandler(this.btnmenudvd_Click);
            // 
            // btnquitter
            // 
            this.btnquitter.Location = new System.Drawing.Point(153, 307);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(80, 23);
            this.btnquitter.TabIndex = 4;
            this.btnquitter.Text = "Quitter";
            this.btnquitter.UseVisualStyleBackColor = true;
            this.btnquitter.Click += new System.EventHandler(this.btnquitter_Click);
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.btnquitter);
            this.Controls.Add(this.btnmenudvd);
            this.Controls.Add(this.btnmenucd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Acceuil";
            this.Text = "M2L-JukeBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnmenucd;
        private System.Windows.Forms.Button btnmenudvd;
        private System.Windows.Forms.Button btnquitter;
    }
}


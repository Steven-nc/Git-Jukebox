namespace InterfaceJukebox
{
    partial class formEmprunt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvEmprunt = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblnotif = new System.Windows.Forms.Label();
            this.btnSup = new System.Windows.Forms.Button();
            this.btnActu = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprunt)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmprunt
            // 
            this.dgvEmprunt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprunt.Location = new System.Drawing.Point(12, 12);
            this.dgvEmprunt.Name = "dgvEmprunt";
            this.dgvEmprunt.Size = new System.Drawing.Size(747, 237);
            this.dgvEmprunt.TabIndex = 0;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(12, 317);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(84, 33);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblnotif
            // 
            this.lblnotif.AutoSize = true;
            this.lblnotif.Location = new System.Drawing.Point(12, 276);
            this.lblnotif.Name = "lblnotif";
            this.lblnotif.Size = new System.Drawing.Size(0, 13);
            this.lblnotif.TabIndex = 2;
            // 
            // btnSup
            // 
            this.btnSup.Location = new System.Drawing.Point(117, 317);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(84, 33);
            this.btnSup.TabIndex = 3;
            this.btnSup.Text = "Supprimer";
            this.btnSup.UseVisualStyleBackColor = true;
            this.btnSup.Click += new System.EventHandler(this.btnSup_Click);
            // 
            // btnActu
            // 
            this.btnActu.Location = new System.Drawing.Point(315, 317);
            this.btnActu.Name = "btnActu";
            this.btnActu.Size = new System.Drawing.Size(84, 33);
            this.btnActu.TabIndex = 4;
            this.btnActu.Text = "Actualiser";
            this.btnActu.UseVisualStyleBackColor = true;
            this.btnActu.Click += new System.EventHandler(this.btnActu_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(675, 317);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(84, 33);
            this.btnRetour.TabIndex = 5;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // formEmprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 362);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnActu);
            this.Controls.Add(this.btnSup);
            this.Controls.Add(this.lblnotif);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgvEmprunt);
            this.Name = "formEmprunt";
            this.Text = "Liste des emprunts";
            this.Load += new System.EventHandler(this.formEmprunt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprunt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmprunt;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblnotif;
        private System.Windows.Forms.Button btnSup;
        private System.Windows.Forms.Button btnActu;
        private System.Windows.Forms.Button btnRetour;
    }
}
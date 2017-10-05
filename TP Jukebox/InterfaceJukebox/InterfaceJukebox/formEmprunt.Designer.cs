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
            this.lblnotif.Size = new System.Drawing.Size(37, 13);
            this.lblnotif.TabIndex = 2;
            this.lblnotif.Text = "lblnotif";
            // 
            // formEmprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 362);
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
    }
}
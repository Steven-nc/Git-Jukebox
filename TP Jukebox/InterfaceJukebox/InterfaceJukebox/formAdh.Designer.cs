namespace InterfaceJukebox
{
    partial class formAdh
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
            this.dgvAdh = new System.Windows.Forms.DataGridView();
            this.btnAddAdh = new System.Windows.Forms.Button();
            this.txtnotif = new System.Windows.Forms.Label();
            this.btnSuppAdh = new System.Windows.Forms.Button();
            this.btnActuAdh = new System.Windows.Forms.Button();
            this.btnModifAdh = new System.Windows.Forms.Button();
            this.btnretour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdh
            // 
            this.dgvAdh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdh.Location = new System.Drawing.Point(12, 12);
            this.dgvAdh.Name = "dgvAdh";
            this.dgvAdh.Size = new System.Drawing.Size(747, 237);
            this.dgvAdh.TabIndex = 0;
            // 
            // btnAddAdh
            // 
            this.btnAddAdh.Location = new System.Drawing.Point(12, 317);
            this.btnAddAdh.Name = "btnAddAdh";
            this.btnAddAdh.Size = new System.Drawing.Size(84, 33);
            this.btnAddAdh.TabIndex = 1;
            this.btnAddAdh.Text = "Ajouter";
            this.btnAddAdh.UseVisualStyleBackColor = true;
            this.btnAddAdh.Click += new System.EventHandler(this.btnAddAdh_Click);
            // 
            // txtnotif
            // 
            this.txtnotif.AutoSize = true;
            this.txtnotif.Location = new System.Drawing.Point(12, 280);
            this.txtnotif.Name = "txtnotif";
            this.txtnotif.Size = new System.Drawing.Size(0, 13);
            this.txtnotif.TabIndex = 2;
            // 
            // btnSuppAdh
            // 
            this.btnSuppAdh.Location = new System.Drawing.Point(117, 317);
            this.btnSuppAdh.Name = "btnSuppAdh";
            this.btnSuppAdh.Size = new System.Drawing.Size(84, 33);
            this.btnSuppAdh.TabIndex = 3;
            this.btnSuppAdh.Text = "Supprimer";
            this.btnSuppAdh.UseVisualStyleBackColor = true;
            this.btnSuppAdh.Click += new System.EventHandler(this.btnSuppAdh_Click);
            // 
            // btnActuAdh
            // 
            this.btnActuAdh.Location = new System.Drawing.Point(315, 317);
            this.btnActuAdh.Name = "btnActuAdh";
            this.btnActuAdh.Size = new System.Drawing.Size(84, 33);
            this.btnActuAdh.TabIndex = 4;
            this.btnActuAdh.Text = "Actualiser";
            this.btnActuAdh.UseVisualStyleBackColor = true;
            this.btnActuAdh.Click += new System.EventHandler(this.btnActuAdh_Click);
            // 
            // btnModifAdh
            // 
            this.btnModifAdh.Location = new System.Drawing.Point(412, 317);
            this.btnModifAdh.Name = "btnModifAdh";
            this.btnModifAdh.Size = new System.Drawing.Size(84, 33);
            this.btnModifAdh.TabIndex = 5;
            this.btnModifAdh.Text = "Modifier";
            this.btnModifAdh.UseVisualStyleBackColor = true;
            this.btnModifAdh.Click += new System.EventHandler(this.btnModifAdh_Click);
            // 
            // btnretour
            // 
            this.btnretour.Location = new System.Drawing.Point(675, 317);
            this.btnretour.Name = "btnretour";
            this.btnretour.Size = new System.Drawing.Size(84, 33);
            this.btnretour.TabIndex = 6;
            this.btnretour.Text = "Retour";
            this.btnretour.UseVisualStyleBackColor = true;
            this.btnretour.Click += new System.EventHandler(this.btnretour_Click);
            // 
            // formAdh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 362);
            this.Controls.Add(this.btnretour);
            this.Controls.Add(this.btnModifAdh);
            this.Controls.Add(this.btnActuAdh);
            this.Controls.Add(this.btnSuppAdh);
            this.Controls.Add(this.txtnotif);
            this.Controls.Add(this.btnAddAdh);
            this.Controls.Add(this.dgvAdh);
            this.Name = "formAdh";
            this.Text = "formAdh";
            this.Load += new System.EventHandler(this.formAdh_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdh;
        private System.Windows.Forms.Button btnAddAdh;
        private System.Windows.Forms.Label txtnotif;
        private System.Windows.Forms.Button btnSuppAdh;
        private System.Windows.Forms.Button btnActuAdh;
        private System.Windows.Forms.Button btnModifAdh;
        private System.Windows.Forms.Button btnretour;
    }
}
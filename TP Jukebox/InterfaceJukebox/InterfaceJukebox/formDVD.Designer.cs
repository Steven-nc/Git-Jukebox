namespace InterfaceJukebox
{
    partial class formDVD
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
            this.dgvDVD = new System.Windows.Forms.DataGridView();
            this.btnajouterdvd = new System.Windows.Forms.Button();
            this.btnsuppdvd = new System.Windows.Forms.Button();
            this.btnmodifdvd = new System.Windows.Forms.Button();
            this.btnactualiserdvd = new System.Windows.Forms.Button();
            this.btnretourdvd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDVD
            // 
            this.dgvDVD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDVD.Location = new System.Drawing.Point(12, 12);
            this.dgvDVD.Name = "dgvDVD";
            this.dgvDVD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDVD.Size = new System.Drawing.Size(747, 237);
            this.dgvDVD.TabIndex = 0;
            // 
            // btnajouterdvd
            // 
            this.btnajouterdvd.Location = new System.Drawing.Point(12, 317);
            this.btnajouterdvd.Name = "btnajouterdvd";
            this.btnajouterdvd.Size = new System.Drawing.Size(84, 33);
            this.btnajouterdvd.TabIndex = 1;
            this.btnajouterdvd.Text = "Ajouter";
            this.btnajouterdvd.UseVisualStyleBackColor = true;
            this.btnajouterdvd.Click += new System.EventHandler(this.btnajouterdvd_Click);
            // 
            // btnsuppdvd
            // 
            this.btnsuppdvd.Location = new System.Drawing.Point(117, 317);
            this.btnsuppdvd.Name = "btnsuppdvd";
            this.btnsuppdvd.Size = new System.Drawing.Size(84, 33);
            this.btnsuppdvd.TabIndex = 2;
            this.btnsuppdvd.Text = "Supprimer";
            this.btnsuppdvd.UseVisualStyleBackColor = true;
            this.btnsuppdvd.Click += new System.EventHandler(this.btnsuppdvd_Click);
            // 
            // btnmodifdvd
            // 
            this.btnmodifdvd.Location = new System.Drawing.Point(412, 317);
            this.btnmodifdvd.Name = "btnmodifdvd";
            this.btnmodifdvd.Size = new System.Drawing.Size(84, 33);
            this.btnmodifdvd.TabIndex = 3;
            this.btnmodifdvd.Text = "Modifier";
            this.btnmodifdvd.UseVisualStyleBackColor = true;
            this.btnmodifdvd.Click += new System.EventHandler(this.btnmodifdvd_Click);
            // 
            // btnactualiserdvd
            // 
            this.btnactualiserdvd.Location = new System.Drawing.Point(315, 317);
            this.btnactualiserdvd.Name = "btnactualiserdvd";
            this.btnactualiserdvd.Size = new System.Drawing.Size(84, 33);
            this.btnactualiserdvd.TabIndex = 4;
            this.btnactualiserdvd.Text = "Actualiser";
            this.btnactualiserdvd.UseVisualStyleBackColor = true;
            this.btnactualiserdvd.Click += new System.EventHandler(this.btnactualiserdvd_Click);
            // 
            // btnretourdvd
            // 
            this.btnretourdvd.Location = new System.Drawing.Point(677, 317);
            this.btnretourdvd.Name = "btnretourdvd";
            this.btnretourdvd.Size = new System.Drawing.Size(84, 33);
            this.btnretourdvd.TabIndex = 5;
            this.btnretourdvd.Text = "Retour";
            this.btnretourdvd.UseVisualStyleBackColor = true;
            this.btnretourdvd.Click += new System.EventHandler(this.btnretourdvd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // formDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnretourdvd);
            this.Controls.Add(this.btnactualiserdvd);
            this.Controls.Add(this.btnmodifdvd);
            this.Controls.Add(this.btnsuppdvd);
            this.Controls.Add(this.btnajouterdvd);
            this.Controls.Add(this.dgvDVD);
            this.Name = "formDVD";
            this.Text = "Menu DVD";
            this.Load += new System.EventHandler(this.formDVD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDVD;
        private System.Windows.Forms.Button btnajouterdvd;
        private System.Windows.Forms.Button btnsuppdvd;
        private System.Windows.Forms.Button btnmodifdvd;
        private System.Windows.Forms.Button btnactualiserdvd;
        private System.Windows.Forms.Button btnretourdvd;
        private System.Windows.Forms.Label label1;
    }
}
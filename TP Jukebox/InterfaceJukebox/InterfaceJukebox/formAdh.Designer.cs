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
            // 
            // formAdh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 362);
            this.Controls.Add(this.btnAddAdh);
            this.Controls.Add(this.dgvAdh);
            this.Name = "formAdh";
            this.Text = "formAdh";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdh;
        private System.Windows.Forms.Button btnAddAdh;
    }
}
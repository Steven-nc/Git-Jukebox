using System.Windows.Forms;
namespace InterfaceJukebox
{
    partial class FormCD
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
            this.dgvCD = new System.Windows.Forms.DataGridView();
            this.btnactualisercd = new System.Windows.Forms.Button();
            this.btnajoutercd = new System.Windows.Forms.Button();
            this.btnretourcd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsuppcd = new System.Windows.Forms.Button();
            this.btnmodifcd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCD
            // 
            this.dgvCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCD.Location = new System.Drawing.Point(12, 12);
            this.dgvCD.Name = "dgvCD";
            this.dgvCD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCD.Size = new System.Drawing.Size(747, 237);
            this.dgvCD.TabIndex = 0;
            this.dgvCD.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvCD_DataError);
            // 
            // btnactualisercd
            // 
            this.btnactualisercd.Location = new System.Drawing.Point(315, 317);
            this.btnactualisercd.Name = "btnactualisercd";
            this.btnactualisercd.Size = new System.Drawing.Size(84, 33);
            this.btnactualisercd.TabIndex = 1;
            this.btnactualisercd.Text = "Actualiser";
            this.btnactualisercd.UseVisualStyleBackColor = true;
            this.btnactualisercd.Click += new System.EventHandler(this.btnactualisercd_Click);
            // 
            // btnajoutercd
            // 
            this.btnajoutercd.Location = new System.Drawing.Point(12, 317);
            this.btnajoutercd.Name = "btnajoutercd";
            this.btnajoutercd.Size = new System.Drawing.Size(84, 33);
            this.btnajoutercd.TabIndex = 2;
            this.btnajoutercd.Text = "Ajouter";
            this.btnajoutercd.UseVisualStyleBackColor = true;
            this.btnajoutercd.Click += new System.EventHandler(this.btnajoutercd_Click);
            // 
            // btnretourcd
            // 
            this.btnretourcd.Location = new System.Drawing.Point(677, 317);
            this.btnretourcd.Name = "btnretourcd";
            this.btnretourcd.Size = new System.Drawing.Size(84, 33);
            this.btnretourcd.TabIndex = 3;
            this.btnretourcd.Text = "Retour";
            this.btnretourcd.UseVisualStyleBackColor = true;
            this.btnretourcd.Click += new System.EventHandler(this.btnretourcd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // btnsuppcd
            // 
            this.btnsuppcd.Location = new System.Drawing.Point(117, 317);
            this.btnsuppcd.Name = "btnsuppcd";
            this.btnsuppcd.Size = new System.Drawing.Size(84, 33);
            this.btnsuppcd.TabIndex = 5;
            this.btnsuppcd.Text = "Supprimer";
            this.btnsuppcd.UseVisualStyleBackColor = true;
            this.btnsuppcd.Click += new System.EventHandler(this.btnsuppcd_Click);
            // 
            // btnmodifcd
            // 
            this.btnmodifcd.Location = new System.Drawing.Point(412, 317);
            this.btnmodifcd.Name = "btnmodifcd";
            this.btnmodifcd.Size = new System.Drawing.Size(84, 33);
            this.btnmodifcd.TabIndex = 6;
            this.btnmodifcd.Text = "Modifier";
            this.btnmodifcd.UseVisualStyleBackColor = true;
            this.btnmodifcd.Click += new System.EventHandler(this.btnmodifcd_Click);
            // 
            // FormCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 362);
            this.Controls.Add(this.btnmodifcd);
            this.Controls.Add(this.btnsuppcd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnretourcd);
            this.Controls.Add(this.btnajoutercd);
            this.Controls.Add(this.btnactualisercd);
            this.Controls.Add(this.dgvCD);
            this.Name = "FormCD";
            this.Text = "Menu CD";
            this.Load += new System.EventHandler(this.FormCD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCD;
        private System.Windows.Forms.Button btnactualisercd;
        private System.Windows.Forms.Button btnajoutercd;
        private System.Windows.Forms.Button btnretourcd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsuppcd;
        private Button btnmodifcd;
    }
}
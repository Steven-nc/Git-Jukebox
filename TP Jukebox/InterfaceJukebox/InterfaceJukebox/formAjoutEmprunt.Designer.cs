namespace InterfaceJukebox
{
    partial class formAjoutEmprunt
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbAdh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSup = new System.Windows.Forms.ComboBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblnotif = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adhérent:";
            // 
            // cbAdh
            // 
            this.cbAdh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAdh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAdh.FormattingEnabled = true;
            this.cbAdh.Location = new System.Drawing.Point(119, 26);
            this.cbAdh.Name = "cbAdh";
            this.cbAdh.Size = new System.Drawing.Size(178, 21);
            this.cbAdh.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Support";
            // 
            // cbSup
            // 
            this.cbSup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSup.FormattingEnabled = true;
            this.cbSup.Location = new System.Drawing.Point(119, 70);
            this.cbSup.Name = "cbSup";
            this.cbSup.Size = new System.Drawing.Size(178, 21);
            this.cbSup.TabIndex = 3;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(270, 179);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(12, 179);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Retour";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // lblnotif
            // 
            this.lblnotif.AutoSize = true;
            this.lblnotif.Location = new System.Drawing.Point(29, 163);
            this.lblnotif.Name = "lblnotif";
            this.lblnotif.Size = new System.Drawing.Size(0, 13);
            this.lblnotif.TabIndex = 6;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(32, 118);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(30, 13);
            this.lbldate.TabIndex = 7;
            this.lbldate.Text = "Date";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(119, 118);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(178, 20);
            this.txtDate.TabIndex = 8;
            // 
            // formAjoutEmprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 214);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblnotif);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.cbSup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAdh);
            this.Controls.Add(this.label1);
            this.Name = "formAjoutEmprunt";
            this.Text = "Effectuer un emprunt";
            this.Load += new System.EventHandler(this.formAjoutEmprunt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAdh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSup;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblnotif;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.TextBox txtDate;
    }
}
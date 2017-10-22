namespace InterfaceJukebox
{
    partial class formDVDmodif
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textTitreDVD = new System.Windows.Forms.TextBox();
            this.textDureeDVD = new System.Windows.Forms.TextBox();
            this.textMetteur = new System.Windows.Forms.TextBox();
            this.textCommentaireDVD = new System.Windows.Forms.TextBox();
            this.checkStockDVD = new System.Windows.Forms.CheckBox();
            this.btnretour = new System.Windows.Forms.Button();
            this.btnvalider = new System.Windows.Forms.Button();
            this.textUtil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modification DVD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Durée (mins)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "En stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Metteur en scène ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Commentaire";
            // 
            // textTitreDVD
            // 
            this.textTitreDVD.Location = new System.Drawing.Point(142, 46);
            this.textTitreDVD.Name = "textTitreDVD";
            this.textTitreDVD.Size = new System.Drawing.Size(172, 20);
            this.textTitreDVD.TabIndex = 6;
            // 
            // textDureeDVD
            // 
            this.textDureeDVD.Location = new System.Drawing.Point(142, 69);
            this.textDureeDVD.Name = "textDureeDVD";
            this.textDureeDVD.Size = new System.Drawing.Size(46, 20);
            this.textDureeDVD.TabIndex = 7;
            // 
            // textMetteur
            // 
            this.textMetteur.Location = new System.Drawing.Point(142, 127);
            this.textMetteur.Name = "textMetteur";
            this.textMetteur.Size = new System.Drawing.Size(172, 20);
            this.textMetteur.TabIndex = 8;
            // 
            // textCommentaireDVD
            // 
            this.textCommentaireDVD.Location = new System.Drawing.Point(142, 154);
            this.textCommentaireDVD.Name = "textCommentaireDVD";
            this.textCommentaireDVD.Size = new System.Drawing.Size(172, 20);
            this.textCommentaireDVD.TabIndex = 9;
            // 
            // checkStockDVD
            // 
            this.checkStockDVD.AutoSize = true;
            this.checkStockDVD.Location = new System.Drawing.Point(142, 95);
            this.checkStockDVD.Name = "checkStockDVD";
            this.checkStockDVD.Size = new System.Drawing.Size(42, 17);
            this.checkStockDVD.TabIndex = 10;
            this.checkStockDVD.Text = "Oui";
            this.checkStockDVD.UseVisualStyleBackColor = true;
            // 
            // btnretour
            // 
            this.btnretour.Location = new System.Drawing.Point(16, 226);
            this.btnretour.Name = "btnretour";
            this.btnretour.Size = new System.Drawing.Size(75, 23);
            this.btnretour.TabIndex = 11;
            this.btnretour.Text = "Retour";
            this.btnretour.UseVisualStyleBackColor = true;
            this.btnretour.Click += new System.EventHandler(this.btnretour_Click);
            // 
            // btnvalider
            // 
            this.btnvalider.Location = new System.Drawing.Point(271, 226);
            this.btnvalider.Name = "btnvalider";
            this.btnvalider.Size = new System.Drawing.Size(75, 23);
            this.btnvalider.TabIndex = 12;
            this.btnvalider.Text = "Valider";
            this.btnvalider.UseVisualStyleBackColor = true;
            this.btnvalider.Click += new System.EventHandler(this.btnvalider_Click);
            // 
            // textUtil
            // 
            this.textUtil.AutoSize = true;
            this.textUtil.Location = new System.Drawing.Point(13, 193);
            this.textUtil.Name = "textUtil";
            this.textUtil.Size = new System.Drawing.Size(0, 13);
            this.textUtil.TabIndex = 13;
            // 
            // formDVDmodif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 261);
            this.Controls.Add(this.textUtil);
            this.Controls.Add(this.btnvalider);
            this.Controls.Add(this.btnretour);
            this.Controls.Add(this.checkStockDVD);
            this.Controls.Add(this.textCommentaireDVD);
            this.Controls.Add(this.textMetteur);
            this.Controls.Add(this.textDureeDVD);
            this.Controls.Add(this.textTitreDVD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formDVDmodif";
            this.Text = "Modification DVD";
            this.Load += new System.EventHandler(this.formDVDmodif_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textTitreDVD;
        private System.Windows.Forms.TextBox textDureeDVD;
        private System.Windows.Forms.TextBox textMetteur;
        private System.Windows.Forms.TextBox textCommentaireDVD;
        private System.Windows.Forms.CheckBox checkStockDVD;
        private System.Windows.Forms.Button btnretour;
        private System.Windows.Forms.Button btnvalider;
        private System.Windows.Forms.Label textUtil;
    }
}
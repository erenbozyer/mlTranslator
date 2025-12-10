namespace mlTranslator
{
    partial class Form1
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
            this.cmbKaynak = new System.Windows.Forms.ComboBox();
            this.cmbHedef = new System.Windows.Forms.ComboBox();
            this.txtGiris = new System.Windows.Forms.TextBox();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.btnCevir = new System.Windows.Forms.Button();
            this.lblKaynak = new System.Windows.Forms.Label();
            this.lblHedef = new System.Windows.Forms.Label();
            this.lblOk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbKaynak
            // 
            this.cmbKaynak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKaynak.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKaynak.FormattingEnabled = true;
            this.cmbKaynak.Location = new System.Drawing.Point(30, 40);
            this.cmbKaynak.Name = "cmbKaynak";
            this.cmbKaynak.Size = new System.Drawing.Size(200, 31);
            this.cmbKaynak.TabIndex = 0;
            // 
            // cmbHedef
            // 
            this.cmbHedef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHedef.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbHedef.FormattingEnabled = true;
            this.cmbHedef.Location = new System.Drawing.Point(350, 40);
            this.cmbHedef.Name = "cmbHedef";
            this.cmbHedef.Size = new System.Drawing.Size(200, 31);
            this.cmbHedef.TabIndex = 1;
            // 
            // txtGiris
            // 
            this.txtGiris.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGiris.Location = new System.Drawing.Point(30, 90);
            this.txtGiris.Multiline = true;
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGiris.Size = new System.Drawing.Size(240, 200);
            this.txtGiris.TabIndex = 2;
            // 
            // txtSonuc
            // 
            this.txtSonuc.BackColor = System.Drawing.Color.White;
            this.txtSonuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSonuc.Location = new System.Drawing.Point(310, 90);
            this.txtSonuc.Multiline = true;
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.ReadOnly = true;
            this.txtSonuc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSonuc.Size = new System.Drawing.Size(240, 200);
            this.txtSonuc.TabIndex = 3;
            // 
            // btnCevir
            // 
            this.btnCevir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCevir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCevir.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCevir.ForeColor = System.Drawing.Color.White;
            this.btnCevir.Location = new System.Drawing.Point(30, 310);
            this.btnCevir.Name = "btnCevir";
            this.btnCevir.Size = new System.Drawing.Size(520, 50);
            this.btnCevir.TabIndex = 4;
            this.btnCevir.Text = "ÇEVİR";
            this.btnCevir.UseVisualStyleBackColor = false;
            this.btnCevir.Click += new System.EventHandler(this.btnCevir_Click);
            // 
            // lblKaynak
            // 
            this.lblKaynak.AutoSize = true;
            this.lblKaynak.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKaynak.Location = new System.Drawing.Point(30, 15);
            this.lblKaynak.Name = "lblKaynak";
            this.lblKaynak.Size = new System.Drawing.Size(84, 20);
            this.lblKaynak.TabIndex = 5;
            this.lblKaynak.Text = "Kaynak Dil";
            // 
            // lblHedef
            // 
            this.lblHedef.AutoSize = true;
            this.lblHedef.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHedef.Location = new System.Drawing.Point(350, 15);
            this.lblHedef.Name = "lblHedef";
            this.lblHedef.Size = new System.Drawing.Size(77, 20);
            this.lblHedef.TabIndex = 6;
            this.lblHedef.Text = "Hedef Dil";
            // 
            // lblOk
            // 
            this.lblOk.AutoSize = true;
            this.lblOk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblOk.Location = new System.Drawing.Point(265, 40);
            this.lblOk.Name = "lblOk";
            this.lblOk.Size = new System.Drawing.Size(40, 28);
            this.lblOk.TabIndex = 7;
            this.lblOk.Text = "-->";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 390);
            this.Controls.Add(this.lblOk);
            this.Controls.Add(this.lblHedef);
            this.Controls.Add(this.lblKaynak);
            this.Controls.Add(this.btnCevir);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.txtGiris);
            this.Controls.Add(this.cmbHedef);
            this.Controls.Add(this.cmbKaynak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mlTranslator - Çoklu Dil Çeviri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKaynak;
        private System.Windows.Forms.ComboBox cmbHedef;
        private System.Windows.Forms.TextBox txtGiris;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Button btnCevir;
        private System.Windows.Forms.Label lblKaynak;
        private System.Windows.Forms.Label lblHedef;
        private System.Windows.Forms.Label lblOk;
    }
}
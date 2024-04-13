namespace Avtomobili
{
    partial class add_marka
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
            this.components = new System.ComponentModel.Container();
            this.marka_ime = new System.Windows.Forms.TextBox();
            this.marka_sifra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.otkazi = new System.Windows.Forms.Button();
            this.dodadi = new System.Windows.Forms.Button();
            this.blank = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.blank)).BeginInit();
            this.SuspendLayout();
            // 
            // marka_ime
            // 
            this.marka_ime.Location = new System.Drawing.Point(46, 59);
            this.marka_ime.Name = "marka_ime";
            this.marka_ime.Size = new System.Drawing.Size(226, 22);
            this.marka_ime.TabIndex = 0;
            // 
            // marka_sifra
            // 
            this.marka_sifra.Location = new System.Drawing.Point(46, 116);
            this.marka_sifra.Name = "marka_sifra";
            this.marka_sifra.Size = new System.Drawing.Size(226, 22);
            this.marka_sifra.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sifra:";
            // 
            // otkazi
            // 
            this.otkazi.Location = new System.Drawing.Point(121, 144);
            this.otkazi.Name = "otkazi";
            this.otkazi.Size = new System.Drawing.Size(75, 23);
            this.otkazi.TabIndex = 4;
            this.otkazi.Text = "Otkazi";
            this.otkazi.UseVisualStyleBackColor = true;
            this.otkazi.Click += new System.EventHandler(this.otkazi_Click);
            // 
            // dodadi
            // 
            this.dodadi.Location = new System.Drawing.Point(202, 144);
            this.dodadi.Name = "dodadi";
            this.dodadi.Size = new System.Drawing.Size(75, 23);
            this.dodadi.TabIndex = 5;
            this.dodadi.Text = "Dodadi";
            this.dodadi.UseVisualStyleBackColor = true;
            this.dodadi.Click += new System.EventHandler(this.dodadi_Click);
            // 
            // blank
            // 
            this.blank.ContainerControl = this;
            // 
            // add_marka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 209);
            this.Controls.Add(this.dodadi);
            this.Controls.Add(this.otkazi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.marka_sifra);
            this.Controls.Add(this.marka_ime);
            this.Name = "add_marka";
            this.Text = "add_marka";
            this.Load += new System.EventHandler(this.add_marka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.blank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox marka_ime;
        private System.Windows.Forms.TextBox marka_sifra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button otkazi;
        private System.Windows.Forms.Button dodadi;
        private System.Windows.Forms.ErrorProvider blank;
    }
}
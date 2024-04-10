namespace Airports
{
    partial class add_destination
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.num_dolzina = new System.Windows.Forms.NumericUpDown();
            this.num_cena = new System.Windows.Forms.NumericUpDown();
            this.bt_ok = new System.Windows.Forms.Button();
            this.bt_otkazi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.error_name = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_dolzina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_cena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_name)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bt_otkazi);
            this.groupBox1.Controls.Add(this.bt_ok);
            this.groupBox1.Controls.Add(this.num_cena);
            this.groupBox1.Controls.Add(this.num_dolzina);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Location = new System.Drawing.Point(24, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodadi destinacija";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(6, 61);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(226, 22);
            this.tb_name.TabIndex = 1;
            // 
            // num_dolzina
            // 
            this.num_dolzina.Location = new System.Drawing.Point(6, 108);
            this.num_dolzina.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_dolzina.Name = "num_dolzina";
            this.num_dolzina.Size = new System.Drawing.Size(120, 22);
            this.num_dolzina.TabIndex = 1;
            // 
            // num_cena
            // 
            this.num_cena.Location = new System.Drawing.Point(6, 152);
            this.num_cena.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_cena.Name = "num_cena";
            this.num_cena.Size = new System.Drawing.Size(120, 22);
            this.num_cena.TabIndex = 2;
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(6, 190);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 1;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // bt_otkazi
            // 
            this.bt_otkazi.Location = new System.Drawing.Point(168, 190);
            this.bt_otkazi.Name = "bt_otkazi";
            this.bt_otkazi.Size = new System.Drawing.Size(75, 23);
            this.bt_otkazi.TabIndex = 3;
            this.bt_otkazi.Text = "Otkazi";
            this.bt_otkazi.UseVisualStyleBackColor = true;
            this.bt_otkazi.Click += new System.EventHandler(this.bt_otkazi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dolzina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cena:";
            // 
            // error_name
            // 
            this.error_name.ContainerControl = this;
            // 
            // add_destination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 295);
            this.Controls.Add(this.groupBox1);
            this.Name = "add_destination";
            this.Text = "add_destination";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_dolzina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_cena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_name)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_otkazi;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.NumericUpDown num_cena;
        private System.Windows.Forms.NumericUpDown num_dolzina;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.ErrorProvider error_name;
    }
}
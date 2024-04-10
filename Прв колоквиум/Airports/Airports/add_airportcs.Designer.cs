namespace Airports
{
    partial class add_airportcs
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
            this.tb_city = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_kratenka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_OK = new System.Windows.Forms.Button();
            this.bt_cancle = new System.Windows.Forms.Button();
            this.error_empty = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_kratenka = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_empty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_kratenka)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_cancle);
            this.groupBox1.Controls.Add(this.bt_OK);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_kratenka);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.tb_city);
            this.groupBox1.Location = new System.Drawing.Point(40, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodadi aerodrom";
            // 
            // tb_city
            // 
            this.tb_city.Location = new System.Drawing.Point(6, 50);
            this.tb_city.Name = "tb_city";
            this.tb_city.Size = new System.Drawing.Size(279, 22);
            this.tb_city.TabIndex = 1;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(6, 115);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(279, 22);
            this.tb_name.TabIndex = 2;
            // 
            // tb_kratenka
            // 
            this.tb_kratenka.Location = new System.Drawing.Point(6, 187);
            this.tb_kratenka.Name = "tb_kratenka";
            this.tb_kratenka.Size = new System.Drawing.Size(148, 22);
            this.tb_kratenka.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kratenka:";
            // 
            // bt_OK
            // 
            this.bt_OK.Location = new System.Drawing.Point(6, 224);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(75, 23);
            this.bt_OK.TabIndex = 1;
            this.bt_OK.Text = "OK";
            this.bt_OK.UseVisualStyleBackColor = true;
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // bt_cancle
            // 
            this.bt_cancle.Location = new System.Drawing.Point(210, 224);
            this.bt_cancle.Name = "bt_cancle";
            this.bt_cancle.Size = new System.Drawing.Size(75, 23);
            this.bt_cancle.TabIndex = 6;
            this.bt_cancle.Text = "Otkazi";
            this.bt_cancle.UseVisualStyleBackColor = true;
            this.bt_cancle.Click += new System.EventHandler(this.bt_cancle_Click);
            // 
            // error_empty
            // 
            this.error_empty.ContainerControl = this;
            // 
            // error_kratenka
            // 
            this.error_kratenka.ContainerControl = this;
            // 
            // add_airportcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 325);
            this.Controls.Add(this.groupBox1);
            this.Name = "add_airportcs";
            this.Text = "add_airportcs";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_empty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_kratenka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_cancle;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_kratenka;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_city;
        private System.Windows.Forms.ErrorProvider error_empty;
        private System.Windows.Forms.ErrorProvider error_kratenka;
    }
}
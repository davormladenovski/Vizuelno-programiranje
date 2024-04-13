namespace Avtomobili
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_avtomobili = new System.Windows.Forms.ListBox();
            this.lb_marki = new System.Windows.Forms.ListBox();
            this.bt_add_marka = new System.Windows.Forms.Button();
            this.cb_marka = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_model = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.n_potrosuvacka = new System.Windows.Forms.NumericUpDown();
            this.n_cena = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.add_car = new System.Windows.Forms.Button();
            this.del_car = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_potrosuvacka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_cena)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.del_car);
            this.groupBox1.Controls.Add(this.add_car);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.n_cena);
            this.groupBox1.Controls.Add(this.n_potrosuvacka);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_model);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_marka);
            this.groupBox1.Location = new System.Drawing.Point(50, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nov avtomobil";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_avtomobili);
            this.groupBox2.Location = new System.Drawing.Point(449, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 501);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista na avtomobili";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_add_marka);
            this.groupBox3.Controls.Add(this.lb_marki);
            this.groupBox3.Location = new System.Drawing.Point(50, 334);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 196);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Marki na avtomobili";
            // 
            // lb_avtomobili
            // 
            this.lb_avtomobili.FormattingEnabled = true;
            this.lb_avtomobili.ItemHeight = 16;
            this.lb_avtomobili.Location = new System.Drawing.Point(6, 32);
            this.lb_avtomobili.Name = "lb_avtomobili";
            this.lb_avtomobili.Size = new System.Drawing.Size(344, 340);
            this.lb_avtomobili.TabIndex = 0;
            // 
            // lb_marki
            // 
            this.lb_marki.FormattingEnabled = true;
            this.lb_marki.ItemHeight = 16;
            this.lb_marki.Location = new System.Drawing.Point(6, 21);
            this.lb_marki.Name = "lb_marki";
            this.lb_marki.Size = new System.Drawing.Size(344, 132);
            this.lb_marki.TabIndex = 0;
            // 
            // bt_add_marka
            // 
            this.bt_add_marka.Location = new System.Drawing.Point(174, 159);
            this.bt_add_marka.Name = "bt_add_marka";
            this.bt_add_marka.Size = new System.Drawing.Size(176, 23);
            this.bt_add_marka.TabIndex = 1;
            this.bt_add_marka.Text = "Dodadi nova marka";
            this.bt_add_marka.UseVisualStyleBackColor = true;
            this.bt_add_marka.Click += new System.EventHandler(this.bt_add_marka_Click);
            // 
            // cb_marka
            // 
            this.cb_marka.FormattingEnabled = true;
            this.cb_marka.Location = new System.Drawing.Point(6, 50);
            this.cb_marka.Name = "cb_marka";
            this.cb_marka.Size = new System.Drawing.Size(344, 24);
            this.cb_marka.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marka:";
            // 
            // tb_model
            // 
            this.tb_model.Location = new System.Drawing.Point(9, 117);
            this.tb_model.Name = "tb_model";
            this.tb_model.Size = new System.Drawing.Size(341, 22);
            this.tb_model.TabIndex = 2;
            this.tb_model.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Model:";
            // 
            // n_potrosuvacka
            // 
            this.n_potrosuvacka.Location = new System.Drawing.Point(9, 167);
            this.n_potrosuvacka.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.n_potrosuvacka.Name = "n_potrosuvacka";
            this.n_potrosuvacka.Size = new System.Drawing.Size(120, 22);
            this.n_potrosuvacka.TabIndex = 4;
            // 
            // n_cena
            // 
            this.n_cena.Location = new System.Drawing.Point(9, 211);
            this.n_cena.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.n_cena.Name = "n_cena";
            this.n_cena.Size = new System.Drawing.Size(120, 22);
            this.n_cena.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Potrosuvacka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cena:";
            // 
            // add_car
            // 
            this.add_car.Location = new System.Drawing.Point(13, 270);
            this.add_car.Name = "add_car";
            this.add_car.Size = new System.Drawing.Size(148, 23);
            this.add_car.TabIndex = 2;
            this.add_car.Text = "Dodadi avtomobil";
            this.add_car.UseVisualStyleBackColor = true;
            this.add_car.Click += new System.EventHandler(this.add_car_Click);
            // 
            // del_car
            // 
            this.del_car.Location = new System.Drawing.Point(202, 270);
            this.del_car.Name = "del_car";
            this.del_car.Size = new System.Drawing.Size(148, 23);
            this.del_car.TabIndex = 8;
            this.del_car.Text = "Izbrisi avtomboil";
            this.del_car.UseVisualStyleBackColor = true;
            this.del_car.Click += new System.EventHandler(this.del_car_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.n_potrosuvacka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_cena)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lb_avtomobili;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_add_marka;
        private System.Windows.Forms.ListBox lb_marki;
        private System.Windows.Forms.TextBox tb_model;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_marka;
        private System.Windows.Forms.Button del_car;
        private System.Windows.Forms.Button add_car;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown n_cena;
        private System.Windows.Forms.NumericUpDown n_potrosuvacka;
        private System.Windows.Forms.Label label2;
    }
}


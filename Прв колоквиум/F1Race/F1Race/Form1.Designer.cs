namespace F1Race
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
            this.lb_vozaci = new System.Windows.Forms.ListBox();
            this.bt_add_vozac = new System.Windows.Forms.Button();
            this.bt_izbrisi_vozac = new System.Windows.Forms.Button();
            this.lb_krugovi = new System.Windows.Forms.ListBox();
            this.num_minuti = new System.Windows.Forms.NumericUpDown();
            this.num_sekundi = new System.Windows.Forms.NumericUpDown();
            this.bt_add_krug = new System.Windows.Forms.Button();
            this.Minuti = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.best_krug = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.num_vreme = new System.Windows.Forms.NumericUpDown();
            this.vreme = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_minuti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_sekundi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_vreme)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_izbrisi_vozac);
            this.groupBox1.Controls.Add(this.bt_add_vozac);
            this.groupBox1.Controls.Add(this.lb_vozaci);
            this.groupBox1.Location = new System.Drawing.Point(22, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 533);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vozaci";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.vreme);
            this.groupBox2.Controls.Add(this.num_vreme);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.best_krug);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Minuti);
            this.groupBox2.Controls.Add(this.bt_add_krug);
            this.groupBox2.Controls.Add(this.num_sekundi);
            this.groupBox2.Controls.Add(this.num_minuti);
            this.groupBox2.Controls.Add(this.lb_krugovi);
            this.groupBox2.Location = new System.Drawing.Point(422, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 533);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Krugovi";
            // 
            // lb_vozaci
            // 
            this.lb_vozaci.FormattingEnabled = true;
            this.lb_vozaci.ItemHeight = 16;
            this.lb_vozaci.Location = new System.Drawing.Point(6, 21);
            this.lb_vozaci.Name = "lb_vozaci";
            this.lb_vozaci.Size = new System.Drawing.Size(332, 404);
            this.lb_vozaci.TabIndex = 0;
            this.lb_vozaci.SelectedIndexChanged += new System.EventHandler(this.lb_vozaci_SelectedIndexChanged);
            // 
            // bt_add_vozac
            // 
            this.bt_add_vozac.Location = new System.Drawing.Point(6, 441);
            this.bt_add_vozac.Name = "bt_add_vozac";
            this.bt_add_vozac.Size = new System.Drawing.Size(332, 37);
            this.bt_add_vozac.TabIndex = 1;
            this.bt_add_vozac.Text = "Dodadi vozac";
            this.bt_add_vozac.UseVisualStyleBackColor = true;
            this.bt_add_vozac.Click += new System.EventHandler(this.bt_add_vozac_Click);
            // 
            // bt_izbrisi_vozac
            // 
            this.bt_izbrisi_vozac.Location = new System.Drawing.Point(6, 484);
            this.bt_izbrisi_vozac.Name = "bt_izbrisi_vozac";
            this.bt_izbrisi_vozac.Size = new System.Drawing.Size(332, 37);
            this.bt_izbrisi_vozac.TabIndex = 2;
            this.bt_izbrisi_vozac.Text = "Izbrisi vozac";
            this.bt_izbrisi_vozac.UseVisualStyleBackColor = true;
            this.bt_izbrisi_vozac.Click += new System.EventHandler(this.bt_izbrisi_vozac_Click);
            // 
            // lb_krugovi
            // 
            this.lb_krugovi.FormattingEnabled = true;
            this.lb_krugovi.ItemHeight = 16;
            this.lb_krugovi.Location = new System.Drawing.Point(6, 21);
            this.lb_krugovi.Name = "lb_krugovi";
            this.lb_krugovi.Size = new System.Drawing.Size(332, 356);
            this.lb_krugovi.TabIndex = 0;
            // 
            // num_minuti
            // 
            this.num_minuti.Location = new System.Drawing.Point(18, 403);
            this.num_minuti.Name = "num_minuti";
            this.num_minuti.Size = new System.Drawing.Size(100, 22);
            this.num_minuti.TabIndex = 1;
            // 
            // num_sekundi
            // 
            this.num_sekundi.Location = new System.Drawing.Point(133, 403);
            this.num_sekundi.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.num_sekundi.Name = "num_sekundi";
            this.num_sekundi.Size = new System.Drawing.Size(100, 22);
            this.num_sekundi.TabIndex = 2;
            this.num_sekundi.ValueChanged += new System.EventHandler(this.num_sekundi_ValueChanged);
            // 
            // bt_add_krug
            // 
            this.bt_add_krug.Location = new System.Drawing.Point(252, 390);
            this.bt_add_krug.Name = "bt_add_krug";
            this.bt_add_krug.Size = new System.Drawing.Size(86, 47);
            this.bt_add_krug.TabIndex = 3;
            this.bt_add_krug.Text = "Dodadi krug";
            this.bt_add_krug.UseVisualStyleBackColor = true;
            this.bt_add_krug.Click += new System.EventHandler(this.bt_add_krug_Click);
            // 
            // Minuti
            // 
            this.Minuti.AutoSize = true;
            this.Minuti.Location = new System.Drawing.Point(15, 384);
            this.Minuti.Name = "Minuti";
            this.Minuti.Size = new System.Drawing.Size(41, 16);
            this.Minuti.TabIndex = 4;
            this.Minuti.Text = "Minuti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sekundi";
            // 
            // best_krug
            // 
            this.best_krug.Location = new System.Drawing.Point(18, 456);
            this.best_krug.Name = "best_krug";
            this.best_krug.ReadOnly = true;
            this.best_krug.Size = new System.Drawing.Size(320, 22);
            this.best_krug.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Najdobar krug";
            // 
            // num_vreme
            // 
            this.num_vreme.Location = new System.Drawing.Point(18, 505);
            this.num_vreme.Name = "num_vreme";
            this.num_vreme.Size = new System.Drawing.Size(120, 22);
            this.num_vreme.TabIndex = 8;
            this.num_vreme.ValueChanged += new System.EventHandler(this.num_vreme_ValueChanged);
            // 
            // vreme
            // 
            this.vreme.AutoSize = true;
            this.vreme.Location = new System.Drawing.Point(15, 486);
            this.vreme.Name = "vreme";
            this.vreme.Size = new System.Drawing.Size(47, 16);
            this.vreme.TabIndex = 9;
            this.vreme.Text = "Vreme";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 566);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_minuti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_sekundi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_vreme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_izbrisi_vozac;
        private System.Windows.Forms.Button bt_add_vozac;
        private System.Windows.Forms.ListBox lb_vozaci;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Minuti;
        private System.Windows.Forms.Button bt_add_krug;
        private System.Windows.Forms.NumericUpDown num_sekundi;
        private System.Windows.Forms.NumericUpDown num_minuti;
        private System.Windows.Forms.ListBox lb_krugovi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox best_krug;
        private System.Windows.Forms.Label vreme;
        private System.Windows.Forms.NumericUpDown num_vreme;
    }
}


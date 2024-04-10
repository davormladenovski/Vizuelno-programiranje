namespace F1Race
{
    partial class nov_vozac
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
            this.tb_name = new System.Windows.Forms.TextBox();
            this.num_godini = new System.Windows.Forms.NumericUpDown();
            this.cb_prv = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_cancle = new System.Windows.Forms.Button();
            this.bt_ok = new System.Windows.Forms.Button();
            this.error_name = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.num_godini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_name)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(51, 67);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(207, 22);
            this.tb_name.TabIndex = 0;
            // 
            // num_godini
            // 
            this.num_godini.Location = new System.Drawing.Point(51, 127);
            this.num_godini.Name = "num_godini";
            this.num_godini.Size = new System.Drawing.Size(97, 22);
            this.num_godini.TabIndex = 1;
            // 
            // cb_prv
            // 
            this.cb_prv.AutoSize = true;
            this.cb_prv.Location = new System.Drawing.Point(163, 129);
            this.cb_prv.Name = "cb_prv";
            this.cb_prv.Size = new System.Drawing.Size(88, 20);
            this.cb_prv.TabIndex = 2;
            this.cb_prv.Text = "Prv vozac";
            this.cb_prv.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Godini";
            // 
            // bt_cancle
            // 
            this.bt_cancle.Location = new System.Drawing.Point(51, 167);
            this.bt_cancle.Name = "bt_cancle";
            this.bt_cancle.Size = new System.Drawing.Size(75, 23);
            this.bt_cancle.TabIndex = 5;
            this.bt_cancle.Text = "Otkazi";
            this.bt_cancle.UseVisualStyleBackColor = true;
            this.bt_cancle.Click += new System.EventHandler(this.bt_cancle_Click);
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(163, 167);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 6;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // error_name
            // 
            this.error_name.ContainerControl = this;
            // 
            // nov_vozac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 241);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.bt_cancle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_prv);
            this.Controls.Add(this.num_godini);
            this.Controls.Add(this.tb_name);
            this.Name = "nov_vozac";
            this.Text = "nov_vozac";
            ((System.ComponentModel.ISupportInitialize)(this.num_godini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_name)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.NumericUpDown num_godini;
        private System.Windows.Forms.CheckBox cb_prv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_cancle;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.ErrorProvider error_name;
    }
}
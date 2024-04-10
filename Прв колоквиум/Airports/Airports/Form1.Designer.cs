namespace Airports
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
            this.lb_airports = new System.Windows.Forms.ListBox();
            this.lb_destination = new System.Windows.Forms.ListBox();
            this.bt_add_airport = new System.Windows.Forms.Button();
            this.bt_del_airport = new System.Windows.Forms.Button();
            this.bt_add_destination = new System.Windows.Forms.Button();
            this.tb_naj = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_airports
            // 
            this.lb_airports.FormattingEnabled = true;
            this.lb_airports.ItemHeight = 16;
            this.lb_airports.Location = new System.Drawing.Point(30, 37);
            this.lb_airports.Name = "lb_airports";
            this.lb_airports.Size = new System.Drawing.Size(326, 356);
            this.lb_airports.TabIndex = 0;
            this.lb_airports.SelectedIndexChanged += new System.EventHandler(this.lb_airports_SelectedIndexChanged);
            // 
            // lb_destination
            // 
            this.lb_destination.FormattingEnabled = true;
            this.lb_destination.ItemHeight = 16;
            this.lb_destination.Location = new System.Drawing.Point(413, 37);
            this.lb_destination.Name = "lb_destination";
            this.lb_destination.Size = new System.Drawing.Size(326, 356);
            this.lb_destination.TabIndex = 1;
            // 
            // bt_add_airport
            // 
            this.bt_add_airport.Location = new System.Drawing.Point(30, 420);
            this.bt_add_airport.Name = "bt_add_airport";
            this.bt_add_airport.Size = new System.Drawing.Size(326, 33);
            this.bt_add_airport.TabIndex = 2;
            this.bt_add_airport.Text = "Dodadi aerodrom";
            this.bt_add_airport.UseVisualStyleBackColor = true;
            this.bt_add_airport.Click += new System.EventHandler(this.bt_add_airport_Click);
            // 
            // bt_del_airport
            // 
            this.bt_del_airport.Location = new System.Drawing.Point(30, 459);
            this.bt_del_airport.Name = "bt_del_airport";
            this.bt_del_airport.Size = new System.Drawing.Size(326, 33);
            this.bt_del_airport.TabIndex = 3;
            this.bt_del_airport.Text = "Izbrisi aerodrom";
            this.bt_del_airport.UseVisualStyleBackColor = true;
            this.bt_del_airport.Click += new System.EventHandler(this.bt_del_airport_Click);
            // 
            // bt_add_destination
            // 
            this.bt_add_destination.Location = new System.Drawing.Point(30, 498);
            this.bt_add_destination.Name = "bt_add_destination";
            this.bt_add_destination.Size = new System.Drawing.Size(326, 33);
            this.bt_add_destination.TabIndex = 4;
            this.bt_add_destination.Text = "Dodadi destinacija";
            this.bt_add_destination.UseVisualStyleBackColor = true;
            this.bt_add_destination.Click += new System.EventHandler(this.bt_add_destination_Click);
            // 
            // tb_naj
            // 
            this.tb_naj.Location = new System.Drawing.Point(413, 459);
            this.tb_naj.Name = "tb_naj";
            this.tb_naj.ReadOnly = true;
            this.tb_naj.Size = new System.Drawing.Size(326, 22);
            this.tb_naj.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(413, 503);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(326, 22);
            this.textBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Najskapa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prosecna";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 559);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tb_naj);
            this.Controls.Add(this.bt_add_destination);
            this.Controls.Add(this.bt_del_airport);
            this.Controls.Add(this.bt_add_airport);
            this.Controls.Add(this.lb_destination);
            this.Controls.Add(this.lb_airports);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_airports;
        private System.Windows.Forms.ListBox lb_destination;
        private System.Windows.Forms.Button bt_add_airport;
        private System.Windows.Forms.Button bt_del_airport;
        private System.Windows.Forms.Button bt_add_destination;
        private System.Windows.Forms.TextBox tb_naj;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


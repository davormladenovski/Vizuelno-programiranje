namespace Math_Quiz
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
            this.lb_questions = new System.Windows.Forms.ListBox();
            this.bt_answar = new System.Windows.Forms.Button();
            this.tb_des = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_questions
            // 
            this.lb_questions.FormattingEnabled = true;
            this.lb_questions.ItemHeight = 16;
            this.lb_questions.Location = new System.Drawing.Point(49, 40);
            this.lb_questions.Name = "lb_questions";
            this.lb_questions.Size = new System.Drawing.Size(268, 404);
            this.lb_questions.TabIndex = 0;
            // 
            // bt_answar
            // 
            this.bt_answar.Location = new System.Drawing.Point(442, 40);
            this.bt_answar.Name = "bt_answar";
            this.bt_answar.Size = new System.Drawing.Size(360, 51);
            this.bt_answar.TabIndex = 1;
            this.bt_answar.Text = "Answar the question";
            this.bt_answar.UseVisualStyleBackColor = true;
            this.bt_answar.Click += new System.EventHandler(this.bt_answar_Click);
            // 
            // tb_des
            // 
            this.tb_des.Location = new System.Drawing.Point(442, 130);
            this.tb_des.Multiline = true;
            this.tb_des.Name = "tb_des";
            this.tb_des.ReadOnly = true;
            this.tb_des.Size = new System.Drawing.Size(360, 145);
            this.tb_des.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 534);
            this.Controls.Add(this.tb_des);
            this.Controls.Add(this.bt_answar);
            this.Controls.Add(this.lb_questions);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_questions;
        private System.Windows.Forms.Button bt_answar;
        private System.Windows.Forms.TextBox tb_des;
    }
}


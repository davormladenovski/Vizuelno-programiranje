namespace Math_Quiz
{
    partial class random_question
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
            this.l_question = new System.Windows.Forms.Label();
            this.tb_answer = new System.Windows.Forms.TextBox();
            this.bt_OK = new System.Windows.Forms.Button();
            this.bt_cancle = new System.Windows.Forms.Button();
            this.error_not_number = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error_not_number)).BeginInit();
            this.SuspendLayout();
            // 
            // l_question
            // 
            this.l_question.AutoSize = true;
            this.l_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.l_question.Location = new System.Drawing.Point(48, 37);
            this.l_question.Name = "l_question";
            this.l_question.Size = new System.Drawing.Size(215, 58);
            this.l_question.TabIndex = 0;
            this.l_question.Text = "question";
            // 
            // tb_answer
            // 
            this.tb_answer.Location = new System.Drawing.Point(42, 120);
            this.tb_answer.Name = "tb_answer";
            this.tb_answer.Size = new System.Drawing.Size(231, 22);
            this.tb_answer.TabIndex = 1;
            // 
            // bt_OK
            // 
            this.bt_OK.Location = new System.Drawing.Point(42, 171);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(105, 39);
            this.bt_OK.TabIndex = 2;
            this.bt_OK.Text = "OK";
            this.bt_OK.UseVisualStyleBackColor = true;
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // bt_cancle
            // 
            this.bt_cancle.Location = new System.Drawing.Point(168, 171);
            this.bt_cancle.Name = "bt_cancle";
            this.bt_cancle.Size = new System.Drawing.Size(105, 39);
            this.bt_cancle.TabIndex = 3;
            this.bt_cancle.Text = "Cancle";
            this.bt_cancle.UseVisualStyleBackColor = true;
            this.bt_cancle.Click += new System.EventHandler(this.bt_cancle_Click);
            // 
            // error_not_number
            // 
            this.error_not_number.ContainerControl = this;
            // 
            // random_question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 270);
            this.Controls.Add(this.bt_cancle);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.tb_answer);
            this.Controls.Add(this.l_question);
            this.Name = "random_question";
            this.Text = "random_question";
            this.Load += new System.EventHandler(this.random_question_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error_not_number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_question;
        private System.Windows.Forms.TextBox tb_answer;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.Button bt_cancle;
        private System.Windows.Forms.ErrorProvider error_not_number;
    }
}
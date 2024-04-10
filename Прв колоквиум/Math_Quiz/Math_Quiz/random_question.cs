using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Quiz
{
    public partial class random_question : Form
    {
        public random_question()
        {
            InitializeComponent();
        }

        public string[] operators = new string[] { "+", "-", "*" };

        public question new_question;

        private void random_question_Load(object sender, EventArgs e)
        {
            Random random = new Random();

            int op1 = random.Next(0, 100);
            int op2 = random.Next(0, 100);
            string oper = operators[random.Next(0,2)];

            new_question = new question(op1,op2,oper);

            l_question.Text=$"{new_question.operand1} {new_question.operation} {new_question.operand2}";

        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            int answer=0;
            if(int.TryParse(tb_answer.Text, out answer))
            {

                DataTable dt = new DataTable();

                string expersion = $"{new_question.operand1} {new_question.operation} {new_question.operand2}";

                object result = dt.Compute(expersion, "");

                int result_ = Convert.ToInt32(result);

                if (result_ == answer)
                {
                    new_question.tocnost = "TOCNO";

                    if(new_question.operand1>=0 && new_question.operand1 < 10)
                    {
                        new_question.points += 1;
                    }

                    if (new_question.operand2 >= 0 && new_question.operand2 < 10)
                    {
                        new_question.points += 1;
                    }

                    if (new_question.operand1 >= 10 && new_question.operand1 < 99)
                    {
                        new_question.points += 2;
                    }

                    if (new_question.operand2 >= 10 && new_question.operand2 < 99)
                    {
                        new_question.points += 2;
                    }

                    if (new_question.operation == "*")
                    {
                        new_question.points *= 3;
                    }

                }
                else
                {
                    new_question.tocnost = "NETOCNO";

                    new_question.points = -2;


                }

                this.DialogResult = DialogResult.OK;
                
               

            }
            else
            {
                error_not_number.SetError(tb_answer, "Not a number!!!");
                return;
            }
        }

        private void bt_cancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

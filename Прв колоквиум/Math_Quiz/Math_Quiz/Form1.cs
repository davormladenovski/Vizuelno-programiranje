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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public int vkupno_prasanja = 0;
        public int min_poeni = 10000000;
        public int max_poeni = -10000000;
        public int vkupno = 0;
        public float prosek = 0;
        private void desc_change()
        {

            vkupno_prasanja=lb_questions.Items.Count;

            foreach(question question in lb_questions.Items)
            {

                if (question.points > max_poeni)
                {
                    max_poeni=question.points;
                }
                if(question.points < min_poeni)
                {
                    min_poeni=question.points;
                }

                vkupno += question.points;

            }

            prosek = vkupno / vkupno_prasanja;

            tb_des.Text = $"Vkupno prasanja:{vkupno_prasanja}{Environment.NewLine}" +
                $"Min poeni:{min_poeni}{Environment.NewLine}" +
                $"Max poeni:{max_poeni}{Environment.NewLine}" +
                $"Vkupno poeni:{vkupno}{Environment.NewLine}" +
                $"Prosek:{prosek}";


        }

        private void bt_answar_Click(object sender, EventArgs e)
        {
            random_question new_q = new random_question();

            if(new_q.ShowDialog() == DialogResult.OK )
            {

                question quest = new_q.new_question;

                lb_questions.Items.Add(quest);

                desc_change();


            }

        }

        
    }
}

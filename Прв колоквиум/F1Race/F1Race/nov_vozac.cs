using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1Race
{
    public partial class nov_vozac : Form
    {
        public nov_vozac()
        {
            InitializeComponent();
        }

        public vozac vozac;
        private void bt_ok_Click(object sender, EventArgs e)
        {

            if (tb_name.Text.Length == 0)
            {
                error_name.SetError(tb_name, "Ne smee da e prazno poleto!");
                return;
            }

            string name = tb_name.Text;
            int age = (int)num_godini.Value;
            bool prv = cb_prv.Checked;

            vozac = new vozac(name, age, prv);

            this.DialogResult = DialogResult.OK;




        }

        private void bt_cancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

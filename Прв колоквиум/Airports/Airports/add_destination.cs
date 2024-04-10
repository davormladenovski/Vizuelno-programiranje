using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airports
{
    public partial class add_destination : Form
    {
        public add_destination()
        {
            InitializeComponent();
        }

        public destination destination;

        private void bt_ok_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;

            int distance = (int)num_dolzina.Value;

            int price = (int)num_cena.Value;

            if (name.Length <= 0)
            {
                error_name.SetError(tb_name, "Ne smee prazno pole!");
                return;
            }

            destination = new destination(name, distance, price);   

            this.DialogResult= DialogResult.OK;


        }

        private void bt_otkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

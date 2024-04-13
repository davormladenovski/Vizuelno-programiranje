using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avtomobili
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_add_marka_Click(object sender, EventArgs e)
        {
            add_marka marka = new add_marka();

            if(marka.ShowDialog()== DialogResult.OK)
            {
                lb_marki.Items.Add(marka.nova_marka);
                cb_marka.Items.Add(marka.nova_marka);
            }

           
        }

        private void add_car_Click(object sender, EventArgs e)
        {
            Marka marka = cb_marka.SelectedItem as Marka;   
            string model = tb_model.Text;
            int potrosuvacka = (int)n_potrosuvacka.Value;
            int cena = (int)n_cena.Value;

            car nova_kola = new car(model, potrosuvacka, cena, marka);

            lb_avtomobili.Items.Add(nova_kola);



        }

        private void del_car_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sakas navistina da izbrises?","Brisenje avtomobil",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            
            if(result == DialogResult.Yes) {
                lb_avtomobili.Items.Remove(lb_avtomobili.SelectedItem);

            }
            else
            {
                return;
            }
        }
    }
}

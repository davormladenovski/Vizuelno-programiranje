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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_add_vozac_Click(object sender, EventArgs e)
        {

            nov_vozac nov = new nov_vozac();

            if(nov.ShowDialog() == DialogResult.OK)
            {

                lb_vozaci.Items.Add(nov.vozac);

            }


        }

        private void bt_izbrisi_vozac_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show($"Dali navistina sakate da go izbristete vozacot {lb_vozaci.SelectedItem}","Predupreduvanje",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(dialogResult == DialogResult.Yes)
            {
                lb_vozaci.Items.Remove(lb_vozaci.SelectedItem);
            }

        }

        private void bt_add_krug_Click(object sender, EventArgs e)
        {

            vozac izbran = lb_vozaci.SelectedItem as vozac;

            if(izbran != null)
            {
                int minuti = (int) num_minuti.Value;
                int sekundi = (int)num_sekundi.Value;

                if (minuti > 0 && sekundi >= 0)
                {
                    krug krug = new krug(minuti, sekundi);

                    izbran.krugovi.Add(krug);
                    lb_vozaci_SelectedIndexChanged(this, new EventArgs());

                }

            }


        }

        private void lb_vozaci_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_krugovi.Items.Clear();

            vozac izbran = lb_vozaci.SelectedItem as vozac;

            krug best = new krug(100000,100000);

            int vreme = (int)num_vreme.Value;

            if(izbran!= null)
            {

                foreach(krug krug in izbran.krugovi)
                {
                    if ((krug.minuti * 60 + krug.sekundi) > vreme)
                    {
                        lb_krugovi.Items.Add(krug);

                        if (best.minuti > krug.minuti)
                        {
                            best = krug;

                        }
                        else if (best.minuti == krug.minuti)
                        {
                            if (best.sekundi > krug.sekundi)
                            {
                                best = krug;
                            }
                        }
                    }
                }


            }
            if (lb_vozaci.Items.Count > 0)
            {
                best_krug.Text = best.ToString();
            }

        }

        private void num_sekundi_ValueChanged(object sender, EventArgs e)
        {
            if (num_sekundi.Value > 59)
            {
                num_minuti.Value += 1;
                num_sekundi.Value = 0;
            }
        }

        private void num_vreme_ValueChanged(object sender, EventArgs e)
        {
            lb_vozaci_SelectedIndexChanged(sender, e);
        }
    }
}

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
    public partial class add_marka : Form
    {
        public add_marka()
        {
            InitializeComponent();
        }

        private void add_marka_Load(object sender, EventArgs e)
        {

        }

        public Marka nova_marka {  get; set; }  

        private void dodadi_Click(object sender, EventArgs e)
        {
            string ime = marka_ime.Text;
            string sifra = marka_sifra.Text;
            bool flag = false;
            if (ime.Length == 0)
            {
                blank.SetError(marka_ime, "Requaret");
                flag = true;
            }

            if (sifra.Length == 0)
            {
                blank.SetError(marka_sifra, "Requaret");
                flag = true;
            }

            if (flag == true)
            {
                return;
            }

            nova_marka = new Marka(ime,sifra);

            this.DialogResult = DialogResult.OK;    

        }

        private void otkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

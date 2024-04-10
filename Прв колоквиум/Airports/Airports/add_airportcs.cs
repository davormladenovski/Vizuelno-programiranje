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
    public partial class add_airportcs : Form
    {
        public add_airportcs()
        {
            InitializeComponent();
        }

        public airport airport;

        private void bt_OK_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            string short_name = tb_kratenka.Text;
            string city = tb_city.Text;

            if (name.Length <= 0)
            {
                error_empty.SetError(tb_name, "Ne smee prazno pole!");
                return; 
            }
            if (city.Length <= 0)
            {
                error_empty.SetError(tb_city, "Ne smee prazno pole!");
                return;
            }

            foreach(char c in short_name)
            {
                if (!Char.IsUpper(c))
                {
                    error_kratenka.SetError(tb_kratenka, "Mora da e tocno 3 golemi bukvi");
                    return;
                }
            }

            if(short_name.Length !=3)
            {
                error_kratenka.SetError(tb_kratenka, "Mora da e tocno 3 golemi bukvi");
                return;
            }

            airport = new airport(city, name, short_name);

            this.DialogResult= DialogResult.OK;



        }

        private void bt_cancle_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }
    }
}

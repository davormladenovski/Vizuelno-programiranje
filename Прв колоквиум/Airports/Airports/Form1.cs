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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_add_airport_Click(object sender, EventArgs e)
        {
            add_airportcs new_airport = new add_airportcs();

            if (new_airport.ShowDialog() == DialogResult.OK)
            {
                lb_airports.Items.Add(new_airport.airport);
            }
        }

        private void bt_del_airport_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Dali ste sigurni deka sakate da go izbrisete: {lb_airports.SelectedItem} ","Predupreduvanje",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lb_airports.Items.Remove(lb_airports.SelectedItem);
            }
        }

        private void bt_add_destination_Click(object sender, EventArgs e)
        {

            if(lb_airports.SelectedItems.Count == 1)
            {
                airport selected = lb_airports.SelectedItem as airport;

                add_destination new_destination = new add_destination();

                if (new_destination.ShowDialog() == DialogResult.OK)
                {
                    selected.destinations.Add(new_destination.destination);

                    lb_airports_SelectedIndexChanged(sender, e);
                    najskapa();
                }


            }


        }

        public void najskapa()
        {
            airport selected = lb_airports.SelectedItem as airport;

            destination najskapa = new destination("nepoznata",0,0);

            foreach(destination dest in selected.destinations)
            {
                if (dest.cena > najskapa.cena)
                {
                    najskapa = dest;
                }
            }

            tb_naj.Text=najskapa.ToString();



        }

        private void lb_airports_SelectedIndexChanged(object sender, EventArgs e)
        {

            lb_destination.Items.Clear();

            airport selected = lb_airports.SelectedItem as airport;

            foreach(destination dest in selected.destinations)
            {

                lb_destination.Items.Add(dest);

            }

            najskapa();


        }
    }
}

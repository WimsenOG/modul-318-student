using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport.Core;

namespace My_Transport_APP
{
    public partial class Fahrplan : Form
    {
        public Fahrplan()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void coBoxVon_SelectedIndexChanged(object sender, EventArgs e)
        {
            var transport = new Transport();
            

        }

        private void btnSucheVerbindung_Click(object sender, EventArgs e)
        {
            dataGridViewVerbindungen.Rows.Clear();
            var transport = new Transport();
            var Stationconnection = transport.GetConnections(coBoxVon.Text, coBoxNach.Text).ConnectionList;
            foreach (var StationConFoch in Stationconnection) 
            {
                dataGridViewVerbindungen.Rows.Add(coBoxVon.Text, coBoxNach.Text, StationConFoch.From.Departure,StationConFoch.From.Platform,StationConFoch.From.Delay+" min");
            }
        }

        private void coBoxVon_TextChanged(object sender, EventArgs e)
        {
            if (coBoxVon.Text != "")
            {
                var transport = new Transport();
                var Statios = transport.GetStations(coBoxVon.Text).StationList;

                var stationsAutoComplete = new AutoCompleteStringCollection();
                foreach (var stationForech in Statios)
                {
                    stationsAutoComplete.Add(stationForech.Name);
                }

                coBoxVon.AutoCompleteCustomSource = stationsAutoComplete;
            }
        }

        private void coBoxNach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (coBoxNach.Text != "")
            {
                var transport = new Transport();
                var Statios = transport.GetStations(coBoxNach.Text).StationList;

                var stationsAutoComplete = new AutoCompleteStringCollection();
                foreach (var stationForech in Statios)
                {
                    stationsAutoComplete.Add(stationForech.Name);
                }

                coBoxNach.AutoCompleteCustomSource = stationsAutoComplete;
            }
        }

        private void dataGridViewVerbindungen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
           
        
        
    }


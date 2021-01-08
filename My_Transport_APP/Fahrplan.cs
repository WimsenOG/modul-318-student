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
        //Such Button für die Verbindungstaffel
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
        //Für die Vorschläge während des Tippens(Von wo)
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
        }

        private void dataGridViewVerbindungen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Für die Vorschläge während des Tippens(Nach wohin)
        private void coBoxNach_TextChanged(object sender, EventArgs e)
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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        //Für die Vorschläge während des Tippens(Abfahrttaffel)
        private void coBoxAbfahrtstaffel_TextChanged(object sender, EventArgs e)
        {
            if (coBoxAbfahrtstaffel.Text != "")
            {
                var transport = new Transport();
                var Statios = transport.GetStations(coBoxAbfahrtstaffel.Text).StationList;

                var stationsAutoComplete = new AutoCompleteStringCollection();
                foreach (var stationForech in Statios)
                {
                    stationsAutoComplete.Add(stationForech.Name);
                }

                coBoxAbfahrtstaffel.AutoCompleteCustomSource = stationsAutoComplete;
            }
        }
        //Such Button für Abfahrtstaffel
        private void btnSucheAbfahrtstaffel_Click(object sender, EventArgs e)
        {
            dataGridViewAbfahrtsTafel.Rows.Clear();
            var transport = new Transport();
            var Stations = transport.GetStations(coBoxAbfahrtstaffel.Text).StationList[0];
            var Stationconnection = transport.GetStationBoard(coBoxAbfahrtstaffel.Text,Stations.Id);
            foreach (var StationConFoch in Stationconnection.Entries)
            {
                dataGridViewAbfahrtsTafel.Rows.Add(coBoxAbfahrtstaffel.Text,StationConFoch.To,StationConFoch.Stop.Departure, StationConFoch.Name);
            }
        }
        //Das Programm mit einem Button Beenden
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bist du Sicher ?", "Schliessen", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
           
        
        
    }


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap_project.model;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using GMap_project.ui;

namespace GMap_project
{
    public partial class Form1 : Form
    {

        private DataManager dm;

        private List<PointLatLng> points;

        GMapOverlay markers = new GMapOverlay("markers");
        public Form1()
        {
            InitializeComponent();
            dm = new DataManager();

            points = new List<PointLatLng>();
            fillMunicipiosBox();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GoogleMapProvider.Instance;  
            GMaps.Instance.Mode = AccessMode.ServerOnly;

            gMapControl1.Position = new PointLatLng(3.42158, -76.5205);



            gMapControl1.Overlays.Add(markers);
        }

        private void setMarkers()  
        {
            foreach (PointLatLng p in points) 
            {
                GMapMarker marker = new GMarkerGoogle(p, GMarkerGoogleType.red_dot);
                markers.Markers.Add(marker); 
            }

        }

        private void loadPoints_Click(object sender, EventArgs e)
        {
            points.Clear();
            markers.Clear();
            List<String> coordinates = dm.getCoordinates();
            
            foreach (String c in coordinates) {
                String coord = c.Trim('"','(',')');
                
                var arr = coord.Split(',');
                var latt = arr[0].Replace('.', ',');
                var lonn = arr[1].Replace('.', ',');
                double lat = double.Parse(latt);
                double lon = double.Parse(lonn);
                PointLatLng p = new PointLatLng(lat, lon);
                points.Add(p);
                
            }
            setMarkers();
        }

        private void openTableWindow_Click(object sender, EventArgs e)
        {
            Console.WriteLine(dm.dataTable.Rows.Count);
            TableWindow tableWindow = new TableWindow(dm.dataTable);
            tableWindow.Show();
        }

        private void clearMapButton_Click(object sender, EventArgs e)
        {
            points.Clear();
            markers.Clear();
        }

        private void fillMunicipiosBox() {
            DataTable data = dm.dataTable;
            List<String> municipios = new List<string>();
            for (int i = 0; i < data.Rows.Count; i++) {
                municipios.Add(data.Rows[i]["MUNICIPIO"].ToString());
            }
            municipios.Sort();
            var control = "";
            for (int i = 0; i < municipios.Count; i++)
            {
                String municipio = municipios[i];
                if (!municipio.Equals(control))
                {
                    municipiosBox.Items.Add(municipio);
                    control = municipio;
                }
            }

        }

        private void municipiosBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            points.Clear();
            markers.Clear();
            List<String> filterCoords = dm.filterCoords(municipiosBox.Text);
            foreach (String c in filterCoords)
            {
                String coord = c.Trim('"', '(', ')');

                var arr = coord.Split(',');
                var latt = arr[0].Replace('.', ',');
                var lonn = arr[1].Replace('.', ',');
                double lat = double.Parse(latt);
                double lon = double.Parse(lonn);
                PointLatLng p = new PointLatLng(lat, lon);
                points.Add(p);

            }
            setMarkers();

        }
    }
}

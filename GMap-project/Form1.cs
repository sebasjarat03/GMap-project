using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap_project.Model;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

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
        }
    }
}

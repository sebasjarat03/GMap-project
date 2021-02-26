using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMap_project.ui
{
    public partial class ChartsForm : Form
    {
        private DataTable data;

        public ChartsForm(DataTable data)
        {
            InitializeComponent();
            this.data = data;
            paintCharts();
        }

        private void paintCharts()
        {
            paintBarsChart();
            paintPieChart();
            paintPointsChart();
        }

        private void paintBarsChart()
        {
            var accountGroups = this.data.AsEnumerable()
                .GroupBy(row => row.Field<String>("MUNICIPIO"))
                .Select(grp => new { Account = grp.Key, Count = grp.Count() });

            barChart.ChartAreas[0].AxisX.Interval = 1;
            foreach (var group in accountGroups)
            {
                barChart.Series[0].Points.AddXY(group.Account, group.Count);
            }
        }

        private void paintPieChart()
        {
            var accountGroups = this.data.AsEnumerable()
               .GroupBy(row => row.Field<String>("GESTOR"))
               .Select(grp => new { Account = grp.Key, Count = grp.Count() });

            int i = 0;
            foreach (var group in accountGroups)
            {
                pieChart.Series[0].Points.AddXY(group.Account, group.Count);
                pieChart.Series[0].Points[i].LegendText = group.Account;
                i++;
            }

            pieChart.Series[0].IsValueShownAsLabel = true;
        }

        private void paintPointsChart()
        {
            data.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}'", "MUNICIPIO", "Cali");

            var accountGroups = this.data.AsEnumerable()
               .GroupBy(row => row.Field<String>("GESTOR"))
               .Select(grp => new { Account = grp.Key, Count = grp.Count() });

            foreach (var group in accountGroups)
            {
                pointsChart.Series[0].Points.AddXY(group.Account, group.Count);
            }

            pointsChart.ChartAreas[0].AxisY.Interval = 5;
        }
    }
}

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
    public partial class TableWindow : Form
    {
        private static String GESTOR = "CATEGORICO";
        private static String MUNICIPIO = "CATEGORICO";
        private static String NOMBRE_DEL_SITIO = "CADENA";

        List<String> municipios = new List<string>();
        List<String> gestores = new List<string>();

        public TableWindow(DataTable data)
        {
            InitializeComponent();
            this.dataGridView1.DataSource = data;
            for (int i = 0; i < dataGridView1.ColumnCount; i++) {
                if(i==0 || i== 2 || i == 4) {
                    String fields = dataGridView1.Columns[i].Name;
                    fieldBox.Items.Add(fields);
                }
                
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                gestores.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
                municipios.Add(dataGridView1.Rows[i].Cells[2].Value.ToString());

            }
            


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fieldBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fieldBox.Text.Equals("GESTOR"))
            {
                parameterBox.Visible = true;
                placeName.Visible = false;
                parameterBox.Items.Clear();
                var control = "";
                
                gestores.Sort();
                for (int i = 0; i < gestores.Count; i++) {
                    String gestor = gestores[i];
                    if (!gestor.Equals(control))
                    {

                        parameterBox.Items.Add(gestor);
                        control = gestor;
                    }
                }
            }
            else if (fieldBox.Text.Equals("MUNICIPIO"))
            {
                parameterBox.Visible = true;
                placeName.Visible = false;
                parameterBox.Items.Clear();
                var control = "";
                

                municipios.Sort();
                for (int i = 0; i < municipios.Count; i++) {
                    String municipio = municipios[i];
                    if (!municipio.Equals(control))
                    {
                        parameterBox.Items.Add(municipio);
                        control = municipio;
                    }
                }
                
            }
            else {
                placeName.Visible = true;
                parameterBox.Visible = false;
            }
        }

        private void parameterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filterField = fieldBox.Text;
            ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}'", filterField, parameterBox.Text);
        }
    }
}

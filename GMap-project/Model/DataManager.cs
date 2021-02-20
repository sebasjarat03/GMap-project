using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using Microsoft.VisualBasic.FileIO;

namespace GMap_project.model
{
    class DataManager
    {
        private const String PATH = "..\\..\\..\\data\\Data.csv";

        private List<String> coordinates;
        public DataTable dataTable { get; }

        public DataManager() {
            coordinates = new List<string>();
            readCoordinates();
            dataTable = generateDataTable(PATH);
        }

        private void readCoordinates() {
            var reader = new StreamReader(File.OpenRead(PATH));

            var oooout = reader.ReadLine();
            while (!reader.EndOfStream) {
                
                var line = reader.ReadLine();
                var array = line.Split(',');

                coordinates.Add(array[6] + "," + array[7]);
            }
        }

        public List<String> getCoordinates() {
            return coordinates;
        }

        private DataTable generateDataTable(string fileName, bool firstRowContainsFieldNames = true)
        {
            DataTable result = new DataTable();

            if (fileName == "")
            {
                return result;
            }

            string delimiters = ",";
            string extension = Path.GetExtension(fileName);

            using (TextFieldParser tfp = new TextFieldParser(fileName))
            {
                tfp.SetDelimiters(delimiters);

                // Get The Column Names
                if (!tfp.EndOfData)
                {
                    string[] fields = tfp.ReadFields();

                    for (int i = 0; i < fields.Count(); i++)
                    {
                        if (firstRowContainsFieldNames)
                            result.Columns.Add(fields[i]);
                        else
                            result.Columns.Add("Col" + i);
                    }

                    // If first line is data then add it
                    if (!firstRowContainsFieldNames)
                        result.Rows.Add(fields);
                }

                // Get Remaining Rows from the CSV
                while (!tfp.EndOfData)
                    result.Rows.Add(tfp.ReadFields());
            }

            return result;
        }
    }
}

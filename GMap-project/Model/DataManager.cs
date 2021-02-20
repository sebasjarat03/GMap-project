using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GMap_project.Model
{
    class DataManager
    {
        private const String PATH = "C:\\Users\\sejat\\source\\repos\\GMap-project\\Data\\Data.csv";
        List<String> coordinates;

        public DataManager() {
            coordinates = new List<string>();
            readCoordinates();
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

        
    }
}

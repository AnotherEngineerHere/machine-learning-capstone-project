using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Capstone.GUI
{
    class CSVFileHandler
    {

        public CSVFileHandler() 
        {

        }

        public DataTable ImportFromCsvFile(string filePath)
        {
            var rows = 0;
            var data = new DataTable();

            try
            {
                using (var reader = new StreamReader(File.OpenRead(filePath)))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Substring(0, line.Length - 1).Split(';');

                        foreach (var item in values)
                        {
                            if (string.IsNullOrEmpty(item) || string.IsNullOrWhiteSpace(item))
                            {
                                throw new Exception("Value can't be empty");
                            }

                            if (rows == 0)
                            {
                                data.Columns.Add(item);
                            }
                        }

                        if (rows > 0)
                        {
                            data.Rows.Add(values);
                        }

                        rows++;

                        if (values.Length != data.Columns.Count)
                        {
                            throw new Exception("Row is shorter or longer than title row");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                data = null;
            }

            // if no rows are entered or data == null, return null
            return data?.Rows.Count > 0 ? data : null;
        }

        public static void ExportToCsvFile(DataTable data, string filePath)
        {
            if (data.Columns.Count == 0)
            {
                throw new Exception("Nothing to export");
            }

            var sb = new StringBuilder();

            // add titles to the string builder
            foreach (var item in data.Columns)
            {
                // seperate values with a ;
                sb.AppendFormat($"{item};");
            }

            sb.AppendLine();

            // add every row to the string builder
            for (var i = 0; i < data.Rows.Count; i++)
            {
                for (var j = 0; j < data.Columns.Count; j++)
                {
                    // seperate values with a ;
                    sb.AppendFormat($"{data.Rows[i][j]};");
                }

                sb.AppendLine();
            }

            File.WriteAllText(filePath, sb.ToString());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Data sucessfully exported");
            Console.ResetColor();
        }
    }
}

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Tools.csv
{
    public class CsvHelper
    {
        public List<string[]> ReadCsv(string filePath)
        {
            List<string[]> csvData = new List<string[]>();

            using (StreamReader reader = new StreamReader(filePath, Encoding.Default))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] cells = line.Split(',');
                    csvData.Add(cells);
                }
            }

            return csvData;
        }

        public void WriteCsv(string filePath, List<string[]> csvData)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.Default))
            {
                foreach (string[] row in csvData)
                {
                    string line = string.Join(",", row);
                    writer.WriteLine(line);
                }
            }
        }
        public string ReadCsvCell(string filePath, int rowIndex, int columnIndex)
        {
            using (StreamReader reader = new StreamReader(filePath, Encoding.Default))
            {
                for (int i = 0; i < rowIndex; i++)
                {
                    reader.ReadLine(); // 跳過行
                }

                string line = reader.ReadLine();
                string[] cells = line.Split(',');
                return cells[columnIndex];
            }
        }

        public void WriteCsvCell(string filePath, int rowIndex, int columnIndex, string value)
        {
            List<string[]> csvData = ReadCsv(filePath);

            if (rowIndex < csvData.Count)
            {
                string[] row = csvData[rowIndex];
                if (columnIndex < row.Length)
                {
                    row[columnIndex] = value;
                }
            }

            WriteCsv(filePath, csvData);
        }
        public List<string[]> SearchList(List<string[]> list, string searchValue)
        {
            var result = list.Where(array => array.Contains(searchValue)).ToList();
            return result;
        }

        public List<int> SearchListIndex(List<string[]> list, string searchValue)
        {
            var result = list
                .Select((array, index) => new { Array = array, Index = index })
                .Where(x => x.Array.Contains(searchValue))
                .Select(x => x.Index)
                .ToList();

            return result;
        }
    }
}

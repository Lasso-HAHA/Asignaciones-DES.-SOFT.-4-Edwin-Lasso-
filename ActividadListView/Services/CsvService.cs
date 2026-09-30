using CsvHelper;
using CsvHelper.Configuration;
using CsvJsonManager.Models;
using System.Globalization;

namespace CsvJsonManager.Services
{
    public class CsvService
    {
        public DataDocument Load(string filePath)
        {
            var document = new DataDocument
            {
                FilePath = filePath,
                FileName = Path.GetFileName(filePath),
                FileType = "CSV"
            };

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                MissingFieldFound = null,
                BadDataFound = null
            };

            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, config);

            csv.Read();
            csv.ReadHeader();

            var headers = csv.HeaderRecord;

            if (headers == null)
                return document;

            document.Columns.AddRange(headers);

            while (csv.Read())
            {
                var row = new List<string>();

                for (int i = 0; i < headers.Length; i++)
                {
                    row.Add(csv.GetField(i) ?? string.Empty);
                }

                document.Rows.Add(row);
            }

            return document;
        }

        public void Save(DataDocument document, string filePath)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true
            };

            using var writer = new StreamWriter(filePath);
            using var csv = new CsvWriter(writer, config);

            // Escribir encabezados
            foreach (string column in document.Columns)
            {
                csv.WriteField(column);
            }

            csv.NextRecord();

            // Escribir registros
            foreach (List<string> row in document.Rows)
            {
                foreach (string value in row)
                {
                    csv.WriteField(value);
                }

                csv.NextRecord();
            }
        }

    }
}

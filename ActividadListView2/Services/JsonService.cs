using System.Text.Json;
using CsvJsonManager.Models;

namespace CsvJsonManager.Services
{
    public class JsonService
    {
        public DataDocument Load(string filePath)
        {
            var document = new DataDocument
            {
                FilePath = filePath,
                FileName = Path.GetFileName(filePath),
                FileType = "JSON"
            };

            string json = File.ReadAllText(filePath);

            using JsonDocument jsonDocument = JsonDocument.Parse(json);

            JsonElement root = jsonDocument.RootElement;

            if (root.ValueKind != JsonValueKind.Array)
            {
                throw new Exception(
                    "El archivo JSON debe contener un arreglo de objetos.");
            }

            if (root.GetArrayLength() == 0)
                return document;

            // Obtener las columnas del primer objeto
            JsonElement firstObject = root[0];

            if (firstObject.ValueKind != JsonValueKind.Object)
            {
                throw new Exception(
                    "El JSON debe contener objetos dentro del arreglo.");
            }

            foreach (JsonProperty property in firstObject.EnumerateObject())
            {
                document.Columns.Add(property.Name);
            }

            // Leer todos los objetos
            foreach (JsonElement item in root.EnumerateArray())
            {
                if (item.ValueKind != JsonValueKind.Object)
                    continue;

                var row = new List<string>();

                foreach (string column in document.Columns)
                {
                    if (item.TryGetProperty(column, out JsonElement value))
                    {
                        row.Add(GetValueAsString(value));
                    }
                    else
                    {
                        row.Add(string.Empty);
                    }
                }

                document.Rows.Add(row);
            }

            return document;
        }

        private string GetValueAsString(JsonElement value)
        {
            return value.ValueKind switch
            {
                JsonValueKind.String => value.GetString() ?? string.Empty,

                JsonValueKind.Number => value.ToString(),

                JsonValueKind.True => "true",

                JsonValueKind.False => "false",

                JsonValueKind.Null => string.Empty,

                JsonValueKind.Object => value.GetRawText(),

                JsonValueKind.Array => value.GetRawText(),

                _ => value.ToString()
            };
        }

        public void Save(DataDocument document, string filePath)
        {
            var records = new List<Dictionary<string, string>>();

            foreach (List<string> row in document.Rows)
            {
                var record = new Dictionary<string, string>();

                for (int i = 0; i < document.Columns.Count; i++)
                {
                    string value = i < row.Count
                        ? row[i]
                        : string.Empty;

                    record[document.Columns[i]] = value;
                }

                records.Add(record);
            }

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(records, options);

            File.WriteAllText(filePath, json);
        }

    }
}

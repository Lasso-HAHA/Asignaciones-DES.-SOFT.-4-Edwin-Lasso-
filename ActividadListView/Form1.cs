using CsvJsonManager.Models;
using CsvJsonManager.Services;

namespace ActividadListView
{
    public partial class MainForm : Form
    {
        private DataDocument? currentDocument;
        private readonly CsvService csvService = new CsvService();
        private readonly JsonService jsonService = new JsonService();

        public MainForm()
        {
            InitializeComponent();


        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter =
                "Archivos compatibles|*.csv;*.json|" +
                "Archivos CSV|*.csv|" +
                "Archivos JSON|*.json|" +
                "Todos los archivos|*.*";

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            string filePath = openFileDialog1.FileName;

            string extension = Path.GetExtension(filePath).ToLowerInvariant();

            try
            {
                if (extension == ".csv")
                {
                    currentDocument = csvService.Load(filePath);
                }
                else if (extension == ".json")
                {
                    currentDocument = jsonService.Load(filePath);
                }
                else
                {
                    MessageBox.Show(
                        "El formato del archivo no es compatible.",
                        "Formato no compatible",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DisplayDocument();

                lblEstado.Text =
                    $"Archivo: {currentDocument.FileName} | " +
                    $"Formato: {currentDocument.FileType} | " +
                    $"Registros: {currentDocument.Rows.Count}";

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No se pudo abrir el archivo.\n\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DisplayDocument()
        {
            if (currentDocument == null)
                return;

            lvDatos.BeginUpdate();

            try
            {
                lvDatos.Clear();

                foreach (string column in currentDocument.Columns)
                {
                    lvDatos.Columns.Add(column);
                }

                foreach (List<string> row in currentDocument.Rows)
                {
                    var item = new ListViewItem(
                        row.Count > 0 ? row[0] : string.Empty);

                    for (int i = 1; i < currentDocument.Columns.Count; i++)
                    {
                        string value = i < row.Count
                            ? row[i]
                            : string.Empty;

                        item.SubItems.Add(value);
                    }

                    lvDatos.Items.Add(item);
                }

                lvDatos.AutoResizeColumns(
                    ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            finally
            {
                lvDatos.EndUpdate();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (currentDocument == null)
            {
                MessageBox.Show(
                    "Primero debes abrir un archivo.",
                    "Editar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            if (lvDatos.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Selecciona un registro para editar.",
                    "Editar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            int index = lvDatos.SelectedItems[0].Index;

            List<string> row = currentDocument.Rows[index];

            // Crear una copia que será editada por el formulario
            List<string> editedRow = new List<string>(row);

            using EditRecordForm form =
                new EditRecordForm(
                    currentDocument.Columns,
                    editedRow);

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                // Reemplazar la fila por la versión editada
                currentDocument.Rows[index] = editedRow;

                DisplayDocument();

                lvDatos.Items[index].Selected = true;

                lblEstado.Text =
                    $"Archivo: {currentDocument.FileName} | " +
                    $"Formato: {currentDocument.FileType} | " +
                    $"Registros: {currentDocument.Rows.Count}";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (currentDocument == null)
            {
                MessageBox.Show(
                    "No hay ningún archivo abierto.",
                    "Guardar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            try
            {
                if (string.IsNullOrWhiteSpace(currentDocument.FilePath))
                {
                    GuardarComo();
                    return;
                }

                GuardarDocumento(currentDocument.FilePath);

                lblEstado.Text =
                    $"Guardado: {currentDocument.FileName} | " +
                    $"Registros: {currentDocument.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No se pudo guardar el archivo.\n\n{ex.Message}",
                    "Error al guardar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void GuardarDocumento(string filePath)
        {
            if (currentDocument == null)
                return;

            string extension =
                Path.GetExtension(filePath).ToLowerInvariant();

            if (extension == ".csv")
            {
                csvService.Save(currentDocument, filePath);
            }
            else if (extension == ".json")
            {
                jsonService.Save(currentDocument, filePath);
            }
            else
            {
                throw new Exception(
                    "El formato del archivo no es compatible.");
            }

            currentDocument.FilePath = filePath;
            currentDocument.FileName = Path.GetFileName(filePath);
            currentDocument.FileType =
                extension == ".csv" ? "CSV" : "JSON";
        }

        private void btnGuardarComo_Click(object sender, EventArgs e)
        {
            GuardarComo();
        }
        private void GuardarComo()
        {
            if (currentDocument == null)
            {
                MessageBox.Show(
                    "No hay ningún documento para guardar.",
                    "Guardar como",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            saveFileDialog1.Filter =
                "Archivos CSV|*.csv|" +
                "Archivos JSON|*.json";

            saveFileDialog1.FileName =
                currentDocument.FileName;

            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                GuardarDocumento(saveFileDialog1.FileName);

                lblEstado.Text =
                    $"Guardado: {currentDocument.FileName} | " +
                    $"Formato: {currentDocument.FileType} | " +
                    $"Registros: {currentDocument.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No se pudo guardar el archivo.\n\n{ex.Message}",
                    "Error al guardar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

    }
}

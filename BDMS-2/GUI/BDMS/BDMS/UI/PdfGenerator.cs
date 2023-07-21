using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

using iTextSharp.text;

using iTextSharp.text.pdf;

namespace BDMS.UI
{
    public class PdfGenerator
    {
        public static void GeneratePdfReport<T>(List<T> data)
        {
            // Create a new document
            Document document = new Document();

            // store the address of the destination at which  the file is to be stored
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.DefaultExt = "pdf";

            // Show the SaveFileDialog and get the selected file path
            DialogResult result = saveFileDialog.ShowDialog();
            string filePath = string.Empty;
            if (result == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;

            }

            // Create a new PDF writer
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

            // Open the document
            document.Open();

            Phrase phrase = new Phrase();
            phrase.Add(new Chunk("Blood Donation Management System\n\n", FontFactory.GetFont("Arial", 16, Font.BOLD)));
            // Create a data table to store the object data

            DataTable dataTable = new DataTable();

            // Get the properties of the object
            var properties = typeof(T).GetProperties();

            // Add columns to the data table based on the object properties
            foreach (var property in properties)
            {
                dataTable.Columns.Add(property.Name);
            }

            // Add rows to the data table based on the object data
            foreach (var item in data)
            {
                DataRow row = dataTable.NewRow();

                foreach (var property in properties)
                {
                    var value = property.GetValue(item);
                    row[property.Name] = value != null ? value.ToString() : string.Empty;
                }

                dataTable.Rows.Add(row);
            }

            // Create a PDF table
            PdfPTable pdfTable = new PdfPTable(dataTable.Columns.Count);

            // Set the table width to fit the page
            pdfTable.WidthPercentage = 100;

            // Add table headers
            foreach (DataColumn column in dataTable.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName));
                cell.BackgroundColor = BaseColor.LIGHT_GRAY; // Set the background color of the header cell
                cell.HorizontalAlignment = Element.ALIGN_CENTER; // Set the horizontal alignment of the header cell
                pdfTable.AddCell(cell);
            }

            // Add table rows
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(item.ToString()));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER; // Set the horizontal alignment of the header cell
                    pdfTable.AddCell(cell);
                }
            }



            // Add the table to the document
            document.Add(pdfTable);

            // Close the document and the writer
            document.Close();
            writer.Close();
        }
    }
}

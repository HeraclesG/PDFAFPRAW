using System.Diagnostics;
using System;
using System.IO;
namespace pdfafp
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //PDFTOAFP.CreateFont(@"D:\_Zombie_\_pro\pdf2afp\afps\times\CZTNN00.OLN");
            string src_file = lnFile.Text;
            if (string.IsNullOrEmpty(src_file))
            {
                MessageBox.Show("Please Load File", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Debug.WriteLine($"{src_file}");
            PDFTOAFP.CreateAFPFromSource(src_file);
            //PDFTOAFP.CovertAFP(pdf_file);
            //PDFTOAFP.ExtractTextElements(pdf_file);
            //PDFTOAFP.ParsePDFElements(pdf_file);
            //PDFTOAFP.CreateAFPFileWithImage(pdf_file);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the properties of the OpenFileDialog
            openFileDialog.Title = "Select a File";
            openFileDialog.Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";
            openFileDialog.InitialDirectory = @""; // Set the initial directory to the C:\ drive

            // Show the dialog and check if the user clicked "OK"
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file name
                string selectedFileName = openFileDialog.FileName;

                // Display the selected file name (for example, in a label)
                lnFile.Text = selectedFileName;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

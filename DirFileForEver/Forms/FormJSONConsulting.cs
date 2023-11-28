using DirFileForEver.DataClasses;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirFileForEver
{
    public partial class FormJSONConsulting : Form
    {
        List<DirFile> dirFilesFromJson;


        public FormJSONConsulting()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Abre el buscador para seleccionar un archivo JSON y lo muestra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchFile_Click(object sender, EventArgs e)
        {
            DirectoryInfo dirToLoad = new DirectoryInfo(@"..\..\JSON\");
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = dirToLoad.FullName;
            openFile.Filter = "Ficheros JSON (*.json)|*.json";


            if(openFile.ShowDialog() == DialogResult.OK)
            {
                ExtractingAndShowingJSON(openFile);
            }
        }


        /// <summary>
        /// Ordena el grid dependiendo del cabecero en el que se clica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvExtractedJson_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex == -1)
            {

                switch (e.ColumnIndex)
                {
                    case 0:
                        dirFilesFromJson = dirFilesFromJson.OrderBy(x => x.Name).ToList();
                        break;
                    case 1:
                        dirFilesFromJson = dirFilesFromJson.OrderBy(x => x.Size).ToList();
                        break;
                    case 2:
                        dirFilesFromJson = dirFilesFromJson.OrderBy(x => x.Date).ToList();
                        break;
                    case 3:
                        dirFilesFromJson = dirFilesFromJson.OrderBy(x => x.Type).ToList();
                        break;
                }
                dgvExtractedJson.DataSource = null;
                dgvExtractedJson.DataSource = dirFilesFromJson;

            }
        }


        /// <summary>
        /// Extrae el archivo JSON seleccionado y lo muestra en el grid
        /// </summary>
        /// <param name="openFile"></param>
        private void ExtractingAndShowingJSON(OpenFileDialog openFile)
        {
            tbFileURL.Text = openFile.FileName;

            try
            {
                JArray jArrayDirFiles = JArray.Parse(File.ReadAllText(tbFileURL.Text));

                dirFilesFromJson = jArrayDirFiles.ToObject<List<DirFile>>();
                
                    dgvExtractedJson.DataSource = null;
                    dgvExtractedJson.DataSource = dirFilesFromJson;

            }
            catch (Newtonsoft.Json.JsonReaderException ex)
            {
                MessageBox.Show("Algo malo pasa con ese JSON. No es posible abrirlo.", "Error");
            }
        }
    }
}

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

namespace DirFileForEver.Forms
{
    public partial class FormSavingJSON : Form
    {
        JArray dirFileArray;
        DirectoryInfo dirToSave;
        public FormSavingJSON(JArray dirFileArray)
        {
            InitializeComponent();
            this.dirFileArray = dirFileArray;
            dirToSave = new DirectoryInfo(@"..\..\JSON\");

        }


        /// <summary>
        /// Chequea si el texto introducido es correcto y guarda o sobreescribe el fichero json
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool exist = false;

            if (tbName.Text != "")
            {
                exist = CheckingIfFileExist(exist);

                SavingJSON(exist);
            }
            else
            {
                MessageBox.Show("El campo de texto no puede estar vacío.", "Error");
            }
        }


        /// <summary>
        /// Guarda el archivo json o sobreescribe uno ya existente
        /// </summary>
        /// <param name="exist"></param>
        private void SavingJSON(bool exist)
        {
            if (!exist)
            {
                SaveAndClose();
            }
            else
            {
                showingConfirmationAndOverwrite();
            }
        }


        /// <summary>
        /// Muestra un diálogo de confirmación y sobreescribe el archivo
        /// </summary>
        /// <param name="dirFileToDelete">El archivo DirFile que guarda los datos del archivo</param>
        private void showingConfirmationAndOverwrite()
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(
                "Ya existe un archivo con ese nombre. Quieres sobreescribirlo?",
                "Confirmación requerida",
                buttons);

            if (result == DialogResult.Yes)
            {
                
                SaveAndClose();
            }
        }


        /// <summary>
        /// Guarda el archivo json y cierra el diálogo de guardado
        /// </summary>
        private void SaveAndClose()
        {
            File.WriteAllText(
                    "..\\..\\JSON\\" + tbName.Text.Trim() + ".json",
                    dirFileArray.ToString());

            this.Close();
            MessageBox.Show("Archivo JSON guardado en la carpeta JSON del proyecto.", "Guardado con éxito");
        }


        /// <summary>
        /// Chequea si existe ya un fichero con ese nombre
        /// </summary>
        /// <returns>El booleano que nos indica si ya existe</returns>
        private bool CheckingIfFileExist(bool exist)
        {
            String fileToWrite = tbName.Text.Trim() + ".json";

            foreach (FileInfo file in dirToSave.GetFiles())
            {

                if (file.Name.Trim().Equals(fileToWrite))
                {
                    exist = true;
                }
            }
            return exist;
        }


        /// <summary>
        /// Al pulsar la tecla enter estando en el textBox, se pulsará el botón guardar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                btnSave.PerformClick();
            }
        }
    }
}

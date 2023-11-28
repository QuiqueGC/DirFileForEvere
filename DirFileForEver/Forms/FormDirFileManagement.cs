using DirFileForEver.DataClasses;
using DirFileForEver.Forms;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirFileForEver
{
    public partial class FormDirFileManagement : Form
    {
        DirectoryInfo actualDir;
        List<DirFile> dirFilesList = new List<DirFile>();



        public FormDirFileManagement()
        {
            InitializeComponent();
            cbFilter.SelectedIndex = 0;
        }


        /// <summary>
        /// Abre el formulario para consultar JSONs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsult_Click(object sender, EventArgs e)
        {
            FormJSONConsulting formJSONConsulting = new FormJSONConsulting();
            formJSONConsulting.Show();
        }


        /// <summary>
        /// Sale de la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Abre el diálogo para explorar entre directorios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog foldBrowDialog = new FolderBrowserDialog();
            DialogResult result = foldBrowDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                tbDirURL.Text = foldBrowDialog.SelectedPath;

                FilteringDependingOnSelection();

                OrderingSelection();

                WrittingDataAtDataGridView();
            }
        }


        /// <summary>
        /// invierte el orden de la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chbInvertingOrder_CheckedChanged(object sender, EventArgs e)
        {
            dirFilesList.Reverse();
            WrittingDataAtDataGridView();
        }


        /// <summary>
        /// Ordena la lista por los nombres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnName_CheckedChanged(object sender, EventArgs e)
        {
            dirFilesList = dirFilesList.OrderBy(x => x.Name).ToList();
            WrittingDataAtDataGridView();
        }


        /// <summary>
        /// Ordena la lista por el tipo de archivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnType_CheckedChanged(object sender, EventArgs e)
        {
            dirFilesList = dirFilesList.OrderBy(x => x.Type).ToList();
            WrittingDataAtDataGridView();
        }


        /// <summary>
        /// Ordena la lista por fecha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnDate_CheckedChanged(object sender, EventArgs e)
        {
            dirFilesList = dirFilesList.OrderBy(x => x.Date).ToList();
            WrittingDataAtDataGridView();
        }


        /// <summary>
        /// Ordena la lista por tamaño
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnSize_CheckedChanged(object sender, EventArgs e)
        {
            dirFilesList = dirFilesList.OrderBy(x => x.Size).ToList();
            WrittingDataAtDataGridView();
        }


        /// <summary>
        /// Establece qué elementos se verán de la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbDirURL.Text != "")
            {
                FilteringDependingOnSelection();
            }

        }


        /// <summary>
        /// Muestra los elementos dependiendo de la fecha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpFilter_ValueChanged(object sender, EventArgs e)
        {
            FilteringByDate();
        }

        
        /// <summary>
        /// Accede al diálogo de creación de carpeta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddDir_Click(object sender, EventArgs e)
        {
            if (actualDir != null)
            {
                FormCreateOrUpdate formCreateDir
                = new FormCreateOrUpdate(
                    null,
                    "Crear directorio",
                    actualDir,
                    0,
                    this);

                formCreateDir.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debes escoger antes una ruta en la que añadirla.", "Error");
            }
        }

        /// <summary>
        /// Accede al diálogo de creación de fichero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddFile_Click(object sender, EventArgs e)
        {
            if (actualDir != null)
            {
                FormCreateOrUpdate formCreateDir
                = new FormCreateOrUpdate(
                    null,
                    "Crear fichero",
                    actualDir,
                    1,
                    this);

                formCreateDir.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debes escoger antes una ruta en la que añadirla.", "Error");
            }
        }


        /// <summary>
        /// Chequea si hay un elemento seleccionado y lo borra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDirFiles.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDirFiles.CurrentRow;
                DirFile dirFileToDelete = (DirFile)selectedRow.DataBoundItem;

                deletingElement(dirFileToDelete);

                FilteringDependingOnSelection();
                OrderingSelection();
                WrittingDataAtDataGridView();
            }
            else
            {
                MessageBox.Show("Debes escoger el elemento que quieres borrar.", "Error");
            }
        }


        /// <summary>
        /// Modifica el elemento seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dgvDirFiles.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDirFiles.CurrentRow;
                DirFile dirFileToChange = (DirFile)selectedRow.DataBoundItem;

                switch (dirFileToChange.IsDirectory)
                {
                    case true:
                        goingToDirModifyForm(dirFileToChange);
                        break;
                    case false:
                        goingToFileModifyForm(dirFileToChange);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Debes escoger el elemento que quieres modificar.", "Error");
            }
        }


        /// <summary>
        /// Hace que se borre la fila seleccionada con el botón suprimir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDirFiles_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvDirFiles.Rows.Count > 0 && e.KeyValue == (char)Keys.Delete)
            {
                btnDelete.PerformClick();
            }
        }


        /// <summary>
        /// Accede al panel para escribir el nombre del archivo Json y guardarlo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (actualDir != null && dirFilesList.Count > 0)
            {
                JArray dirFileArray = (JArray)JToken.FromObject(dirFilesList);

                FormSavingJSON formSavingJSON = new FormSavingJSON(dirFileArray);

                formSavingJSON.ShowDialog();
            }
            else if (actualDir == null)
            {
                MessageBox.Show("Debes escoger primero una carpeta de origen.", "Error");
            }
            else
            {
                MessageBox.Show("La carpeta está vacía. No hay nada que puedas guardar.", "Error");
            }
        }


        /// <summary>
        /// Chequea los controles de orden de la lista y la ordena
        /// al seleccionarlos
        /// </summary>
        public void OrderingSelection()
        {
            if (rbtnName.Checked)
            {
                dirFilesList = dirFilesList.OrderBy(x => x.Name).ToList();
            }
            else if (rbtnDate.Checked)
            {
                dirFilesList = dirFilesList.OrderBy(x => x.Date).ToList();
            }
            else if (rbtnType.Checked)
            {
                dirFilesList = dirFilesList.OrderBy(x => x.Type).ToList();
            }
            else if (rbtnSize.Checked)
            {
                dirFilesList = dirFilesList.OrderBy(x => x.Size).ToList();
            }

            if (chbInvertingOrder.Checked)
            {
                dirFilesList.Reverse();
            }
        }


        /// <summary>
        /// Rellena el dataGridView con la lista creada de DirFile
        /// </summary>
        public void WrittingDataAtDataGridView()
        {
            dgvDirFiles.DataSource = null;

            //El if que me ha salvado de la desesperación. Lo explico:
            //Si añades una lista vacía al dataGridView, parece que
            //hace un indexOutOfBounds cuando clicas en ella después,
            //(si has creado un elemento nuevo en una carpeta vacía)
            //por eso hay que chequear si tiene
            //al menos un elemento a la hora de introducirla
            //por primera vez.
            //Aleluya!!!
            if (dirFilesList.Count > 0)
            {
                dgvDirFiles.DataSource = dirFilesList;
            }

            //pongo esta línea a ver si evito el error
            dgvDirFiles.ClearSelection();
        }


        /// <summary>
        /// Crea la lista que mostraremos en pantalla
        /// </summary>
        private void CreatingList()
        {
            actualDir = new DirectoryInfo(tbDirURL.Text);

            dirFilesList.Clear();

            AddingDirsToList();

            AddingFilesToList();
        }


        /// <summary>
        /// Añade los directorios a la lista
        /// </summary>
        private void AddingDirsToList()
        {
            foreach (DirectoryInfo subDir in actualDir.GetDirectories())
            {
                DirFile dirFile = new DirFile();
                dirFile.WrittingDirData(subDir);

                dirFilesList.Add(dirFile);
            }
        }


        /// <summary>
        /// Añade los ficheros a la lista
        /// </summary>
        private void AddingFilesToList()
        {
            foreach (FileInfo file in actualDir.GetFiles())
            {
                DirFile dirFile = new DirFile();

                dirFile.WrittingFileData(file);

                dirFilesList.Add(dirFile);
            }
        }


        /// <summary>
        /// Filtra la lista dependiendo de la elección del comboBox
        /// </summary>
        public void FilteringDependingOnSelection()
        {
            switch (cbFilter.SelectedIndex)
            {
                case 0:
                    CreatingList();
                    OrderingSelection();
                    WrittingDataAtDataGridView();
                    break;
                case 1:
                    ShowOnlyDirs();
                    break;
                case 2:
                    ShowOnlyFiles();
                    break;
                case 3:
                    ShowByDate();
                    break;
            }
        }


        /// <summary>
        /// Muestra sólo los directorios
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void ShowOnlyDirs()
        {
            dtpFilter.Visible = false;

            CreatingList();

            dirFilesList =
                (from dir in dirFilesList
                 where dir.IsDirectory
                 select dir).ToList();

            OrderingSelection();

            WrittingDataAtDataGridView();
        }


        /// <summary>
        /// Muestra sólo los ficheros
        /// </summary>
        private void ShowOnlyFiles()
        {
            dtpFilter.Visible = false;

            CreatingList();

            dirFilesList =
                (from dir in dirFilesList
                 where !dir.IsDirectory
                 select dir).ToList();

            OrderingSelection();

            WrittingDataAtDataGridView();
        }


        /// <summary>
        /// Muestra el cuadro de fechas para escoger una
        /// </summary>
        private void ShowByDate()
        {
            dtpFilter.Visible = true;
            FilteringByDate();
        }


        /// <summary>
        /// Filtra los elementos anteriores a la fecha señalada
        /// </summary>
        private void FilteringByDate()
        {
            CreatingList();

            dirFilesList =
                (from dir in dirFilesList
                 where dir.Date < dtpFilter.Value
                 select dir).ToList();

            OrderingSelection();

            WrittingDataAtDataGridView();
        }


        /// <summary>
        /// Chequea el tipo de elemento seleccionado y lo borra
        /// </summary>
        /// <param name="dirFileToDelete">El objeto de tipo DirFile para borrar</param>
        private void deletingElement(DirFile dirFileToDelete)
        {
            if (dirFileToDelete.IsDirectory)
            {
                deletingDir(dirFileToDelete);
            }
            else
            {
                File.Delete(dirFileToDelete.FullName);
            }
        }


        /// <summary>
        /// Borra la carpeta seleccionada
        /// </summary>
        /// <param name="dirFileToDelete">El archivo DirFile que guarda los datos del archivo</param>
        private void deletingDir(DirFile dirFileToDelete)
        {
            bool isEmpty = Directory.EnumerateFiles(dirFileToDelete.FullName).LongCount() == 0
                    && Directory.EnumerateDirectories(dirFileToDelete.FullName).LongCount() == 0;

            if (isEmpty)
            {
                Directory.Delete(dirFileToDelete.FullName);
            }
            else
            {
                showingConfirmationAndDelete(dirFileToDelete);
            }
        }


        /// <summary>
        /// Muestra un diálogo de confirmación y borra la carpeta en caso de aceptar
        /// </summary>
        /// <param name="dirFileToDelete">El archivo DirFile que guarda los datos del archivo</param>
        private void showingConfirmationAndDelete(DirFile dirFileToDelete)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(
                "La carpeta no está vacía. Estás seguro de querer borrarla?",
                "Confirmación requerida",
                buttons);

            if (result == DialogResult.Yes)
            {
                Directory.Delete(dirFileToDelete.FullName, true);
            }
        }


        /// <summary>
        /// Abre el diálogo de modificación de fichero
        /// </summary>
        /// <param name="dirFileToChange">El objeto de tipo DirFile con los datos</param>
        private void goingToFileModifyForm(DirFile dirFileToChange)
        {
            FormCreateOrUpdate formCreateDir
                = new FormCreateOrUpdate(
                    dirFileToChange.Name,
                    "Modificar archivo",
                    actualDir,
                    3,
                    this);

            formCreateDir.ShowDialog();
        }


        /// <summary>
        /// Abre el diálogo de modificación de directorio
        /// </summary>
        /// <param name="dirFileToChange">El objeto de tipo DirFile con los datos</param>
        private void goingToDirModifyForm(DirFile dirFileToChange)
        {
            FormCreateOrUpdate formCreateDir
                = new FormCreateOrUpdate(
                    dirFileToChange.Name,
                    "Modificar carpeta",
                    actualDir,
                    2,
                    this);

            formCreateDir.ShowDialog();
        }
    }

}

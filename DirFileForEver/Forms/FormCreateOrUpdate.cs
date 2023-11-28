using DirFileForEver.DataClasses;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace DirFileForEver.Forms
{
    public partial class FormCreateOrUpdate : Form
    {
        String nameToChange;
        DirectoryInfo actualDir;
        int dialogType;
        FormDirFileManagement mainForm;


        public FormCreateOrUpdate(string nameToChange, string formTitle, DirectoryInfo actualDir, int dialogType, FormDirFileManagement mainForm)
        {
            InitializeComponent();

            this.nameToChange = nameToChange == null ?"" : nameToChange.Trim();
            this.actualDir = actualDir;
            this.dialogType = dialogType;
            tbName.Text = nameToChange == null ? "" : nameToChange.Trim();
            this.mainForm = mainForm;
            this.Text = formTitle;
        }


        /// <summary>
        /// Crea o modifica un directorio o fichero (dependiendo del int dialogType)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccept_Click(object sender, EventArgs e)
        {
            bool exist = false;

            if (tbName.Text != "")
            {
                bool changed = !nameToChange.Equals(tbName.Text);

                exist = CheckingIfDirExist(exist);
                exist = CheckingIfFileExist(exist);

                CreatingOrModifyingDirFile(changed, exist);
            }
            else
            {
                MessageBox.Show("El campo de texto no puede estar vacío.", "Error");
            }
        }


        /// <summary>
        /// Chequea si existe ya un directorio con ese nombre
        /// </summary>
        /// <returns>El booleano que nos indica si ya existe</returns>
        private bool CheckingIfDirExist(bool exist)
        {
            foreach (DirectoryInfo subDir in actualDir.GetDirectories())
            {
                if (subDir.Name.Trim().Equals(tbName.Text.Trim()))
                {
                    exist = true;
                }
            }
            return exist;
        }


        /// <summary>
        /// Chequea si existe ya un fichero con ese nombre
        /// </summary>
        /// <returns>El booleano que nos indica si ya existe</returns>
        private bool CheckingIfFileExist(bool exist)
        {
            foreach (FileInfo file in actualDir.GetFiles())
            {
                if (file.Name.Trim().Equals(tbName.Text.Trim()))
                {
                    exist = true;
                }
            }
            return exist;
        }


        /// <summary>
        /// modifica el directorio/fichero o muestra un mensaje de error
        /// </summary>
        /// <param name="changed">Booleano que indica si ha sido cambiado el nombre</param>
        /// <param name="exist">Booleano que indica si existe otro archivo con el mismo nombre</param>
        private void CreatingOrModifyingDirFile(bool changed, bool exist)
        {
            if (changed && !exist)
            {
                ChoosingOptionToDo();
                
                mainForm.FilteringDependingOnSelection();

                mainForm.OrderingSelection();

                mainForm.WrittingDataAtDataGridView();
                
                this.Close();
            }
            else if (!changed)
            {
                MessageBox.Show("Para poder cambiarlo, deberías escribir algo diferente.", "Error");
            }
            else
            {
                MessageBox.Show("Alguien se te adelantó! Ya existe un archivo con ese nombre.", "Error");
            }
        }


        /// <summary>
        /// Escoge la opción que se realizará en base al int dialogType
        /// </summary>
        private void ChoosingOptionToDo()
        {
            switch (dialogType)
            {
                case 0:
                    Directory.CreateDirectory(actualDir.FullName + "\\" + tbName.Text.Trim());
                    break;
                case 1:
                    FileStream file = File.Create(actualDir.FullName + "\\" + tbName.Text.Trim());
                    file.Close();
                    break;
                case 2:
                    Directory.Move(
                    actualDir.FullName + "\\" + nameToChange.Trim(),
                    actualDir.FullName + "\\" + tbName.Text.Trim());
                    break;
                case 3:
                    File.Move(
                    actualDir.FullName + "\\" + nameToChange.Trim(),
                    actualDir.FullName + "\\" + tbName.Text.Trim());
                    break;
            }
        }


        /// <summary>
        /// Al pulsar la tecla enter estando en el textBox, se pulsará el botón aceptar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == (char)Keys.Enter)
            {
                btnAccept.PerformClick();
            }
        }
    }
}

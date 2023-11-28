namespace DirFileForEver
{
    partial class FormDirFileManagement
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbDirFileManagement = new System.Windows.Forms.GroupBox();
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnConsult = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnAddDir = new System.Windows.Forms.Button();
            this.gbList = new System.Windows.Forms.GroupBox();
            this.dgvDirFiles = new System.Windows.Forms.DataGridView();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.dtpFilter = new System.Windows.Forms.DateTimePicker();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.gbOrderBy = new System.Windows.Forms.GroupBox();
            this.chbInvertingOrder = new System.Windows.Forms.CheckBox();
            this.rbtnSize = new System.Windows.Forms.RadioButton();
            this.rbtnType = new System.Windows.Forms.RadioButton();
            this.rbtnDate = new System.Windows.Forms.RadioButton();
            this.rbtnName = new System.Windows.Forms.RadioButton();
            this.gbFolderSelection = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbDirURL = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbDirFileManagement.SuspendLayout();
            this.gbActions.SuspendLayout();
            this.gbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirFiles)).BeginInit();
            this.gbFilter.SuspendLayout();
            this.gbOrderBy.SuspendLayout();
            this.gbFolderSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dirFileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDirFileManagement
            // 
            this.gbDirFileManagement.Controls.Add(this.gbActions);
            this.gbDirFileManagement.Controls.Add(this.gbList);
            this.gbDirFileManagement.Controls.Add(this.gbFilter);
            this.gbDirFileManagement.Controls.Add(this.gbOrderBy);
            this.gbDirFileManagement.Controls.Add(this.gbFolderSelection);
            this.gbDirFileManagement.Location = new System.Drawing.Point(16, 15);
            this.gbDirFileManagement.Margin = new System.Windows.Forms.Padding(4);
            this.gbDirFileManagement.Name = "gbDirFileManagement";
            this.gbDirFileManagement.Padding = new System.Windows.Forms.Padding(4);
            this.gbDirFileManagement.Size = new System.Drawing.Size(1035, 544);
            this.gbDirFileManagement.TabIndex = 0;
            this.gbDirFileManagement.TabStop = false;
            this.gbDirFileManagement.Text = "Gestión de directorios y archivos";
            // 
            // gbActions
            // 
            this.gbActions.Controls.Add(this.btnSave);
            this.gbActions.Controls.Add(this.btnDelete);
            this.gbActions.Controls.Add(this.btnModify);
            this.gbActions.Controls.Add(this.btnConsult);
            this.gbActions.Controls.Add(this.btnAddFile);
            this.gbActions.Controls.Add(this.btnAddDir);
            this.gbActions.Location = new System.Drawing.Point(31, 346);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(325, 191);
            this.gbActions.TabIndex = 3;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "Acciones";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(7, 22);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Guardar lista";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(139, 148);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(179, 28);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Borrar Seleccionado";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(139, 112);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(179, 28);
            this.btnModify.TabIndex = 4;
            this.btnModify.Text = "Modificar seleccionado";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnConsult
            // 
            this.btnConsult.Location = new System.Drawing.Point(8, 58);
            this.btnConsult.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(150, 28);
            this.btnConsult.TabIndex = 1;
            this.btnConsult.Text = "Consultar guardados";
            this.btnConsult.UseVisualStyleBackColor = true;
            this.btnConsult.Click += new System.EventHandler(this.btnConsult_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(193, 58);
            this.btnAddFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(125, 28);
            this.btnAddFile.TabIndex = 3;
            this.btnAddFile.Text = "Añadir archivo";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnAddDir
            // 
            this.btnAddDir.Location = new System.Drawing.Point(193, 22);
            this.btnAddDir.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDir.Name = "btnAddDir";
            this.btnAddDir.Size = new System.Drawing.Size(125, 28);
            this.btnAddDir.TabIndex = 2;
            this.btnAddDir.Text = "Añadir directorio";
            this.btnAddDir.UseVisualStyleBackColor = true;
            this.btnAddDir.Click += new System.EventHandler(this.btnAddDir_Click);
            // 
            // gbList
            // 
            this.gbList.Controls.Add(this.dgvDirFiles);
            this.gbList.Location = new System.Drawing.Point(368, 220);
            this.gbList.Margin = new System.Windows.Forms.Padding(4);
            this.gbList.Name = "gbList";
            this.gbList.Padding = new System.Windows.Forms.Padding(4);
            this.gbList.Size = new System.Drawing.Size(646, 317);
            this.gbList.TabIndex = 4;
            this.gbList.TabStop = false;
            this.gbList.Text = "Lista";
            // 
            // dgvDirFiles
            // 
            this.dgvDirFiles.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvDirFiles.AllowUserToAddRows = false;
            this.dgvDirFiles.AllowUserToDeleteRows = false;
            this.dgvDirFiles.AutoGenerateColumns = false;
            this.dgvDirFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dgvDirFiles.DataSource = this.dirFileBindingSource;
            this.dgvDirFiles.Location = new System.Drawing.Point(26, 23);
            this.dgvDirFiles.MultiSelect = false;
            this.dgvDirFiles.Name = "dgvDirFiles";
            this.dgvDirFiles.ReadOnly = true;
            this.dgvDirFiles.RowHeadersVisible = false;
            this.dgvDirFiles.RowHeadersWidth = 51;
            this.dgvDirFiles.RowTemplate.Height = 24;
            this.dgvDirFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDirFiles.Size = new System.Drawing.Size(602, 276);
            this.dgvDirFiles.TabIndex = 0;
            this.dgvDirFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDirFiles_KeyDown);
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.dtpFilter);
            this.gbFilter.Controls.Add(this.cbFilter);
            this.gbFilter.Location = new System.Drawing.Point(31, 220);
            this.gbFilter.Margin = new System.Windows.Forms.Padding(4);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Padding = new System.Windows.Forms.Padding(4);
            this.gbFilter.Size = new System.Drawing.Size(329, 118);
            this.gbFilter.TabIndex = 2;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filtro";
            // 
            // dtpFilter
            // 
            this.dtpFilter.Location = new System.Drawing.Point(8, 70);
            this.dtpFilter.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFilter.Name = "dtpFilter";
            this.dtpFilter.Size = new System.Drawing.Size(300, 22);
            this.dtpFilter.TabIndex = 3;
            this.dtpFilter.Visible = false;
            this.dtpFilter.ValueChanged += new System.EventHandler(this.dtpFilter_ValueChanged);
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Ningún filtro",
            "Directorios",
            "Archivos",
            "Fecha"});
            this.cbFilter.Location = new System.Drawing.Point(8, 23);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(249, 24);
            this.cbFilter.TabIndex = 0;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // gbOrderBy
            // 
            this.gbOrderBy.Controls.Add(this.chbInvertingOrder);
            this.gbOrderBy.Controls.Add(this.rbtnSize);
            this.gbOrderBy.Controls.Add(this.rbtnType);
            this.gbOrderBy.Controls.Add(this.rbtnDate);
            this.gbOrderBy.Controls.Add(this.rbtnName);
            this.gbOrderBy.Location = new System.Drawing.Point(31, 135);
            this.gbOrderBy.Margin = new System.Windows.Forms.Padding(4);
            this.gbOrderBy.Name = "gbOrderBy";
            this.gbOrderBy.Padding = new System.Windows.Forms.Padding(4);
            this.gbOrderBy.Size = new System.Drawing.Size(983, 73);
            this.gbOrderBy.TabIndex = 1;
            this.gbOrderBy.TabStop = false;
            this.gbOrderBy.Text = "Ordenar por";
            // 
            // chbInvertingOrder
            // 
            this.chbInvertingOrder.AutoSize = true;
            this.chbInvertingOrder.Location = new System.Drawing.Point(690, 31);
            this.chbInvertingOrder.Margin = new System.Windows.Forms.Padding(4);
            this.chbInvertingOrder.Name = "chbInvertingOrder";
            this.chbInvertingOrder.Size = new System.Drawing.Size(106, 20);
            this.chbInvertingOrder.TabIndex = 4;
            this.chbInvertingOrder.Text = "Invertir orden";
            this.chbInvertingOrder.UseVisualStyleBackColor = true;
            this.chbInvertingOrder.CheckedChanged += new System.EventHandler(this.chbInvertingOrder_CheckedChanged);
            // 
            // rbtnSize
            // 
            this.rbtnSize.AutoSize = true;
            this.rbtnSize.Location = new System.Drawing.Point(500, 30);
            this.rbtnSize.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnSize.Name = "rbtnSize";
            this.rbtnSize.Size = new System.Drawing.Size(79, 20);
            this.rbtnSize.TabIndex = 3;
            this.rbtnSize.TabStop = true;
            this.rbtnSize.Text = "Tamaño";
            this.rbtnSize.UseVisualStyleBackColor = true;
            this.rbtnSize.CheckedChanged += new System.EventHandler(this.rbtnSize_CheckedChanged);
            // 
            // rbtnType
            // 
            this.rbtnType.AutoSize = true;
            this.rbtnType.Location = new System.Drawing.Point(337, 31);
            this.rbtnType.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnType.Name = "rbtnType";
            this.rbtnType.Size = new System.Drawing.Size(56, 20);
            this.rbtnType.TabIndex = 2;
            this.rbtnType.TabStop = true;
            this.rbtnType.Text = "Tipo";
            this.rbtnType.UseVisualStyleBackColor = true;
            this.rbtnType.CheckedChanged += new System.EventHandler(this.rbtnType_CheckedChanged);
            // 
            // rbtnDate
            // 
            this.rbtnDate.AutoSize = true;
            this.rbtnDate.Location = new System.Drawing.Point(193, 31);
            this.rbtnDate.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnDate.Name = "rbtnDate";
            this.rbtnDate.Size = new System.Drawing.Size(66, 20);
            this.rbtnDate.TabIndex = 1;
            this.rbtnDate.TabStop = true;
            this.rbtnDate.Text = "Fecha";
            this.rbtnDate.UseVisualStyleBackColor = true;
            this.rbtnDate.CheckedChanged += new System.EventHandler(this.rbtnDate_CheckedChanged);
            // 
            // rbtnName
            // 
            this.rbtnName.AutoSize = true;
            this.rbtnName.Location = new System.Drawing.Point(37, 28);
            this.rbtnName.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnName.Name = "rbtnName";
            this.rbtnName.Size = new System.Drawing.Size(77, 20);
            this.rbtnName.TabIndex = 0;
            this.rbtnName.TabStop = true;
            this.rbtnName.Text = "Nombre";
            this.rbtnName.UseVisualStyleBackColor = true;
            this.rbtnName.CheckedChanged += new System.EventHandler(this.rbtnName_CheckedChanged);
            // 
            // gbFolderSelection
            // 
            this.gbFolderSelection.Controls.Add(this.btnSearch);
            this.gbFolderSelection.Controls.Add(this.tbDirURL);
            this.gbFolderSelection.Location = new System.Drawing.Point(31, 38);
            this.gbFolderSelection.Margin = new System.Windows.Forms.Padding(4);
            this.gbFolderSelection.Name = "gbFolderSelection";
            this.gbFolderSelection.Padding = new System.Windows.Forms.Padding(4);
            this.gbFolderSelection.Size = new System.Drawing.Size(983, 86);
            this.gbFolderSelection.TabIndex = 0;
            this.gbFolderSelection.TabStop = false;
            this.gbFolderSelection.Text = "Selección de carpeta origen";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(640, 34);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(156, 25);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Explorar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbDirURL
            // 
            this.tbDirURL.Location = new System.Drawing.Point(84, 34);
            this.tbDirURL.Margin = new System.Windows.Forms.Padding(4);
            this.tbDirURL.Name = "tbDirURL";
            this.tbDirURL.ReadOnly = true;
            this.tbDirURL.Size = new System.Drawing.Size(441, 22);
            this.tbDirURL.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(956, 567);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 28);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Tamaño";
            this.sizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sizeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 74;
            // 
            // dirFileBindingSource
            // 
            this.dirFileBindingSource.DataSource = typeof(DirFileForEver.DataClasses.DirFile);
            // 
            // FormDirFileManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 602);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbDirFileManagement);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDirFileManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DirFile for ever";
            this.gbDirFileManagement.ResumeLayout(false);
            this.gbActions.ResumeLayout(false);
            this.gbList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirFiles)).EndInit();
            this.gbFilter.ResumeLayout(false);
            this.gbOrderBy.ResumeLayout(false);
            this.gbOrderBy.PerformLayout();
            this.gbFolderSelection.ResumeLayout(false);
            this.gbFolderSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dirFileBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDirFileManagement;
        private System.Windows.Forms.GroupBox gbFolderSelection;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbDirURL;
        private System.Windows.Forms.GroupBox gbOrderBy;
        private System.Windows.Forms.RadioButton rbtnSize;
        private System.Windows.Forms.RadioButton rbtnType;
        private System.Windows.Forms.RadioButton rbtnDate;
        private System.Windows.Forms.RadioButton rbtnName;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.CheckBox chbInvertingOrder;
        private System.Windows.Forms.DateTimePicker dtpFilter;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Button btnAddDir;
        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnConsult;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.BindingSource dirFileBindingSource;
        private System.Windows.Forms.DataGridView dgvDirFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gbActions;
    }
}


namespace DirFileForEver
{
    partial class FormJSONConsulting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gpLoadInformation = new System.Windows.Forms.GroupBox();
            this.gbList = new System.Windows.Forms.GroupBox();
            this.gbFileSelection = new System.Windows.Forms.GroupBox();
            this.btnSearchFile = new System.Windows.Forms.Button();
            this.tbFileURL = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvExtractedJson = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gpLoadInformation.SuspendLayout();
            this.gbList.SuspendLayout();
            this.gbFileSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtractedJson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dirFileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gpLoadInformation
            // 
            this.gpLoadInformation.Controls.Add(this.gbList);
            this.gpLoadInformation.Controls.Add(this.gbFileSelection);
            this.gpLoadInformation.Location = new System.Drawing.Point(29, 25);
            this.gpLoadInformation.Margin = new System.Windows.Forms.Padding(4);
            this.gpLoadInformation.Name = "gpLoadInformation";
            this.gpLoadInformation.Padding = new System.Windows.Forms.Padding(4);
            this.gpLoadInformation.Size = new System.Drawing.Size(860, 503);
            this.gpLoadInformation.TabIndex = 0;
            this.gpLoadInformation.TabStop = false;
            this.gpLoadInformation.Text = "Cargar información";
            // 
            // gbList
            // 
            this.gbList.Controls.Add(this.dgvExtractedJson);
            this.gbList.Location = new System.Drawing.Point(28, 119);
            this.gbList.Margin = new System.Windows.Forms.Padding(4);
            this.gbList.Name = "gbList";
            this.gbList.Padding = new System.Windows.Forms.Padding(4);
            this.gbList.Size = new System.Drawing.Size(824, 364);
            this.gbList.TabIndex = 1;
            this.gbList.TabStop = false;
            this.gbList.Text = "Lista guardada";
            // 
            // gbFileSelection
            // 
            this.gbFileSelection.Controls.Add(this.btnSearchFile);
            this.gbFileSelection.Controls.Add(this.tbFileURL);
            this.gbFileSelection.Location = new System.Drawing.Point(27, 38);
            this.gbFileSelection.Margin = new System.Windows.Forms.Padding(4);
            this.gbFileSelection.Name = "gbFileSelection";
            this.gbFileSelection.Padding = new System.Windows.Forms.Padding(4);
            this.gbFileSelection.Size = new System.Drawing.Size(825, 74);
            this.gbFileSelection.TabIndex = 0;
            this.gbFileSelection.TabStop = false;
            this.gbFileSelection.Text = "Selección de archivo";
            // 
            // btnSearchFile
            // 
            this.btnSearchFile.Location = new System.Drawing.Point(663, 31);
            this.btnSearchFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchFile.Name = "btnSearchFile";
            this.btnSearchFile.Size = new System.Drawing.Size(137, 28);
            this.btnSearchFile.TabIndex = 1;
            this.btnSearchFile.Text = "Explorar";
            this.btnSearchFile.UseVisualStyleBackColor = true;
            this.btnSearchFile.Click += new System.EventHandler(this.btnSearchFile_Click);
            // 
            // tbFileURL
            // 
            this.tbFileURL.Location = new System.Drawing.Point(24, 31);
            this.tbFileURL.Margin = new System.Windows.Forms.Padding(4);
            this.tbFileURL.Name = "tbFileURL";
            this.tbFileURL.ReadOnly = true;
            this.tbFileURL.Size = new System.Drawing.Size(503, 22);
            this.tbFileURL.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(789, 541);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Volver";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvExtractedJson
            // 
            this.dgvExtractedJson.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvExtractedJson.AllowUserToAddRows = false;
            this.dgvExtractedJson.AllowUserToDeleteRows = false;
            this.dgvExtractedJson.AutoGenerateColumns = false;
            this.dgvExtractedJson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExtractedJson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dgvExtractedJson.DataSource = this.dirFileBindingSource;
            this.dgvExtractedJson.Location = new System.Drawing.Point(23, 44);
            this.dgvExtractedJson.MultiSelect = false;
            this.dgvExtractedJson.Name = "dgvExtractedJson";
            this.dgvExtractedJson.ReadOnly = true;
            this.dgvExtractedJson.RowHeadersVisible = false;
            this.dgvExtractedJson.RowHeadersWidth = 51;
            this.dgvExtractedJson.RowTemplate.Height = 24;
            this.dgvExtractedJson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExtractedJson.Size = new System.Drawing.Size(776, 294);
            this.dgvExtractedJson.TabIndex = 1;
            this.dgvExtractedJson.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvExtractedJson_CellMouseClick);
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
            this.typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dirFileBindingSource
            // 
            this.dirFileBindingSource.DataSource = typeof(DirFileForEver.DataClasses.DirFile);
            // 
            // FormJSONConsulting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 582);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gpLoadInformation);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormJSONConsulting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar información guardada";
            this.gpLoadInformation.ResumeLayout(false);
            this.gbList.ResumeLayout(false);
            this.gbFileSelection.ResumeLayout(false);
            this.gbFileSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtractedJson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dirFileBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpLoadInformation;
        private System.Windows.Forms.GroupBox gbFileSelection;
        private System.Windows.Forms.Button btnSearchFile;
        private System.Windows.Forms.TextBox tbFileURL;
        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvExtractedJson;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dirFileBindingSource;
    }
}
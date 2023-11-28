namespace DirFileForEver.Forms
{
    partial class FormSavingJSON
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
            this.gbChangeTxt = new System.Windows.Forms.GroupBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbChangeTxt.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbChangeTxt
            // 
            this.gbChangeTxt.Controls.Add(this.tbName);
            this.gbChangeTxt.Location = new System.Drawing.Point(30, 27);
            this.gbChangeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.gbChangeTxt.Name = "gbChangeTxt";
            this.gbChangeTxt.Padding = new System.Windows.Forms.Padding(4);
            this.gbChangeTxt.Size = new System.Drawing.Size(403, 70);
            this.gbChangeTxt.TabIndex = 1;
            this.gbChangeTxt.TabStop = false;
            this.gbChangeTxt.Text = "Nombre";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(39, 25);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(328, 22);
            this.tbName.TabIndex = 0;
            this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbName_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(333, 119);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormSavingJSON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 160);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbChangeTxt);
            this.Name = "FormSavingJSON";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guardar archivo JSON";
            this.gbChangeTxt.ResumeLayout(false);
            this.gbChangeTxt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbChangeTxt;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnSave;
    }
}
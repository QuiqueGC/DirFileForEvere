namespace DirFileForEver.Forms
{
    partial class FormCreateOrUpdate
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
            this.btnAccept = new System.Windows.Forms.Button();
            this.gbChangeTxt.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbChangeTxt
            // 
            this.gbChangeTxt.Controls.Add(this.tbName);
            this.gbChangeTxt.Location = new System.Drawing.Point(29, 15);
            this.gbChangeTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbChangeTxt.Name = "gbChangeTxt";
            this.gbChangeTxt.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbChangeTxt.Size = new System.Drawing.Size(403, 70);
            this.gbChangeTxt.TabIndex = 0;
            this.gbChangeTxt.TabStop = false;
            this.gbChangeTxt.Text = "Nombre";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(39, 25);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(328, 22);
            this.tbName.TabIndex = 0;
            this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbName_KeyDown);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(332, 101);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(100, 28);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // FormCreateOrUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 144);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.gbChangeTxt);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCreateOrUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gbChangeTxt.ResumeLayout(false);
            this.gbChangeTxt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbChangeTxt;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnAccept;
    }
}
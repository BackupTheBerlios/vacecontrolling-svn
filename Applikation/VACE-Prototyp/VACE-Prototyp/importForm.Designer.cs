namespace VACE_Prototyp
{
    partial class importForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.importButton = new System.Windows.Forms.Button();
            this.excelOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.empListView = new System.Windows.Forms.ListView();
            this.empGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.empGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.importButton.Location = new System.Drawing.Point(12, 500);
            this.importButton.Name = "button1";
            this.importButton.Size = new System.Drawing.Size(155, 23);
            this.importButton.TabIndex = 1;
            this.importButton.Text = "Excel Sheet öffnen";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // excelOpenFileDialog
            // 
            this.excelOpenFileDialog.FileName = "openFileDialog1";
            this.excelOpenFileDialog.Filter = "Excel Sheets|*.xls";
            // 
            // empListView
            // 
            this.empListView.Location = new System.Drawing.Point(12, 12);
            this.empListView.Name = "empListView";
            this.empListView.Size = new System.Drawing.Size(694, 482);
            this.empListView.TabIndex = 2;
            this.empListView.UseCompatibleStateImageBehavior = false;
            // 
            // empGridView
            // 
            this.empGridView.AllowUserToAddRows = false;
            this.empGridView.AllowUserToDeleteRows = false;
            this.empGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empGridView.Location = new System.Drawing.Point(12, 12);
            this.empGridView.Name = "empGridView";
            this.empGridView.RowTemplate.Height = 24;
            this.empGridView.Size = new System.Drawing.Size(694, 482);
            this.empGridView.TabIndex = 3;
            // 
            // importForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 535);
            this.Controls.Add(this.empGridView);
            this.Controls.Add(this.empListView);
            this.Controls.Add(this.importButton);
            this.Name = "importForm";
            this.Text = "Mitarbeiterdaten importieren";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Testform_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.empGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.OpenFileDialog excelOpenFileDialog;
        private System.Windows.Forms.ListView empListView;
        private System.Windows.Forms.DataGridView empGridView;
    }
}


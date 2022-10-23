namespace Test_xml_loader
{
    partial class frmMain
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
            this.btnLoadDataGrid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadDataGrid
            // 
            this.btnLoadDataGrid.Location = new System.Drawing.Point(12, 12);
            this.btnLoadDataGrid.Name = "btnLoadDataGrid";
            this.btnLoadDataGrid.Size = new System.Drawing.Size(75, 23);
            this.btnLoadDataGrid.TabIndex = 1;
            this.btnLoadDataGrid.Text = "Load Grid";
            this.btnLoadDataGrid.UseVisualStyleBackColor = true;
            this.btnLoadDataGrid.Click += new System.EventHandler(this.btnLoadDataGrid_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 126);
            this.Controls.Add(this.btnLoadDataGrid);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadDataGrid;
    }
}


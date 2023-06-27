
namespace Proiect_
{
    partial class frmReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.EleviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Liceu_2007DataSet = new Proiect_.Liceu_2007DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EleviTableAdapter = new Proiect_.Liceu_2007DataSetTableAdapters.EleviTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EleviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liceu_2007DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EleviBindingSource
            // 
            this.EleviBindingSource.DataMember = "Elevi";
            this.EleviBindingSource.DataSource = this.Liceu_2007DataSet;
            // 
            // Liceu_2007DataSet
            // 
            this.Liceu_2007DataSet.DataSetName = "Liceu_2007DataSet";
            this.Liceu_2007DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reportViewer1.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EleviBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proiect_.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(40, 121);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1050, 492);
            this.reportViewer1.TabIndex = 0;
            // 
            // EleviTableAdapter
            // 
            this.EleviTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect_.Properties.Resources._4038602;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1122, 625);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EleviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liceu_2007DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EleviBindingSource;
        private Liceu_2007DataSet Liceu_2007DataSet;
        private Liceu_2007DataSetTableAdapters.EleviTableAdapter EleviTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
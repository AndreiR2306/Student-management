
namespace Proiect_
{
    partial class frmDiscipline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiscipline));
            this.txtNumeDisciplina = new System.Windows.Forms.TextBox();
            this.disciplineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.liceu_2007DataSet = new Proiect_.Liceu_2007DataSet();
            this.txtCodDisciplina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgwElevi = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.disciplineTableAdapter = new Proiect_.Liceu_2007DataSetTableAdapters.DisciplineTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liceu_2007DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwElevi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumeDisciplina
            // 
            this.txtNumeDisciplina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplineBindingSource, "Nume_disciplina", true));
            this.txtNumeDisciplina.Location = new System.Drawing.Point(285, 87);
            this.txtNumeDisciplina.Name = "txtNumeDisciplina";
            this.txtNumeDisciplina.Size = new System.Drawing.Size(225, 22);
            this.txtNumeDisciplina.TabIndex = 1;
            // 
            // disciplineBindingSource
            // 
            this.disciplineBindingSource.DataMember = "Discipline";
            this.disciplineBindingSource.DataSource = this.liceu_2007DataSet;
            // 
            // liceu_2007DataSet
            // 
            this.liceu_2007DataSet.DataSetName = "Liceu_2007DataSet";
            this.liceu_2007DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCodDisciplina
            // 
            this.txtCodDisciplina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplineBindingSource, "Cod_dis", true));
            this.txtCodDisciplina.Location = new System.Drawing.Point(41, 87);
            this.txtCodDisciplina.Name = "txtCodDisciplina";
            this.txtCodDisciplina.Size = new System.Drawing.Size(225, 22);
            this.txtCodDisciplina.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(95, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cod disciplina";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MintCream;
            this.btnDelete.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Location = new System.Drawing.Point(630, 78);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 41);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgwElevi
            // 
            this.dgwElevi.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgwElevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwElevi.Location = new System.Drawing.Point(57, 171);
            this.dgwElevi.Name = "dgwElevi";
            this.dgwElevi.RowHeadersWidth = 51;
            this.dgwElevi.RowTemplate.Height = 24;
            this.dgwElevi.Size = new System.Drawing.Size(685, 533);
            this.dgwElevi.TabIndex = 6;
            this.dgwElevi.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwElevi_CellEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(334, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nume disciplina";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MintCream;
            this.btnSearch.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSearch.Location = new System.Drawing.Point(806, 78);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 41);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.MintCream;
            this.btnClose.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.Location = new System.Drawing.Point(982, 78);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 41);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // disciplineTableAdapter
            // 
            this.disciplineTableAdapter.ClearBeforeFill = true;
            // 
            // frmDiscipline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect_.Properties.Resources._4038602;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1257, 682);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgwElevi);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodDisciplina);
            this.Controls.Add(this.txtNumeDisciplina);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDiscipline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDiscipline";
            this.Load += new System.EventHandler(this.frmDiscipline_Load);
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liceu_2007DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwElevi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeDisciplina;
        private System.Windows.Forms.TextBox txtCodDisciplina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgwElevi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private Liceu_2007DataSet liceu_2007DataSet;
        private System.Windows.Forms.BindingSource disciplineBindingSource;
        private Liceu_2007DataSetTableAdapters.DisciplineTableAdapter disciplineTableAdapter;
    }
}
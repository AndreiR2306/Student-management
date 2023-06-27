
namespace Proiect_
{
    partial class frmAdaugareProfesor
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
            this.txtCodProfesor = new System.Windows.Forms.TextBox();
            this.profesoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.liceu_2007DataSet = new Proiect_.Liceu_2007DataSet();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtDataProfesor = new System.Windows.Forms.TextBox();
            this.txtSalariu = new System.Windows.Forms.TextBox();
            this.txtCasatorit = new System.Windows.Forms.TextBox();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.txtCV = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtDiriginte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgwElevi = new System.Windows.Forms.DataGridView();
            this.profesoriTableAdapter = new Proiect_.Liceu_2007DataSetTableAdapters.ProfesoriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.profesoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liceu_2007DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwElevi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodProfesor
            // 
            this.txtCodProfesor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoriBindingSource, "Cod_prof", true));
            this.txtCodProfesor.Location = new System.Drawing.Point(217, 12);
            this.txtCodProfesor.Name = "txtCodProfesor";
            this.txtCodProfesor.Size = new System.Drawing.Size(285, 22);
            this.txtCodProfesor.TabIndex = 0;
            // 
            // profesoriBindingSource
            // 
            this.profesoriBindingSource.DataMember = "Profesori";
            this.profesoriBindingSource.DataSource = this.liceu_2007DataSet;
            // 
            // liceu_2007DataSet
            // 
            this.liceu_2007DataSet.DataSetName = "Liceu_2007DataSet";
            this.liceu_2007DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNume
            // 
            this.txtNume.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoriBindingSource, "Nume_prof", true));
            this.txtNume.Location = new System.Drawing.Point(217, 40);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(285, 22);
            this.txtNume.TabIndex = 1;
            // 
            // txtPrenume
            // 
            this.txtPrenume.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoriBindingSource, "Pren_prof", true));
            this.txtPrenume.Location = new System.Drawing.Point(217, 68);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(285, 22);
            this.txtPrenume.TabIndex = 2;
            // 
            // txtDataProfesor
            // 
            this.txtDataProfesor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoriBindingSource, "Data_prof", true));
            this.txtDataProfesor.Location = new System.Drawing.Point(217, 96);
            this.txtDataProfesor.Name = "txtDataProfesor";
            this.txtDataProfesor.Size = new System.Drawing.Size(285, 22);
            this.txtDataProfesor.TabIndex = 3;
            // 
            // txtSalariu
            // 
            this.txtSalariu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoriBindingSource, "Salariu", true));
            this.txtSalariu.Location = new System.Drawing.Point(217, 124);
            this.txtSalariu.Name = "txtSalariu";
            this.txtSalariu.Size = new System.Drawing.Size(285, 22);
            this.txtSalariu.TabIndex = 4;
            // 
            // txtCasatorit
            // 
            this.txtCasatorit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoriBindingSource, "Casatorit", true));
            this.txtCasatorit.Location = new System.Drawing.Point(217, 152);
            this.txtCasatorit.Name = "txtCasatorit";
            this.txtCasatorit.Size = new System.Drawing.Size(285, 22);
            this.txtCasatorit.TabIndex = 5;
            // 
            // txtGen
            // 
            this.txtGen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoriBindingSource, "Gen_prof", true));
            this.txtGen.Location = new System.Drawing.Point(217, 180);
            this.txtGen.Name = "txtGen";
            this.txtGen.Size = new System.Drawing.Size(285, 22);
            this.txtGen.TabIndex = 6;
            // 
            // txtCV
            // 
            this.txtCV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoriBindingSource, "CV_prof", true));
            this.txtCV.Location = new System.Drawing.Point(217, 208);
            this.txtCV.Name = "txtCV";
            this.txtCV.Size = new System.Drawing.Size(285, 22);
            this.txtCV.TabIndex = 7;
            // 
            // txtTelefon
            // 
            this.txtTelefon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoriBindingSource, "Telefon", true));
            this.txtTelefon.Location = new System.Drawing.Point(217, 236);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(285, 22);
            this.txtTelefon.TabIndex = 8;
            // 
            // txtDiriginte
            // 
            this.txtDiriginte.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoriBindingSource, "Diriginte", true));
            this.txtDiriginte.Location = new System.Drawing.Point(217, 264);
            this.txtDiriginte.Name = "txtDiriginte";
            this.txtDiriginte.Size = new System.Drawing.Size(285, 22);
            this.txtDiriginte.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(47, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cod profesor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(47, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(47, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Prenume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(47, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Data profesor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(47, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Salariu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(47, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Casatorit(Da/Nu)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(47, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Gen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(47, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "CV Profesor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(47, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Telefon";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(47, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Diriginte";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.GhostWhite;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(581, 74);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 42);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.GhostWhite;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Location = new System.Drawing.Point(763, 74);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 42);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.Location = new System.Drawing.Point(938, 74);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 42);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // dgwElevi
            // 
            this.dgwElevi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwElevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwElevi.Location = new System.Drawing.Point(50, 340);
            this.dgwElevi.Name = "dgwElevi";
            this.dgwElevi.RowHeadersWidth = 51;
            this.dgwElevi.RowTemplate.Height = 24;
            this.dgwElevi.Size = new System.Drawing.Size(1079, 342);
            this.dgwElevi.TabIndex = 23;
            // 
            // profesoriTableAdapter
            // 
            this.profesoriTableAdapter.ClearBeforeFill = true;
            // 
            // frmAdaugareProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1174, 694);
            this.Controls.Add(this.dgwElevi);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiriginte);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtCV);
            this.Controls.Add(this.txtGen);
            this.Controls.Add(this.txtCasatorit);
            this.Controls.Add(this.txtSalariu);
            this.Controls.Add(this.txtDataProfesor);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.txtCodProfesor);
            this.Name = "frmAdaugareProfesor";
            this.Text = "frmAdaugareProfesor";
            this.Load += new System.EventHandler(this.frmAdaugareProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profesoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liceu_2007DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwElevi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodProfesor;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtDataProfesor;
        private System.Windows.Forms.TextBox txtSalariu;
        private System.Windows.Forms.TextBox txtCasatorit;
        private System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.TextBox txtCV;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtDiriginte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgwElevi;
        private Liceu_2007DataSet liceu_2007DataSet;
        private System.Windows.Forms.BindingSource profesoriBindingSource;
        private Liceu_2007DataSetTableAdapters.ProfesoriTableAdapter profesoriTableAdapter;
    }
}
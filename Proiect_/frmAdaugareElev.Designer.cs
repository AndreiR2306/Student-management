
namespace Proiect_
{
    partial class frmAdaugareElev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdaugareElev));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodElev = new System.Windows.Forms.TextBox();
            this.eleviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.liceu_2007DataSet = new Proiect_.Liceu_2007DataSet();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtCodClase = new System.Windows.Forms.TextBox();
            this.txtDataElev = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgwElevi = new System.Windows.Forms.DataGridView();
            this.eleviTableAdapter = new Proiect_.Liceu_2007DataSetTableAdapters.EleviTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.eleviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liceu_2007DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwElevi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(47, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod elev";
            // 
            // txtCodElev
            // 
            this.txtCodElev.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eleviBindingSource, "Cod_elev", true));
            this.txtCodElev.Location = new System.Drawing.Point(164, 12);
            this.txtCodElev.Name = "txtCodElev";
            this.txtCodElev.Size = new System.Drawing.Size(270, 22);
            this.txtCodElev.TabIndex = 0;
            // 
            // eleviBindingSource
            // 
            this.eleviBindingSource.DataMember = "Elevi";
            this.eleviBindingSource.DataSource = this.liceu_2007DataSet;
            // 
            // liceu_2007DataSet
            // 
            this.liceu_2007DataSet.DataSetName = "Liceu_2007DataSet";
            this.liceu_2007DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNume
            // 
            this.txtNume.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eleviBindingSource, "Nume_elev", true));
            this.txtNume.Location = new System.Drawing.Point(164, 40);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(270, 22);
            this.txtNume.TabIndex = 1;
            // 
            // txtPrenume
            // 
            this.txtPrenume.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eleviBindingSource, "Pren_elev", true));
            this.txtPrenume.Location = new System.Drawing.Point(164, 68);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(270, 22);
            this.txtPrenume.TabIndex = 2;
            // 
            // txtCodClase
            // 
            this.txtCodClase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eleviBindingSource, "Cod_clasa", true));
            this.txtCodClase.Location = new System.Drawing.Point(164, 96);
            this.txtCodClase.Name = "txtCodClase";
            this.txtCodClase.Size = new System.Drawing.Size(270, 22);
            this.txtCodClase.TabIndex = 3;
            this.txtCodClase.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtDataElev
            // 
            this.txtDataElev.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eleviBindingSource, "Data_elev", true));
            this.txtDataElev.Location = new System.Drawing.Point(164, 124);
            this.txtDataElev.Name = "txtDataElev";
            this.txtDataElev.Size = new System.Drawing.Size(270, 22);
            this.txtDataElev.TabIndex = 4;
            // 
            // txtTelefon
            // 
            this.txtTelefon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eleviBindingSource, "Telefon", true));
            this.txtTelefon.Location = new System.Drawing.Point(164, 152);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(270, 22);
            this.txtTelefon.TabIndex = 5;
            // 
            // txtGen
            // 
            this.txtGen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eleviBindingSource, "Gen_elev", true));
            this.txtGen.Location = new System.Drawing.Point(164, 180);
            this.txtGen.Name = "txtGen";
            this.txtGen.Size = new System.Drawing.Size(270, 22);
            this.txtGen.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(47, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(47, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prenume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(47, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cod clasa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(47, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data elev";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(47, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Telefon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(47, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Gen elev";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.GhostWhite;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(518, 58);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 43);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.GhostWhite;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Location = new System.Drawing.Point(703, 58);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 43);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.Location = new System.Drawing.Point(875, 58);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 43);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgwElevi
            // 
            this.dgwElevi.BackgroundColor = System.Drawing.Color.White;
            this.dgwElevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwElevi.Location = new System.Drawing.Point(74, 243);
            this.dgwElevi.Name = "dgwElevi";
            this.dgwElevi.RowHeadersWidth = 51;
            this.dgwElevi.RowTemplate.Height = 24;
            this.dgwElevi.Size = new System.Drawing.Size(1064, 459);
            this.dgwElevi.TabIndex = 17;
            // 
            // eleviTableAdapter
            // 
            this.eleviTableAdapter.ClearBeforeFill = true;
            // 
            // frmAdaugareElev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1191, 726);
            this.Controls.Add(this.dgwElevi);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGen);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtDataElev);
            this.Controls.Add(this.txtCodClase);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.txtCodElev);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdaugareElev";
            this.Text = "frmAdaugareElev";
            this.Load += new System.EventHandler(this.frmAdaugareElev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eleviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liceu_2007DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwElevi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodElev;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtCodClase;
        private System.Windows.Forms.TextBox txtDataElev;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgwElevi;
        private Liceu_2007DataSet liceu_2007DataSet;
        private System.Windows.Forms.BindingSource eleviBindingSource;
        private Liceu_2007DataSetTableAdapters.EleviTableAdapter eleviTableAdapter;
    }
}
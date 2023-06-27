
namespace Proiect_
{
    partial class frmEditareElev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditareElev));
            this.txtCodElev = new System.Windows.Forms.TextBox();
            this.eleviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.liceu_2007DataSet = new Proiect_.Liceu_2007DataSet();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtCodClasa = new System.Windows.Forms.TextBox();
            this.txtDataElev = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgwElevi = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.eleviTableAdapter = new Proiect_.Liceu_2007DataSetTableAdapters.EleviTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.eleviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liceu_2007DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwElevi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodElev
            // 
            this.txtCodElev.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eleviBindingSource, "Cod_elev", true));
            this.txtCodElev.Location = new System.Drawing.Point(249, 30);
            this.txtCodElev.Name = "txtCodElev";
            this.txtCodElev.Size = new System.Drawing.Size(222, 22);
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
            this.txtNume.Location = new System.Drawing.Point(249, 58);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(222, 22);
            this.txtNume.TabIndex = 1;
            // 
            // txtPrenume
            // 
            this.txtPrenume.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eleviBindingSource, "Pren_elev", true));
            this.txtPrenume.Location = new System.Drawing.Point(249, 86);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(222, 22);
            this.txtPrenume.TabIndex = 2;
            // 
            // txtCodClasa
            // 
            this.txtCodClasa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eleviBindingSource, "Cod_clasa", true));
            this.txtCodClasa.Location = new System.Drawing.Point(249, 114);
            this.txtCodClasa.Name = "txtCodClasa";
            this.txtCodClasa.Size = new System.Drawing.Size(222, 22);
            this.txtCodClasa.TabIndex = 3;
            // 
            // txtDataElev
            // 
            this.txtDataElev.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eleviBindingSource, "Data_elev", true));
            this.txtDataElev.Location = new System.Drawing.Point(249, 142);
            this.txtDataElev.Name = "txtDataElev";
            this.txtDataElev.Size = new System.Drawing.Size(222, 22);
            this.txtDataElev.TabIndex = 4;
            // 
            // txtTelefon
            // 
            this.txtTelefon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eleviBindingSource, "Telefon", true));
            this.txtTelefon.Location = new System.Drawing.Point(249, 170);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(222, 22);
            this.txtTelefon.TabIndex = 5;
            // 
            // txtGen
            // 
            this.txtGen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eleviBindingSource, "Gen_elev", true));
            this.txtGen.Location = new System.Drawing.Point(249, 198);
            this.txtGen.Name = "txtGen";
            this.txtGen.Size = new System.Drawing.Size(222, 22);
            this.txtGen.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(93, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cod elev";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(93, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(93, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prenume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(93, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cod clasa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(93, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data elev";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(93, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Telefon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(93, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Gen";
            // 
            // dgwElevi
            // 
            this.dgwElevi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwElevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwElevi.Location = new System.Drawing.Point(22, 249);
            this.dgwElevi.Name = "dgwElevi";
            this.dgwElevi.RowHeadersWidth = 51;
            this.dgwElevi.RowTemplate.Height = 24;
            this.dgwElevi.Size = new System.Drawing.Size(1167, 459);
            this.dgwElevi.TabIndex = 14;
            this.dgwElevi.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwElevi_CellEnter);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpdate.Location = new System.Drawing.Point(575, 102);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 47);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Location = new System.Drawing.Point(752, 102);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 47);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // eleviTableAdapter
            // 
            this.eleviTableAdapter.ClearBeforeFill = true;
            // 
            // frmEditareElev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = global::Proiect_.Properties.Resources.pexels_gradienta_7130469;
            this.ClientSize = new System.Drawing.Size(1216, 725);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgwElevi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGen);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtDataElev);
            this.Controls.Add(this.txtCodClasa);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.txtCodElev);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditareElev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditareElev";
            this.Load += new System.EventHandler(this.frmEditareElev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eleviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liceu_2007DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwElevi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodElev;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtCodClasa;
        private System.Windows.Forms.TextBox txtDataElev;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgwElevi;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private Liceu_2007DataSet liceu_2007DataSet;
        private System.Windows.Forms.BindingSource eleviBindingSource;
        private Liceu_2007DataSetTableAdapters.EleviTableAdapter eleviTableAdapter;
    }
}
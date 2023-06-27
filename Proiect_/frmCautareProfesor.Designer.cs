
namespace Proiect_
{
    partial class frmCautareProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCautareProfesor));
            this.txtCodProf = new System.Windows.Forms.TextBox();
            this.txtNumeProf = new System.Windows.Forms.TextBox();
            this.txtPrenumeProf = new System.Windows.Forms.TextBox();
            this.txtDiriginte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgwProf = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProf)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodProf
            // 
            this.txtCodProf.Location = new System.Drawing.Point(106, 98);
            this.txtCodProf.Name = "txtCodProf";
            this.txtCodProf.Size = new System.Drawing.Size(226, 22);
            this.txtCodProf.TabIndex = 0;
            this.txtCodProf.TextChanged += new System.EventHandler(this.txtCodProf_TextChanged);
            this.txtCodProf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodProf_KeyPress);
            // 
            // txtNumeProf
            // 
            this.txtNumeProf.Location = new System.Drawing.Point(389, 98);
            this.txtNumeProf.Name = "txtNumeProf";
            this.txtNumeProf.Size = new System.Drawing.Size(226, 22);
            this.txtNumeProf.TabIndex = 1;
            this.txtNumeProf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeProf_KeyPress);
            // 
            // txtPrenumeProf
            // 
            this.txtPrenumeProf.Location = new System.Drawing.Point(670, 98);
            this.txtPrenumeProf.Name = "txtPrenumeProf";
            this.txtPrenumeProf.Size = new System.Drawing.Size(226, 22);
            this.txtPrenumeProf.TabIndex = 2;
            this.txtPrenumeProf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrenumeProf_KeyPress);
            // 
            // txtDiriginte
            // 
            this.txtDiriginte.Location = new System.Drawing.Point(948, 98);
            this.txtDiriginte.Name = "txtDiriginte";
            this.txtDiriginte.Size = new System.Drawing.Size(226, 22);
            this.txtDiriginte.TabIndex = 3;
            this.txtDiriginte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiriginte_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(169, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cod profesor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(448, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nume profesor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(713, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prenume profesor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(1029, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Diriginte";
            // 
            // dgwProf
            // 
            this.dgwProf.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProf.Location = new System.Drawing.Point(44, 177);
            this.dgwProf.Name = "dgwProf";
            this.dgwProf.RowHeadersWidth = 51;
            this.dgwProf.RowTemplate.Height = 24;
            this.dgwProf.Size = new System.Drawing.Size(1189, 528);
            this.dgwProf.TabIndex = 8;
            // 
            // frmCautareProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect_.Properties.Resources.pexels_gradienta_7130469;
            this.ClientSize = new System.Drawing.Size(1271, 744);
            this.Controls.Add(this.dgwProf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiriginte);
            this.Controls.Add(this.txtPrenumeProf);
            this.Controls.Add(this.txtNumeProf);
            this.Controls.Add(this.txtCodProf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCautareProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "d";
            this.Load += new System.EventHandler(this.frmCautareProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodProf;
        private System.Windows.Forms.TextBox txtNumeProf;
        private System.Windows.Forms.TextBox txtPrenumeProf;
        private System.Windows.Forms.TextBox txtDiriginte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgwProf;
    }
}
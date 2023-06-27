
namespace Proiect_
{
    partial class frmCautareAdresaProfi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCautareAdresaProfi));
            this.txtCodProf = new System.Windows.Forms.TextBox();
            this.txtLocalitate = new System.Windows.Forms.TextBox();
            this.txtStrada = new System.Windows.Forms.TextBox();
            this.dgwAdrese = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAdrese)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodProf
            // 
            this.txtCodProf.Location = new System.Drawing.Point(132, 84);
            this.txtCodProf.Name = "txtCodProf";
            this.txtCodProf.Size = new System.Drawing.Size(250, 23);
            this.txtCodProf.TabIndex = 0;
            this.txtCodProf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodProf_KeyPress);
            // 
            // txtLocalitate
            // 
            this.txtLocalitate.Location = new System.Drawing.Point(483, 84);
            this.txtLocalitate.Name = "txtLocalitate";
            this.txtLocalitate.Size = new System.Drawing.Size(250, 23);
            this.txtLocalitate.TabIndex = 1;
            this.txtLocalitate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLocalitate_KeyPress);
            // 
            // txtStrada
            // 
            this.txtStrada.Location = new System.Drawing.Point(830, 84);
            this.txtStrada.Name = "txtStrada";
            this.txtStrada.Size = new System.Drawing.Size(250, 23);
            this.txtStrada.TabIndex = 2;
            this.txtStrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStrada_KeyPress);
            // 
            // dgwAdrese
            // 
            this.dgwAdrese.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwAdrese.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwAdrese.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAdrese.Location = new System.Drawing.Point(43, 182);
            this.dgwAdrese.Name = "dgwAdrese";
            this.dgwAdrese.RowHeadersWidth = 51;
            this.dgwAdrese.RowTemplate.Height = 24;
            this.dgwAdrese.Size = new System.Drawing.Size(1141, 527);
            this.dgwAdrese.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(211, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cod profesor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(562, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Localitate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(917, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Strada";
            // 
            // frmCautareAdresaProfi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::Proiect_.Properties.Resources.pexels_gradienta_7130469;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1220, 734);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwAdrese);
            this.Controls.Add(this.txtStrada);
            this.Controls.Add(this.txtLocalitate);
            this.Controls.Add(this.txtCodProf);
            this.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCautareAdresaProfi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCautareAdresaProfi";
            ((System.ComponentModel.ISupportInitialize)(this.dgwAdrese)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodProf;
        private System.Windows.Forms.TextBox txtLocalitate;
        private System.Windows.Forms.TextBox txtStrada;
        private System.Windows.Forms.DataGridView dgwAdrese;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
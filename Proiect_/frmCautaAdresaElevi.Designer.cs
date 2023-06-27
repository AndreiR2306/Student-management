
namespace Proiect_
{
    partial class frmCautaAdresaElevi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCautaAdresaElevi));
            this.txtCodElev = new System.Windows.Forms.TextBox();
            this.txtLocElev = new System.Windows.Forms.TextBox();
            this.txtStradaElev = new System.Windows.Forms.TextBox();
            this.dgwAdresaEle = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAdresaEle)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodElev
            // 
            this.txtCodElev.Location = new System.Drawing.Point(247, 83);
            this.txtCodElev.Name = "txtCodElev";
            this.txtCodElev.Size = new System.Drawing.Size(202, 22);
            this.txtCodElev.TabIndex = 0;
            this.txtCodElev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodElev_KeyPress);
            // 
            // txtLocElev
            // 
            this.txtLocElev.Location = new System.Drawing.Point(487, 83);
            this.txtLocElev.Name = "txtLocElev";
            this.txtLocElev.Size = new System.Drawing.Size(202, 22);
            this.txtLocElev.TabIndex = 1;
            this.txtLocElev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLocElev_KeyPress);
            // 
            // txtStradaElev
            // 
            this.txtStradaElev.Location = new System.Drawing.Point(724, 83);
            this.txtStradaElev.Name = "txtStradaElev";
            this.txtStradaElev.Size = new System.Drawing.Size(202, 22);
            this.txtStradaElev.TabIndex = 2;
            this.txtStradaElev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStradaElev_KeyPress);
            // 
            // dgwAdresaEle
            // 
            this.dgwAdresaEle.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwAdresaEle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAdresaEle.Location = new System.Drawing.Point(25, 185);
            this.dgwAdresaEle.Name = "dgwAdresaEle";
            this.dgwAdresaEle.RowHeadersWidth = 51;
            this.dgwAdresaEle.RowTemplate.Height = 24;
            this.dgwAdresaEle.Size = new System.Drawing.Size(1143, 495);
            this.dgwAdresaEle.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(320, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cod elev";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(555, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Loc elev";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(778, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Strada elev";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmCautaAdresaElevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect_.Properties.Resources.pexels_gradienta_7130469;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1208, 689);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwAdresaEle);
            this.Controls.Add(this.txtStradaElev);
            this.Controls.Add(this.txtLocElev);
            this.Controls.Add(this.txtCodElev);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCautaAdresaElevi";
            this.Text = "frmCautaAdresaElevi";
            this.Load += new System.EventHandler(this.frmCautaAdresaElevi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAdresaEle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodElev;
        private System.Windows.Forms.TextBox txtLocElev;
        private System.Windows.Forms.TextBox txtStradaElev;
        private System.Windows.Forms.DataGridView dgwAdresaEle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
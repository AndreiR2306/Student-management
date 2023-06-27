
namespace Proiect_
{
    partial class frmCautareElevi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCautareElevi));
            this.txtCodElev = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtClasa = new System.Windows.Forms.TextBox();
            this.dgwElevi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Clasa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwElevi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodElev
            // 
            this.txtCodElev.Location = new System.Drawing.Point(147, 105);
            this.txtCodElev.Name = "txtCodElev";
            this.txtCodElev.Size = new System.Drawing.Size(208, 22);
            this.txtCodElev.TabIndex = 0;
            this.txtCodElev.TextChanged += new System.EventHandler(this.txtCodElev_TextChanged);
            this.txtCodElev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodElev_KeyPress);
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(382, 105);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(208, 22);
            this.txtNume.TabIndex = 1;
            this.txtNume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNume_KeyPress);
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(614, 105);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(208, 22);
            this.txtPrenume.TabIndex = 2;
            this.txtPrenume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrenume_KeyPress);
            // 
            // txtClasa
            // 
            this.txtClasa.Location = new System.Drawing.Point(845, 105);
            this.txtClasa.Name = "txtClasa";
            this.txtClasa.Size = new System.Drawing.Size(208, 22);
            this.txtClasa.TabIndex = 4;
            this.txtClasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClasa_KeyPress);
            // 
            // dgwElevi
            // 
            this.dgwElevi.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgwElevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwElevi.Location = new System.Drawing.Point(56, 194);
            this.dgwElevi.Name = "dgwElevi";
            this.dgwElevi.RowHeadersWidth = 51;
            this.dgwElevi.RowTemplate.Height = 24;
            this.dgwElevi.Size = new System.Drawing.Size(1136, 531);
            this.dgwElevi.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(218, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cod Elev";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(455, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nume elev";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(684, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prenume";
            // 
            // Clasa
            // 
            this.Clasa.AutoSize = true;
            this.Clasa.BackColor = System.Drawing.Color.Transparent;
            this.Clasa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clasa.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Clasa.Location = new System.Drawing.Point(929, 64);
            this.Clasa.Name = "Clasa";
            this.Clasa.Size = new System.Drawing.Size(50, 16);
            this.Clasa.TabIndex = 9;
            this.Clasa.Text = "Clasa";
            // 
            // frmCautareElevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1235, 751);
            this.Controls.Add(this.Clasa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwElevi);
            this.Controls.Add(this.txtClasa);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.txtCodElev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCautareElevi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCautareElevi";
            ((System.ComponentModel.ISupportInitialize)(this.dgwElevi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodElev;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtClasa;
        private System.Windows.Forms.DataGridView dgwElevi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Clasa;
    }
}
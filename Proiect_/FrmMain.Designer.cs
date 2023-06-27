
namespace Proiect_
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.evidentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eleviTool = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareElev = new System.Windows.Forms.ToolStripMenuItem();
            this.editareElev = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoriTool = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareProfesoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cautaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eleviToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.adresaEleviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adresaProfesoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Font = new System.Drawing.Font("DejaVu Sans Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evidentaToolStripMenuItem,
            this.vizualizareToolStripMenuItem,
            this.raportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1273, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // evidentaToolStripMenuItem
            // 
            this.evidentaToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.evidentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eleviTool,
            this.profesoriTool,
            this.disciplineToolStripMenuItem});
            this.evidentaToolStripMenuItem.Margin = new System.Windows.Forms.Padding(1);
            this.evidentaToolStripMenuItem.Name = "evidentaToolStripMenuItem";
            this.evidentaToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.evidentaToolStripMenuItem.Text = "Operatii";
            // 
            // eleviTool
            // 
            this.eleviTool.BackColor = System.Drawing.Color.White;
            this.eleviTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareElev,
            this.editareElev});
            this.eleviTool.Name = "eleviTool";
            this.eleviTool.Size = new System.Drawing.Size(224, 26);
            this.eleviTool.Text = "Elevi";
            // 
            // adaugareElev
            // 
            this.adaugareElev.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adaugareElev.Name = "adaugareElev";
            this.adaugareElev.Size = new System.Drawing.Size(252, 26);
            this.adaugareElev.Text = "Adaugare/Stergere elev";
            this.adaugareElev.Click += new System.EventHandler(this.adaugareElev_Click);
            // 
            // editareElev
            // 
            this.editareElev.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editareElev.Name = "editareElev";
            this.editareElev.Size = new System.Drawing.Size(252, 26);
            this.editareElev.Text = "Editare elev";
            this.editareElev.Click += new System.EventHandler(this.editareElev_Click);
            // 
            // profesoriTool
            // 
            this.profesoriTool.BackColor = System.Drawing.Color.White;
            this.profesoriTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareProfesoriToolStripMenuItem,
            this.cautaToolStripMenuItem});
            this.profesoriTool.Name = "profesoriTool";
            this.profesoriTool.Size = new System.Drawing.Size(224, 26);
            this.profesoriTool.Text = "Profesori";
            this.profesoriTool.Click += new System.EventHandler(this.profesoriTool_Click);
            // 
            // adaugareProfesoriToolStripMenuItem
            // 
            this.adaugareProfesoriToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.adaugareProfesoriToolStripMenuItem.Name = "adaugareProfesoriToolStripMenuItem";
            this.adaugareProfesoriToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.adaugareProfesoriToolStripMenuItem.Text = "Adaugare/stergere profesor";
            this.adaugareProfesoriToolStripMenuItem.Click += new System.EventHandler(this.adaugareProfesoriToolStripMenuItem_Click);
            // 
            // cautaToolStripMenuItem
            // 
            this.cautaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cautaToolStripMenuItem.Name = "cautaToolStripMenuItem";
            this.cautaToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.cautaToolStripMenuItem.Text = "Cauta";
            this.cautaToolStripMenuItem.Click += new System.EventHandler(this.cautaToolStripMenuItem_Click);
            // 
            // disciplineToolStripMenuItem
            // 
            this.disciplineToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.disciplineToolStripMenuItem.Name = "disciplineToolStripMenuItem";
            this.disciplineToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.disciplineToolStripMenuItem.Text = "Discipline";
            this.disciplineToolStripMenuItem.Click += new System.EventHandler(this.disciplineToolStripMenuItem_Click);
            // 
            // vizualizareToolStripMenuItem
            // 
            this.vizualizareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eleviToolStripMenuItem2,
            this.adresaEleviToolStripMenuItem,
            this.adresaProfesoriToolStripMenuItem});
            this.vizualizareToolStripMenuItem.Margin = new System.Windows.Forms.Padding(1);
            this.vizualizareToolStripMenuItem.Name = "vizualizareToolStripMenuItem";
            this.vizualizareToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.vizualizareToolStripMenuItem.Text = "Vizualizare";
            // 
            // eleviToolStripMenuItem2
            // 
            this.eleviToolStripMenuItem2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eleviToolStripMenuItem2.Name = "eleviToolStripMenuItem2";
            this.eleviToolStripMenuItem2.Size = new System.Drawing.Size(202, 26);
            this.eleviToolStripMenuItem2.Text = "Elevi";
            this.eleviToolStripMenuItem2.Click += new System.EventHandler(this.eleviToolStripMenuItem2_Click);
            // 
            // adresaEleviToolStripMenuItem
            // 
            this.adresaEleviToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adresaEleviToolStripMenuItem.Name = "adresaEleviToolStripMenuItem";
            this.adresaEleviToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.adresaEleviToolStripMenuItem.Text = "Adresa elevi";
            this.adresaEleviToolStripMenuItem.Click += new System.EventHandler(this.adresaEleviToolStripMenuItem_Click);
            // 
            // adresaProfesoriToolStripMenuItem
            // 
            this.adresaProfesoriToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adresaProfesoriToolStripMenuItem.Name = "adresaProfesoriToolStripMenuItem";
            this.adresaProfesoriToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.adresaProfesoriToolStripMenuItem.Text = "Adresa profesori";
            this.adresaProfesoriToolStripMenuItem.Click += new System.EventHandler(this.adresaProfesoriToolStripMenuItem_Click);
            // 
            // raportToolStripMenuItem
            // 
            this.raportToolStripMenuItem.BackColor = System.Drawing.Color.Lavender;
            this.raportToolStripMenuItem.Name = "raportToolStripMenuItem";
            this.raportToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.raportToolStripMenuItem.Text = "Report";
            this.raportToolStripMenuItem.Click += new System.EventHandler(this.raportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Lavender;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(54, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.monthCalendar1.BackColor = System.Drawing.Color.NavajoWhite;
            this.monthCalendar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.monthCalendar1.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.monthCalendar1.ForeColor = System.Drawing.Color.MistyRose;
            this.monthCalendar1.Location = new System.Drawing.Point(0, 46);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.MistyRose;
            this.monthCalendar1.TitleForeColor = System.Drawing.Color.AliceBlue;
            this.monthCalendar1.TrailingForeColor = System.Drawing.Color.Bisque;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1074, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = global::Proiect_.Properties.Resources.world_book_fun_billboard_03__Converted15455_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1273, 726);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem evidentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eleviTool;
        private System.Windows.Forms.ToolStripMenuItem adaugareElev;
        private System.Windows.Forms.ToolStripMenuItem editareElev;
        private System.Windows.Forms.ToolStripMenuItem profesoriTool;
        private System.Windows.Forms.ToolStripMenuItem disciplineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareProfesoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eleviToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem adresaEleviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adresaProfesoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cautaToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
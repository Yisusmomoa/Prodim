
namespace ProcDigital1
{
    partial class Brillo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBarBrillo = new System.Windows.Forms.TrackBar();
            this.labelBrillo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrillo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1080, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirImagenToolStripMenuItem,
            this.salvarImagenToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirImagenToolStripMenuItem
            // 
            this.abrirImagenToolStripMenuItem.Name = "abrirImagenToolStripMenuItem";
            this.abrirImagenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirImagenToolStripMenuItem.Text = "Abrir imagen";
            this.abrirImagenToolStripMenuItem.Click += new System.EventHandler(this.abrirImagenToolStripMenuItem_Click);
            // 
            // salvarImagenToolStripMenuItem
            // 
            this.salvarImagenToolStripMenuItem.Name = "salvarImagenToolStripMenuItem";
            this.salvarImagenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarImagenToolStripMenuItem.Text = "Salvar imagen";
            this.salvarImagenToolStripMenuItem.Click += new System.EventHandler(this.salvarImagenToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG|*.png";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(834, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 72);
            this.button1.TabIndex = 1;
            this.button1.Text = "Brillo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBarBrillo
            // 
            this.trackBarBrillo.Location = new System.Drawing.Point(789, 308);
            this.trackBarBrillo.Maximum = 255;
            this.trackBarBrillo.Minimum = -255;
            this.trackBarBrillo.Name = "trackBarBrillo";
            this.trackBarBrillo.Size = new System.Drawing.Size(217, 45);
            this.trackBarBrillo.TabIndex = 2;
            this.trackBarBrillo.Scroll += new System.EventHandler(this.trackBarBrillo_Scroll);
            // 
            // labelBrillo
            // 
            this.labelBrillo.AutoSize = true;
            this.labelBrillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrillo.Location = new System.Drawing.Point(886, 356);
            this.labelBrillo.Name = "labelBrillo";
            this.labelBrillo.Size = new System.Drawing.Size(20, 22);
            this.labelBrillo.TabIndex = 3;
            this.labelBrillo.Text = "0";
            // 
            // Brillo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 771);
            this.Controls.Add(this.labelBrillo);
            this.Controls.Add(this.trackBarBrillo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Brillo";
            this.Text = "Brillo";
            this.Load += new System.EventHandler(this.Brillo_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Brillo_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrillo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarImagenToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBarBrillo;
        private System.Windows.Forms.Label labelBrillo;
    }
}

namespace ProcDigital1
{
    partial class Colorizar
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.labelValorTrackR = new System.Windows.Forms.Label();
            this.labelValorTrackB = new System.Windows.Forms.Label();
            this.labelValorTrackG = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "Colorizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirImagenToolStripMenuItem,
            this.salarImagenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(960, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abrirImagenToolStripMenuItem
            // 
            this.abrirImagenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarImagenToolStripMenuItem});
            this.abrirImagenToolStripMenuItem.Name = "abrirImagenToolStripMenuItem";
            this.abrirImagenToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.abrirImagenToolStripMenuItem.Text = "Abrir Imagen";
            this.abrirImagenToolStripMenuItem.Click += new System.EventHandler(this.abrirImagenToolStripMenuItem_Click);
            // 
            // salvarImagenToolStripMenuItem
            // 
            this.salvarImagenToolStripMenuItem.Name = "salvarImagenToolStripMenuItem";
            this.salvarImagenToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.salvarImagenToolStripMenuItem.Text = "Salvar imagen";
            // 
            // salarImagenToolStripMenuItem
            // 
            this.salarImagenToolStripMenuItem.Name = "salarImagenToolStripMenuItem";
            this.salarImagenToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.salarImagenToolStripMenuItem.Text = "Salar imagen";
            this.salarImagenToolStripMenuItem.Click += new System.EventHandler(this.salarImagenToolStripMenuItem_Click);
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
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(676, 294);
            this.trackBarRed.Maximum = 250;
            this.trackBarRed.Minimum = 1;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(222, 45);
            this.trackBarRed.TabIndex = 2;
            this.trackBarRed.Value = 2;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Red";
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(676, 446);
            this.trackBarBlue.Maximum = 250;
            this.trackBarBlue.Minimum = 1;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(222, 45);
            this.trackBarBlue.TabIndex = 2;
            this.trackBarBlue.Value = 2;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarBlue_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(635, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Blue";
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(676, 368);
            this.trackBarGreen.Maximum = 250;
            this.trackBarGreen.Minimum = 1;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(222, 45);
            this.trackBarGreen.TabIndex = 2;
            this.trackBarGreen.Value = 2;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarGreen_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(635, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Green";
            // 
            // labelValorTrackR
            // 
            this.labelValorTrackR.AutoSize = true;
            this.labelValorTrackR.Location = new System.Drawing.Point(759, 342);
            this.labelValorTrackR.Name = "labelValorTrackR";
            this.labelValorTrackR.Size = new System.Drawing.Size(31, 13);
            this.labelValorTrackR.TabIndex = 4;
            this.labelValorTrackR.Text = "Valor";
            // 
            // labelValorTrackB
            // 
            this.labelValorTrackB.AutoSize = true;
            this.labelValorTrackB.Location = new System.Drawing.Point(759, 494);
            this.labelValorTrackB.Name = "labelValorTrackB";
            this.labelValorTrackB.Size = new System.Drawing.Size(31, 13);
            this.labelValorTrackB.TabIndex = 4;
            this.labelValorTrackB.Text = "Valor";
            // 
            // labelValorTrackG
            // 
            this.labelValorTrackG.AutoSize = true;
            this.labelValorTrackG.Location = new System.Drawing.Point(759, 416);
            this.labelValorTrackG.Name = "labelValorTrackG";
            this.labelValorTrackG.Size = new System.Drawing.Size(31, 13);
            this.labelValorTrackG.TabIndex = 4;
            this.labelValorTrackG.Text = "Valor";
            // 
            // Colorizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 684);
            this.Controls.Add(this.labelValorTrackG);
            this.Controls.Add(this.labelValorTrackB);
            this.Controls.Add(this.labelValorTrackR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.trackBarRed);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Colorizar";
            this.Text = "Colorizar";
            this.Load += new System.EventHandler(this.Colorizar_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Colorizar_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirImagenToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelValorTrackR;
        private System.Windows.Forms.Label labelValorTrackB;
        private System.Windows.Forms.Label labelValorTrackG;
        private System.Windows.Forms.ToolStripMenuItem salvarImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salarImagenToolStripMenuItem;
    }
}
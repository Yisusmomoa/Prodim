
namespace ProcDigital1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtroColoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aberracionCromaticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gammaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convolucionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirCamaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarCamaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radioRed = new System.Windows.Forms.RadioButton();
            this.radioGreen = new System.Windows.Forms.RadioButton();
            this.radioBlue = new System.Windows.Forms.RadioButton();
            this.checkBoxRed = new System.Windows.Forms.CheckBox();
            this.checkBoxBlue = new System.Windows.Forms.CheckBox();
            this.checkBoxGreen = new System.Windows.Forms.CheckBox();
            this.tonosDeGrisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorizarGradienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.brilloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.basicosToolStripMenuItem,
            this.histogramasToolStripMenuItem,
            this.convolucionToolStripMenuItem,
            this.videoToolStripMenuItem,
            this.textToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1448, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirImagenToolStripMenuItem,
            this.salvarImagenToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirImagenToolStripMenuItem
            // 
            this.abrirImagenToolStripMenuItem.Name = "abrirImagenToolStripMenuItem";
            this.abrirImagenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirImagenToolStripMenuItem.Text = "Abrir Imagen";
            this.abrirImagenToolStripMenuItem.Click += new System.EventHandler(this.abrirImagenToolStripMenuItem_Click);
            // 
            // salvarImagenToolStripMenuItem
            // 
            this.salvarImagenToolStripMenuItem.Name = "salvarImagenToolStripMenuItem";
            this.salvarImagenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarImagenToolStripMenuItem.Text = "Salvar Imagen";
            this.salvarImagenToolStripMenuItem.Click += new System.EventHandler(this.salvarImagenToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // basicosToolStripMenuItem
            // 
            this.basicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.invertirToolStripMenuItem,
            this.filtroColoToolStripMenuItem,
            this.aberracionCromaticaToolStripMenuItem,
            this.gammaToolStripMenuItem,
            this.tonosDeGrisToolStripMenuItem,
            this.colorizarToolStripMenuItem,
            this.colorizarGradienteToolStripMenuItem,
            this.brilloToolStripMenuItem});
            this.basicosToolStripMenuItem.Name = "basicosToolStripMenuItem";
            this.basicosToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.basicosToolStripMenuItem.Text = "Basicos";
            this.basicosToolStripMenuItem.Click += new System.EventHandler(this.basicosToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // invertirToolStripMenuItem
            // 
            this.invertirToolStripMenuItem.Name = "invertirToolStripMenuItem";
            this.invertirToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.invertirToolStripMenuItem.Text = "Invertir";
            this.invertirToolStripMenuItem.Click += new System.EventHandler(this.invertirToolStripMenuItem_Click);
            // 
            // filtroColoToolStripMenuItem
            // 
            this.filtroColoToolStripMenuItem.Name = "filtroColoToolStripMenuItem";
            this.filtroColoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.filtroColoToolStripMenuItem.Text = "Filtro colo";
            this.filtroColoToolStripMenuItem.Click += new System.EventHandler(this.filtroColoToolStripMenuItem_Click);
            // 
            // aberracionCromaticaToolStripMenuItem
            // 
            this.aberracionCromaticaToolStripMenuItem.Name = "aberracionCromaticaToolStripMenuItem";
            this.aberracionCromaticaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.aberracionCromaticaToolStripMenuItem.Text = "AberracionCromatica";
            this.aberracionCromaticaToolStripMenuItem.Click += new System.EventHandler(this.aberracionCromaticaToolStripMenuItem_Click);
            // 
            // gammaToolStripMenuItem
            // 
            this.gammaToolStripMenuItem.Name = "gammaToolStripMenuItem";
            this.gammaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.gammaToolStripMenuItem.Text = "Gamma";
            this.gammaToolStripMenuItem.Click += new System.EventHandler(this.gammaToolStripMenuItem_Click);
            // 
            // histogramasToolStripMenuItem
            // 
            this.histogramasToolStripMenuItem.Name = "histogramasToolStripMenuItem";
            this.histogramasToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.histogramasToolStripMenuItem.Text = "Histogramas";
            // 
            // convolucionToolStripMenuItem
            // 
            this.convolucionToolStripMenuItem.Name = "convolucionToolStripMenuItem";
            this.convolucionToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.convolucionToolStripMenuItem.Text = "Convolucion";
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirCamaraToolStripMenuItem,
            this.cerrarCamaraToolStripMenuItem});
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            this.videoToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.videoToolStripMenuItem.Text = "Video";
            // 
            // abrirCamaraToolStripMenuItem
            // 
            this.abrirCamaraToolStripMenuItem.Name = "abrirCamaraToolStripMenuItem";
            this.abrirCamaraToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.abrirCamaraToolStripMenuItem.Text = "Abrir Camara";
            // 
            // cerrarCamaraToolStripMenuItem
            // 
            this.cerrarCamaraToolStripMenuItem.Name = "cerrarCamaraToolStripMenuItem";
            this.cerrarCamaraToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cerrarCamaraToolStripMenuItem.Text = "Cerrar Camara";
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.textToolStripMenuItem.Text = "Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1211, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Histograma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Imagen";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 506);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Original";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(548, 414);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(230, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(548, 441);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 314);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(793, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Camara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(724, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Camara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1136, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Red";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1136, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Blue";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1136, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Green";
            // 
            // radioRed
            // 
            this.radioRed.AutoSize = true;
            this.radioRed.Checked = true;
            this.radioRed.Location = new System.Drawing.Point(851, 141);
            this.radioRed.Name = "radioRed";
            this.radioRed.Size = new System.Drawing.Size(45, 17);
            this.radioRed.TabIndex = 10;
            this.radioRed.TabStop = true;
            this.radioRed.Text = "Red";
            this.radioRed.UseVisualStyleBackColor = true;
            this.radioRed.Visible = false;
            // 
            // radioGreen
            // 
            this.radioGreen.AutoSize = true;
            this.radioGreen.Location = new System.Drawing.Point(851, 176);
            this.radioGreen.Name = "radioGreen";
            this.radioGreen.Size = new System.Drawing.Size(54, 17);
            this.radioGreen.TabIndex = 10;
            this.radioGreen.Text = "Green";
            this.radioGreen.UseVisualStyleBackColor = true;
            this.radioGreen.Visible = false;
            // 
            // radioBlue
            // 
            this.radioBlue.AutoSize = true;
            this.radioBlue.Location = new System.Drawing.Point(851, 217);
            this.radioBlue.Name = "radioBlue";
            this.radioBlue.Size = new System.Drawing.Size(46, 17);
            this.radioBlue.TabIndex = 10;
            this.radioBlue.Text = "Blue";
            this.radioBlue.UseVisualStyleBackColor = true;
            this.radioBlue.Visible = false;
            // 
            // checkBoxRed
            // 
            this.checkBoxRed.AutoSize = true;
            this.checkBoxRed.Location = new System.Drawing.Point(720, 142);
            this.checkBoxRed.Name = "checkBoxRed";
            this.checkBoxRed.Size = new System.Drawing.Size(46, 17);
            this.checkBoxRed.TabIndex = 11;
            this.checkBoxRed.Text = "Red";
            this.checkBoxRed.UseVisualStyleBackColor = true;
            // 
            // checkBoxBlue
            // 
            this.checkBoxBlue.AutoSize = true;
            this.checkBoxBlue.Location = new System.Drawing.Point(720, 217);
            this.checkBoxBlue.Name = "checkBoxBlue";
            this.checkBoxBlue.Size = new System.Drawing.Size(47, 17);
            this.checkBoxBlue.TabIndex = 11;
            this.checkBoxBlue.Text = "Blue";
            this.checkBoxBlue.UseVisualStyleBackColor = true;
            // 
            // checkBoxGreen
            // 
            this.checkBoxGreen.AutoSize = true;
            this.checkBoxGreen.Location = new System.Drawing.Point(720, 177);
            this.checkBoxGreen.Name = "checkBoxGreen";
            this.checkBoxGreen.Size = new System.Drawing.Size(55, 17);
            this.checkBoxGreen.TabIndex = 11;
            this.checkBoxGreen.Text = "Green";
            this.checkBoxGreen.UseVisualStyleBackColor = true;
            // 
            // tonosDeGrisToolStripMenuItem
            // 
            this.tonosDeGrisToolStripMenuItem.Name = "tonosDeGrisToolStripMenuItem";
            this.tonosDeGrisToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.tonosDeGrisToolStripMenuItem.Text = "Tonos de gris";
            this.tonosDeGrisToolStripMenuItem.Click += new System.EventHandler(this.tonosDeGrisToolStripMenuItem_Click);
            // 
            // colorizarToolStripMenuItem
            // 
            this.colorizarToolStripMenuItem.Name = "colorizarToolStripMenuItem";
            this.colorizarToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.colorizarToolStripMenuItem.Text = "Colorizar";
            this.colorizarToolStripMenuItem.Click += new System.EventHandler(this.colorizarToolStripMenuItem_Click);
            // 
            // colorizarGradienteToolStripMenuItem
            // 
            this.colorizarGradienteToolStripMenuItem.Name = "colorizarGradienteToolStripMenuItem";
            this.colorizarGradienteToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.colorizarGradienteToolStripMenuItem.Text = "Colorizar gradiente";
            this.colorizarGradienteToolStripMenuItem.Click += new System.EventHandler(this.colorizarGradienteToolStripMenuItem_Click);
            // 
            // brilloToolStripMenuItem
            // 
            this.brilloToolStripMenuItem.Name = "brilloToolStripMenuItem";
            this.brilloToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.brilloToolStripMenuItem.Text = "Brillo";
            this.brilloToolStripMenuItem.Click += new System.EventHandler(this.brilloToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 762);
            this.Controls.Add(this.checkBoxGreen);
            this.Controls.Add(this.checkBoxBlue);
            this.Controls.Add(this.checkBoxRed);
            this.Controls.Add(this.radioBlue);
            this.Controls.Add(this.radioGreen);
            this.Controls.Add(this.radioRed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convolucionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirCamaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarCamaraToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem invertirToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem filtroColoToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioRed;
        private System.Windows.Forms.RadioButton radioGreen;
        private System.Windows.Forms.RadioButton radioBlue;
        private System.Windows.Forms.CheckBox checkBoxRed;
        private System.Windows.Forms.CheckBox checkBoxBlue;
        private System.Windows.Forms.CheckBox checkBoxGreen;
        private System.Windows.Forms.ToolStripMenuItem aberracionCromaticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gammaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tonosDeGrisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorizarGradienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brilloToolStripMenuItem;
    }
}


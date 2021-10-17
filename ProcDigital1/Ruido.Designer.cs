
namespace ProcDigital1
{
    partial class Ruido
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
            this.label11 = new System.Windows.Forms.Label();
            this.trackBarRMinimo = new System.Windows.Forms.TrackBar();
            this.trackBarRMaximo = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarPorcentaje = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelRMinimo = new System.Windows.Forms.Label();
            this.labelRMaximo = new System.Windows.Forms.Label();
            this.labelPorcentaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRMaximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPorcentaje)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(133, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Rango Minimo";
            // 
            // trackBarRMinimo
            // 
            this.trackBarRMinimo.Location = new System.Drawing.Point(214, 7);
            this.trackBarRMinimo.Maximum = 200;
            this.trackBarRMinimo.Name = "trackBarRMinimo";
            this.trackBarRMinimo.Size = new System.Drawing.Size(237, 45);
            this.trackBarRMinimo.TabIndex = 20;
            this.trackBarRMinimo.Scroll += new System.EventHandler(this.trackBarRMinimo_Scroll);
            // 
            // trackBarRMaximo
            // 
            this.trackBarRMaximo.Location = new System.Drawing.Point(214, 86);
            this.trackBarRMaximo.Maximum = 200;
            this.trackBarRMaximo.Name = "trackBarRMaximo";
            this.trackBarRMaximo.Size = new System.Drawing.Size(237, 45);
            this.trackBarRMaximo.TabIndex = 20;
            this.trackBarRMaximo.Scroll += new System.EventHandler(this.trackBarRMaximo_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Rango Maximo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // trackBarPorcentaje
            // 
            this.trackBarPorcentaje.Location = new System.Drawing.Point(214, 163);
            this.trackBarPorcentaje.Maximum = 100;
            this.trackBarPorcentaje.Minimum = 1;
            this.trackBarPorcentaje.Name = "trackBarPorcentaje";
            this.trackBarPorcentaje.Size = new System.Drawing.Size(237, 45);
            this.trackBarPorcentaje.TabIndex = 20;
            this.trackBarPorcentaje.Value = 1;
            this.trackBarPorcentaje.Scroll += new System.EventHandler(this.trackBarPorcentaje_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Porcentaje";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 87);
            this.button1.TabIndex = 22;
            this.button1.Text = "Aplicar ruido";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelRMinimo
            // 
            this.labelRMinimo.AutoSize = true;
            this.labelRMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRMinimo.Location = new System.Drawing.Point(321, 41);
            this.labelRMinimo.Name = "labelRMinimo";
            this.labelRMinimo.Size = new System.Drawing.Size(20, 22);
            this.labelRMinimo.TabIndex = 25;
            this.labelRMinimo.Text = "0";
            // 
            // labelRMaximo
            // 
            this.labelRMaximo.AutoSize = true;
            this.labelRMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRMaximo.Location = new System.Drawing.Point(321, 125);
            this.labelRMaximo.Name = "labelRMaximo";
            this.labelRMaximo.Size = new System.Drawing.Size(20, 22);
            this.labelRMaximo.TabIndex = 25;
            this.labelRMaximo.Text = "0";
            // 
            // labelPorcentaje
            // 
            this.labelPorcentaje.AutoSize = true;
            this.labelPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPorcentaje.Location = new System.Drawing.Point(321, 202);
            this.labelPorcentaje.Name = "labelPorcentaje";
            this.labelPorcentaje.Size = new System.Drawing.Size(20, 22);
            this.labelPorcentaje.TabIndex = 25;
            this.labelPorcentaje.Text = "0";
            // 
            // Ruido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(644, 350);
            this.Controls.Add(this.labelPorcentaje);
            this.Controls.Add(this.labelRMaximo);
            this.Controls.Add(this.labelRMinimo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.trackBarPorcentaje);
            this.Controls.Add(this.trackBarRMaximo);
            this.Controls.Add(this.trackBarRMinimo);
            this.Name = "Ruido";
            this.Text = "Ruido";
            this.Load += new System.EventHandler(this.Ruido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRMaximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPorcentaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar trackBarRMinimo;
        private System.Windows.Forms.TrackBar trackBarRMaximo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarPorcentaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelRMinimo;
        private System.Windows.Forms.Label labelRMaximo;
        private System.Windows.Forms.Label labelPorcentaje;
    }
}
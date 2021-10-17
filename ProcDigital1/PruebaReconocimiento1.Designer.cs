
namespace ProcDigital1
{
    partial class PruebaReconocimiento1
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
            this.btnDetect = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetect
            // 
            this.btnDetect.Location = new System.Drawing.Point(844, 188);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(104, 44);
            this.btnDetect.TabIndex = 0;
            this.btnDetect.Text = "button1";
            this.btnDetect.UseVisualStyleBackColor = true;
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(77, 51);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(720, 463);
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            // 
            // PruebaReconocimiento1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 591);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.btnDetect);
            this.Name = "PruebaReconocimiento1";
            this.Text = "PruebaReconocimiento1";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDetect;
        private System.Windows.Forms.PictureBox pic;
    }
}
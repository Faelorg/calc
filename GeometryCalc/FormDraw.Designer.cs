namespace GeometryCalc
{
    partial class FormDraw
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
            this.pcbDraw = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbDraw
            // 
            this.pcbDraw.Location = new System.Drawing.Point(12, 12);
            this.pcbDraw.Name = "pcbDraw";
            this.pcbDraw.Size = new System.Drawing.Size(776, 427);
            this.pcbDraw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDraw.TabIndex = 0;
            this.pcbDraw.TabStop = false;
            this.pcbDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbDraw_MouseDown);
            // 
            // FormDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pcbDraw);
            this.Name = "FormDraw";
            this.Text = "FormDraw";
            ((System.ComponentModel.ISupportInitialize)(this.pcbDraw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbDraw;
    }
}
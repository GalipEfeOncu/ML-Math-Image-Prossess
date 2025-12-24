namespace ML_Math_Image_Prossess
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            btnLoadPicture = new Button();
            btnFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(10, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(395, 395);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnLoadPicture
            // 
            btnLoadPicture.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLoadPicture.Location = new Point(10, 10);
            btnLoadPicture.Name = "btnLoadPicture";
            btnLoadPicture.Size = new Size(193, 40);
            btnLoadPicture.TabIndex = 1;
            btnLoadPicture.Text = "Load Picture";
            btnLoadPicture.UseVisualStyleBackColor = true;
            btnLoadPicture.Click += btnLoadPicture_Click;
            // 
            // btnFilter
            // 
            btnFilter.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFilter.Location = new Point(213, 10);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(193, 40);
            btnFilter.TabIndex = 2;
            btnFilter.Text = "ML Filter (Edge Detect)";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 466);
            Controls.Add(btnFilter);
            Controls.Add(btnLoadPicture);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnLoadPicture;
        private Button btnFilter;
    }
}

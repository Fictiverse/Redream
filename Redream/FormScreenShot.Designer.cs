namespace Redream
{

    partial class FormScreenShot
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(21, 21, 21);
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1, 1);
            label1.Name = "label1";
            label1.Size = new Size(48, 13);
            label1.TabIndex = 0;
            label1.Text = "512x512";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(50, 50, 50);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(510, 510);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseDown += FormScreenShot_MouseDown;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            pictureBox1.MouseMove += FormScreenShot_MouseMove;
            pictureBox1.MouseUp += FormScreenShot_MouseUp;
            // 
            // FormScreenShot
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(512, 512);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormScreenShot";
            Opacity = 0.1D;
            Padding = new Padding(1);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormScreenShot";
            LocationChanged += FormScreenShot_LocationChanged;
            SizeChanged += FormScreenShot_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
    }
}
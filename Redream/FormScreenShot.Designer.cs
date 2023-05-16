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
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Cursor = Cursors.Hand;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 40);
            label1.Name = "label1";
            label1.Size = new Size(510, 427);
            label1.TabIndex = 0;
            label1.Text = "512x512";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.MouseClick += FormScreenShot_MouseClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(21, 21, 21);
            panel1.Controls.Add(panel2);
            panel1.Cursor = Cursors.Hand;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 40, 0, 0);
            panel1.Size = new Size(510, 510);
            panel1.TabIndex = 1;
            panel1.MouseClick += FormScreenShot_MouseClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Maroon;
            panel2.Controls.Add(label1);
            panel2.Cursor = Cursors.Hand;
            panel2.Dock = DockStyle.Bottom;
            panel2.ForeColor = Color.Orange;
            panel2.Location = new Point(0, 43);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 40, 0, 0);
            panel2.Size = new Size(510, 467);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            panel2.MouseClick += FormScreenShot_MouseClick;
            // 
            // FormScreenShot
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(512, 512);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormScreenShot";
            Opacity = 0.3D;
            Padding = new Padding(1);
            Text = "FormScreenShot";
            SizeChanged += FormScreenShot_SizeChanged;
            MouseClick += FormScreenShot_MouseClick;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
    }
}
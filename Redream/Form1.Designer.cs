namespace Redream
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonStart = new Button();
            panelImage = new Panel();
            pictureBox1 = new PictureBox();
            panelMenu = new FlowLayoutPanel();
            buttonScreenshot = new Button();
            buttonBrowse = new Button();
            buttonSave = new Button();
            buttonShape = new Button();
            buttonSeed = new Button();
            buttonSteps = new Button();
            buttonStrength = new Button();
            buttonCFGScale = new Button();
            buttonSampler = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            buttonInterrogate = new Button();
            buttonDiscord = new Button();
            buttonFav = new Button();
            tableLayoutPanelPrompts = new TableLayoutPanel();
            buttonClearPromptN = new Button();
            panel1 = new Panel();
            textBoxPromptN = new TextBox();
            panelPrompt = new Panel();
            textBoxPrompt = new TextBox();
            buttonClearPrompt = new Button();
            tableLayoutPanelRightMenu = new TableLayoutPanel();
            buttonResize = new Button();
            buttonSettings = new Button();
            buttonDefaultSettings = new Button();
            timerFadeOut = new System.Windows.Forms.Timer(components);
            timerBlink = new System.Windows.Forms.Timer(components);
            toolTip1 = new ToolTip(components);
            tableLayoutPanel1.SuspendLayout();
            panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenu.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanelPrompts.SuspendLayout();
            panel1.SuspendLayout();
            panelPrompt.SuspendLayout();
            tableLayoutPanelRightMenu.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(27, 27, 27);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Controls.Add(buttonStart, 0, 0);
            tableLayoutPanel1.Controls.Add(panelImage, 1, 1);
            tableLayoutPanel1.Controls.Add(panelMenu, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Controls.Add(buttonInterrogate, 2, 0);
            tableLayoutPanel1.Controls.Add(buttonDiscord, 2, 2);
            tableLayoutPanel1.Controls.Add(buttonFav, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanelPrompts, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanelRightMenu, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(598, 618);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.FromArgb(85, 35, 25);
            buttonStart.Dock = DockStyle.Fill;
            buttonStart.FlatAppearance.BorderSize = 0;
            buttonStart.FlatStyle = FlatStyle.Flat;
            buttonStart.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStart.ForeColor = Color.Silver;
            buttonStart.Image = Properties.Resources.play;
            buttonStart.Location = new Point(0, 0);
            buttonStart.Margin = new Padding(0);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(40, 60);
            buttonStart.TabIndex = 3;
            toolTip1.SetToolTip(buttonStart, "Start / Stop");
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // panelImage
            // 
            panelImage.AutoScroll = true;
            panelImage.BackColor = Color.FromArgb(35, 35, 35);
            panelImage.Controls.Add(pictureBox1);
            panelImage.Dock = DockStyle.Fill;
            panelImage.Location = new Point(43, 63);
            panelImage.Name = "panelImage";
            panelImage.Size = new Size(512, 512);
            panelImage.TabIndex = 5;
            panelImage.MouseDown += panelImage_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(7, 7, 7);
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(512, 512);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(buttonScreenshot);
            panelMenu.Controls.Add(buttonBrowse);
            panelMenu.Controls.Add(buttonSave);
            panelMenu.Controls.Add(buttonShape);
            panelMenu.Controls.Add(buttonSeed);
            panelMenu.Controls.Add(buttonSteps);
            panelMenu.Controls.Add(buttonStrength);
            panelMenu.Controls.Add(buttonCFGScale);
            panelMenu.Controls.Add(buttonSampler);
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.Location = new Point(0, 63);
            panelMenu.Margin = new Padding(0, 3, 0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(40, 515);
            panelMenu.TabIndex = 7;
            // 
            // buttonScreenshot
            // 
            buttonScreenshot.BackColor = Color.FromArgb(85, 35, 25);
            buttonScreenshot.Cursor = Cursors.Hand;
            buttonScreenshot.FlatAppearance.BorderSize = 0;
            buttonScreenshot.FlatStyle = FlatStyle.Flat;
            buttonScreenshot.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonScreenshot.ForeColor = Color.Silver;
            buttonScreenshot.Image = Properties.Resources.selection;
            buttonScreenshot.Location = new Point(0, 0);
            buttonScreenshot.Margin = new Padding(0, 0, 0, 1);
            buttonScreenshot.Name = "buttonScreenshot";
            buttonScreenshot.Size = new Size(40, 40);
            buttonScreenshot.TabIndex = 103;
            buttonScreenshot.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(buttonScreenshot, "Capture Selector");
            buttonScreenshot.UseVisualStyleBackColor = false;
            buttonScreenshot.Click += buttonScreenshot_Click;
            // 
            // buttonBrowse
            // 
            buttonBrowse.BackColor = Color.FromArgb(85, 35, 25);
            buttonBrowse.Cursor = Cursors.Hand;
            buttonBrowse.FlatAppearance.BorderSize = 0;
            buttonBrowse.FlatStyle = FlatStyle.Flat;
            buttonBrowse.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBrowse.ForeColor = Color.Silver;
            buttonBrowse.Image = Properties.Resources.lecteur_video;
            buttonBrowse.Location = new Point(0, 42);
            buttonBrowse.Margin = new Padding(0, 1, 0, 3);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(40, 40);
            buttonBrowse.TabIndex = 110;
            buttonBrowse.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(buttonBrowse, "Open Frames Folder");
            buttonBrowse.UseVisualStyleBackColor = false;
            buttonBrowse.Visible = false;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(85, 35, 25);
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.ForeColor = Color.Silver;
            buttonSave.Image = Properties.Resources.save1;
            buttonSave.Location = new Point(0, 88);
            buttonSave.Margin = new Padding(0, 3, 0, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(40, 40);
            buttonSave.TabIndex = 105;
            buttonSave.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(buttonSave, "Save Frames");
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonShape
            // 
            buttonShape.BackColor = Color.FromArgb(60, 50, 40);
            buttonShape.Cursor = Cursors.Hand;
            buttonShape.FlatAppearance.BorderSize = 0;
            buttonShape.FlatStyle = FlatStyle.Flat;
            buttonShape.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonShape.ForeColor = Color.Silver;
            buttonShape.Image = Properties.Resources.rounded_black_square_shapeS_1;
            buttonShape.Location = new Point(0, 134);
            buttonShape.Margin = new Padding(0, 3, 0, 3);
            buttonShape.Name = "buttonShape";
            buttonShape.Size = new Size(40, 40);
            buttonShape.TabIndex = 104;
            buttonShape.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(buttonShape, "Aspect Ratio");
            buttonShape.UseVisualStyleBackColor = false;
            buttonShape.Click += buttonShape_Click;
            // 
            // buttonSeed
            // 
            buttonSeed.BackColor = Color.FromArgb(60, 30, 60);
            buttonSeed.Cursor = Cursors.Hand;
            buttonSeed.FlatAppearance.BorderSize = 0;
            buttonSeed.FlatStyle = FlatStyle.Flat;
            buttonSeed.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSeed.ForeColor = Color.Silver;
            buttonSeed.Image = Properties.Resources._16_dice;
            buttonSeed.ImageAlign = ContentAlignment.TopCenter;
            buttonSeed.Location = new Point(0, 180);
            buttonSeed.Margin = new Padding(0, 3, 0, 1);
            buttonSeed.Name = "buttonSeed";
            buttonSeed.Padding = new Padding(0, 6, 0, 6);
            buttonSeed.Size = new Size(40, 70);
            buttonSeed.TabIndex = 108;
            buttonSeed.Text = "-1";
            buttonSeed.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(buttonSeed, "Seed");
            buttonSeed.UseVisualStyleBackColor = false;
            buttonSeed.Click += buttonSeed_Click;
            // 
            // buttonSteps
            // 
            buttonSteps.BackColor = Color.FromArgb(60, 30, 60);
            buttonSteps.Cursor = Cursors.Hand;
            buttonSteps.FlatAppearance.BorderSize = 0;
            buttonSteps.FlatStyle = FlatStyle.Flat;
            buttonSteps.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSteps.ForeColor = Color.Silver;
            buttonSteps.Image = Properties.Resources.level2;
            buttonSteps.ImageAlign = ContentAlignment.TopCenter;
            buttonSteps.Location = new Point(0, 252);
            buttonSteps.Margin = new Padding(0, 1, 0, 1);
            buttonSteps.Name = "buttonSteps";
            buttonSteps.Padding = new Padding(0, 6, 0, 6);
            buttonSteps.Size = new Size(40, 70);
            buttonSteps.TabIndex = 106;
            buttonSteps.Text = "16";
            buttonSteps.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(buttonSteps, "Steps");
            buttonSteps.UseVisualStyleBackColor = false;
            buttonSteps.Click += buttonSteps_Click;
            // 
            // buttonStrength
            // 
            buttonStrength.BackColor = Color.FromArgb(60, 30, 60);
            buttonStrength.Cursor = Cursors.Hand;
            buttonStrength.FlatAppearance.BorderSize = 0;
            buttonStrength.FlatStyle = FlatStyle.Flat;
            buttonStrength.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStrength.ForeColor = Color.Silver;
            buttonStrength.Image = Properties.Resources._16_blur;
            buttonStrength.ImageAlign = ContentAlignment.TopCenter;
            buttonStrength.Location = new Point(0, 324);
            buttonStrength.Margin = new Padding(0, 1, 0, 1);
            buttonStrength.Name = "buttonStrength";
            buttonStrength.Padding = new Padding(0, 6, 0, 6);
            buttonStrength.Size = new Size(40, 70);
            buttonStrength.TabIndex = 107;
            buttonStrength.Text = "0.5";
            buttonStrength.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(buttonStrength, "Denoising Strength");
            buttonStrength.UseVisualStyleBackColor = false;
            buttonStrength.Click += buttonStrength_Click;
            // 
            // buttonCFGScale
            // 
            buttonCFGScale.BackColor = Color.FromArgb(60, 30, 60);
            buttonCFGScale.Cursor = Cursors.Hand;
            buttonCFGScale.FlatAppearance.BorderSize = 0;
            buttonCFGScale.FlatStyle = FlatStyle.Flat;
            buttonCFGScale.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCFGScale.ForeColor = Color.Silver;
            buttonCFGScale.Image = Properties.Resources._16_scale;
            buttonCFGScale.ImageAlign = ContentAlignment.TopCenter;
            buttonCFGScale.Location = new Point(0, 396);
            buttonCFGScale.Margin = new Padding(0, 1, 0, 1);
            buttonCFGScale.Name = "buttonCFGScale";
            buttonCFGScale.Padding = new Padding(0, 6, 0, 6);
            buttonCFGScale.Size = new Size(40, 70);
            buttonCFGScale.TabIndex = 109;
            buttonCFGScale.Text = "7.5";
            buttonCFGScale.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(buttonCFGScale, "CFG Scale");
            buttonCFGScale.UseVisualStyleBackColor = false;
            buttonCFGScale.Click += buttonCFGScale_Click;
            // 
            // buttonSampler
            // 
            buttonSampler.BackColor = Color.FromArgb(60, 30, 60);
            buttonSampler.Cursor = Cursors.Hand;
            buttonSampler.FlatAppearance.BorderSize = 0;
            buttonSampler.FlatStyle = FlatStyle.Flat;
            buttonSampler.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSampler.ForeColor = Color.Silver;
            buttonSampler.Image = Properties.Resources.network;
            buttonSampler.Location = new Point(0, 470);
            buttonSampler.Margin = new Padding(0, 3, 0, 0);
            buttonSampler.Name = "buttonSampler";
            buttonSampler.Size = new Size(40, 40);
            buttonSampler.TabIndex = 112;
            buttonSampler.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(buttonSampler, "Sampler : Euler");
            buttonSampler.UseVisualStyleBackColor = false;
            buttonSampler.Click += buttonSampler_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 10;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Controls.Add(button10, 9, 0);
            tableLayoutPanel2.Controls.Add(button9, 8, 0);
            tableLayoutPanel2.Controls.Add(button8, 7, 0);
            tableLayoutPanel2.Controls.Add(button7, 6, 0);
            tableLayoutPanel2.Controls.Add(button6, 5, 0);
            tableLayoutPanel2.Controls.Add(button5, 4, 0);
            tableLayoutPanel2.Controls.Add(button4, 3, 0);
            tableLayoutPanel2.Controls.Add(button3, 2, 0);
            tableLayoutPanel2.Controls.Add(button2, 1, 0);
            tableLayoutPanel2.Controls.Add(button1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(43, 578);
            tableLayoutPanel2.Margin = new Padding(3, 0, 3, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(512, 40);
            tableLayoutPanel2.TabIndex = 9;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(30, 50, 60);
            button10.Cursor = Cursors.Hand;
            button10.Dock = DockStyle.Fill;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button10.ForeColor = Color.Silver;
            button10.Location = new Point(460, 0);
            button10.Margin = new Padding(1, 0, 1, 0);
            button10.Name = "button10";
            button10.Size = new Size(51, 40);
            button10.TabIndex = 114;
            button10.Text = "10";
            toolTip1.SetToolTip(button10, "Slot 10");
            button10.UseVisualStyleBackColor = false;
            button10.Click += buttonM_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(30, 50, 60);
            button9.Cursor = Cursors.Hand;
            button9.Dock = DockStyle.Fill;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = Color.Silver;
            button9.Location = new Point(409, 0);
            button9.Margin = new Padding(1, 0, 1, 0);
            button9.Name = "button9";
            button9.Size = new Size(49, 40);
            button9.TabIndex = 113;
            button9.Text = "9";
            toolTip1.SetToolTip(button9, "Slot 9");
            button9.UseVisualStyleBackColor = false;
            button9.Click += buttonM_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(30, 50, 60);
            button8.Cursor = Cursors.Hand;
            button8.Dock = DockStyle.Fill;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.Silver;
            button8.Location = new Point(358, 0);
            button8.Margin = new Padding(1, 0, 1, 0);
            button8.Name = "button8";
            button8.Size = new Size(49, 40);
            button8.TabIndex = 112;
            button8.Text = "8";
            toolTip1.SetToolTip(button8, "Slot 8");
            button8.UseVisualStyleBackColor = false;
            button8.Click += buttonM_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(30, 50, 60);
            button7.Cursor = Cursors.Hand;
            button7.Dock = DockStyle.Fill;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.Silver;
            button7.Location = new Point(307, 0);
            button7.Margin = new Padding(1, 0, 1, 0);
            button7.Name = "button7";
            button7.Size = new Size(49, 40);
            button7.TabIndex = 111;
            button7.Text = "7";
            toolTip1.SetToolTip(button7, "Slot 7");
            button7.UseVisualStyleBackColor = false;
            button7.Click += buttonM_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(30, 50, 60);
            button6.Cursor = Cursors.Hand;
            button6.Dock = DockStyle.Fill;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.Silver;
            button6.Location = new Point(256, 0);
            button6.Margin = new Padding(1, 0, 1, 0);
            button6.Name = "button6";
            button6.Size = new Size(49, 40);
            button6.TabIndex = 110;
            button6.Text = "6";
            toolTip1.SetToolTip(button6, "Slot 6");
            button6.UseVisualStyleBackColor = false;
            button6.Click += buttonM_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(30, 50, 60);
            button5.Cursor = Cursors.Hand;
            button5.Dock = DockStyle.Fill;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.Silver;
            button5.Location = new Point(205, 0);
            button5.Margin = new Padding(1, 0, 1, 0);
            button5.Name = "button5";
            button5.Size = new Size(49, 40);
            button5.TabIndex = 109;
            button5.Text = "5";
            toolTip1.SetToolTip(button5, "Slot 5");
            button5.UseVisualStyleBackColor = false;
            button5.Click += buttonM_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(30, 50, 60);
            button4.Cursor = Cursors.Hand;
            button4.Dock = DockStyle.Fill;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Silver;
            button4.Location = new Point(154, 0);
            button4.Margin = new Padding(1, 0, 1, 0);
            button4.Name = "button4";
            button4.Size = new Size(49, 40);
            button4.TabIndex = 108;
            button4.Text = "4";
            toolTip1.SetToolTip(button4, "Slot 4");
            button4.UseVisualStyleBackColor = false;
            button4.Click += buttonM_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(30, 50, 60);
            button3.Cursor = Cursors.Hand;
            button3.Dock = DockStyle.Fill;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Silver;
            button3.Location = new Point(103, 0);
            button3.Margin = new Padding(1, 0, 1, 0);
            button3.Name = "button3";
            button3.Size = new Size(49, 40);
            button3.TabIndex = 107;
            button3.Text = "3";
            toolTip1.SetToolTip(button3, "Slot 3");
            button3.UseVisualStyleBackColor = false;
            button3.Click += buttonM_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(30, 50, 60);
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Silver;
            button2.Location = new Point(52, 0);
            button2.Margin = new Padding(1, 0, 1, 0);
            button2.Name = "button2";
            button2.Size = new Size(49, 40);
            button2.TabIndex = 106;
            button2.Text = "2";
            toolTip1.SetToolTip(button2, "Slot 2");
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonM_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(30, 50, 60);
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Silver;
            button1.Location = new Point(1, 0);
            button1.Margin = new Padding(1, 0, 1, 0);
            button1.Name = "button1";
            button1.Size = new Size(49, 40);
            button1.TabIndex = 105;
            button1.Text = "1";
            toolTip1.SetToolTip(button1, "Slot 1");
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonM_Click;
            // 
            // buttonInterrogate
            // 
            buttonInterrogate.BackColor = Color.FromArgb(30, 40, 60);
            buttonInterrogate.Dock = DockStyle.Fill;
            buttonInterrogate.FlatAppearance.BorderSize = 0;
            buttonInterrogate.FlatStyle = FlatStyle.Flat;
            buttonInterrogate.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonInterrogate.ForeColor = Color.Silver;
            buttonInterrogate.Image = Properties.Resources.text;
            buttonInterrogate.Location = new Point(558, 0);
            buttonInterrogate.Margin = new Padding(0);
            buttonInterrogate.Name = "buttonInterrogate";
            buttonInterrogate.Size = new Size(40, 60);
            buttonInterrogate.TabIndex = 10;
            toolTip1.SetToolTip(buttonInterrogate, "Interrogate Image");
            buttonInterrogate.UseVisualStyleBackColor = false;
            buttonInterrogate.Click += buttonInterrogate_Click;
            // 
            // buttonDiscord
            // 
            buttonDiscord.BackColor = Color.FromArgb(25, 15, 50);
            buttonDiscord.Dock = DockStyle.Fill;
            buttonDiscord.FlatAppearance.BorderSize = 0;
            buttonDiscord.FlatStyle = FlatStyle.Flat;
            buttonDiscord.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDiscord.ForeColor = Color.Silver;
            buttonDiscord.Image = Properties.Resources.discord;
            buttonDiscord.Location = new Point(558, 578);
            buttonDiscord.Margin = new Padding(0);
            buttonDiscord.Name = "buttonDiscord";
            buttonDiscord.Size = new Size(40, 40);
            buttonDiscord.TabIndex = 109;
            toolTip1.SetToolTip(buttonDiscord, "Discord");
            buttonDiscord.UseVisualStyleBackColor = false;
            buttonDiscord.Click += buttonDiscord_Click;
            // 
            // buttonFav
            // 
            buttonFav.BackColor = Color.FromArgb(85, 35, 25);
            buttonFav.Dock = DockStyle.Fill;
            buttonFav.FlatAppearance.BorderSize = 0;
            buttonFav.FlatStyle = FlatStyle.Flat;
            buttonFav.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFav.ForeColor = Color.Silver;
            buttonFav.Image = Properties.Resources.favourite;
            buttonFav.Location = new Point(0, 578);
            buttonFav.Margin = new Padding(0);
            buttonFav.Name = "buttonFav";
            buttonFav.Size = new Size(40, 40);
            buttonFav.TabIndex = 8;
            toolTip1.SetToolTip(buttonFav, "Add prompt to fav");
            buttonFav.UseVisualStyleBackColor = false;
            buttonFav.Click += buttonFav_Click;
            // 
            // tableLayoutPanelPrompts
            // 
            tableLayoutPanelPrompts.ColumnCount = 2;
            tableLayoutPanelPrompts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelPrompts.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanelPrompts.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelPrompts.Controls.Add(buttonClearPromptN, 1, 1);
            tableLayoutPanelPrompts.Controls.Add(panel1, 0, 1);
            tableLayoutPanelPrompts.Controls.Add(panelPrompt, 0, 0);
            tableLayoutPanelPrompts.Controls.Add(buttonClearPrompt, 1, 0);
            tableLayoutPanelPrompts.Dock = DockStyle.Fill;
            tableLayoutPanelPrompts.Location = new Point(40, 0);
            tableLayoutPanelPrompts.Margin = new Padding(0, 0, 3, 0);
            tableLayoutPanelPrompts.Name = "tableLayoutPanelPrompts";
            tableLayoutPanelPrompts.RowCount = 2;
            tableLayoutPanelPrompts.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelPrompts.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelPrompts.Size = new Size(515, 60);
            tableLayoutPanelPrompts.TabIndex = 110;
            // 
            // buttonClearPromptN
            // 
            buttonClearPromptN.BackColor = Color.FromArgb(85, 35, 25);
            buttonClearPromptN.Cursor = Cursors.Hand;
            buttonClearPromptN.Dock = DockStyle.Fill;
            buttonClearPromptN.FlatAppearance.BorderSize = 0;
            buttonClearPromptN.FlatStyle = FlatStyle.Flat;
            buttonClearPromptN.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClearPromptN.ForeColor = Color.Silver;
            buttonClearPromptN.Image = Properties.Resources.delete_cross;
            buttonClearPromptN.Location = new Point(485, 30);
            buttonClearPromptN.Margin = new Padding(0);
            buttonClearPromptN.Name = "buttonClearPromptN";
            buttonClearPromptN.Size = new Size(30, 30);
            buttonClearPromptN.TabIndex = 107;
            buttonClearPromptN.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(buttonClearPromptN, "Clear Negative Prompt");
            buttonClearPromptN.UseVisualStyleBackColor = false;
            buttonClearPromptN.Click += buttonClearPromptN_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 13, 13);
            panel1.Controls.Add(textBoxPromptN);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 30);
            panel1.Margin = new Padding(3, 0, 3, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(6, 7, 6, 0);
            panel1.Size = new Size(479, 30);
            panel1.TabIndex = 6;
            // 
            // textBoxPromptN
            // 
            textBoxPromptN.BackColor = Color.FromArgb(33, 13, 13);
            textBoxPromptN.BorderStyle = BorderStyle.None;
            textBoxPromptN.Dock = DockStyle.Fill;
            textBoxPromptN.ForeColor = Color.Silver;
            textBoxPromptN.Location = new Point(6, 7);
            textBoxPromptN.Margin = new Padding(3, 0, 3, 3);
            textBoxPromptN.Name = "textBoxPromptN";
            textBoxPromptN.Size = new Size(467, 16);
            textBoxPromptN.TabIndex = 0;
            textBoxPromptN.Text = "Ugly";
            // 
            // panelPrompt
            // 
            panelPrompt.BackColor = Color.FromArgb(13, 33, 13);
            panelPrompt.Controls.Add(textBoxPrompt);
            panelPrompt.Dock = DockStyle.Fill;
            panelPrompt.Location = new Point(3, 0);
            panelPrompt.Margin = new Padding(3, 0, 3, 0);
            panelPrompt.Name = "panelPrompt";
            panelPrompt.Padding = new Padding(6, 7, 6, 0);
            panelPrompt.Size = new Size(479, 30);
            panelPrompt.TabIndex = 5;
            // 
            // textBoxPrompt
            // 
            textBoxPrompt.BackColor = Color.FromArgb(13, 33, 13);
            textBoxPrompt.BorderStyle = BorderStyle.None;
            textBoxPrompt.Dock = DockStyle.Fill;
            textBoxPrompt.ForeColor = Color.Silver;
            textBoxPrompt.Location = new Point(6, 7);
            textBoxPrompt.Margin = new Padding(3, 0, 3, 3);
            textBoxPrompt.Name = "textBoxPrompt";
            textBoxPrompt.Size = new Size(467, 16);
            textBoxPrompt.TabIndex = 0;
            textBoxPrompt.Text = "Visual Novel";
            // 
            // buttonClearPrompt
            // 
            buttonClearPrompt.BackColor = Color.FromArgb(85, 35, 25);
            buttonClearPrompt.Cursor = Cursors.Hand;
            buttonClearPrompt.Dock = DockStyle.Fill;
            buttonClearPrompt.FlatAppearance.BorderSize = 0;
            buttonClearPrompt.FlatStyle = FlatStyle.Flat;
            buttonClearPrompt.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClearPrompt.ForeColor = Color.Silver;
            buttonClearPrompt.Image = Properties.Resources.delete_cross;
            buttonClearPrompt.Location = new Point(485, 0);
            buttonClearPrompt.Margin = new Padding(0);
            buttonClearPrompt.Name = "buttonClearPrompt";
            buttonClearPrompt.Size = new Size(30, 30);
            buttonClearPrompt.TabIndex = 105;
            buttonClearPrompt.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(buttonClearPrompt, "Clear Positive Prompt");
            buttonClearPrompt.UseVisualStyleBackColor = false;
            buttonClearPrompt.Click += buttonClearPrompt_Click;
            // 
            // tableLayoutPanelRightMenu
            // 
            tableLayoutPanelRightMenu.ColumnCount = 1;
            tableLayoutPanelRightMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelRightMenu.Controls.Add(buttonResize, 0, 0);
            tableLayoutPanelRightMenu.Controls.Add(buttonSettings, 0, 2);
            tableLayoutPanelRightMenu.Controls.Add(buttonDefaultSettings, 0, 1);
            tableLayoutPanelRightMenu.Dock = DockStyle.Fill;
            tableLayoutPanelRightMenu.Location = new Point(558, 60);
            tableLayoutPanelRightMenu.Margin = new Padding(0);
            tableLayoutPanelRightMenu.Name = "tableLayoutPanelRightMenu";
            tableLayoutPanelRightMenu.RowCount = 3;
            tableLayoutPanelRightMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelRightMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanelRightMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanelRightMenu.Size = new Size(40, 518);
            tableLayoutPanelRightMenu.TabIndex = 111;
            // 
            // buttonResize
            // 
            buttonResize.BackColor = Color.FromArgb(13, 13, 13);
            buttonResize.Dock = DockStyle.Fill;
            buttonResize.FlatAppearance.BorderSize = 0;
            buttonResize.FlatStyle = FlatStyle.Flat;
            buttonResize.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonResize.ForeColor = Color.Silver;
            buttonResize.Image = Properties.Resources.flip;
            buttonResize.Location = new Point(0, 3);
            buttonResize.Margin = new Padding(0, 3, 0, 3);
            buttonResize.Name = "buttonResize";
            buttonResize.Size = new Size(40, 426);
            buttonResize.TabIndex = 12;
            toolTip1.SetToolTip(buttonResize, "Resize");
            buttonResize.UseVisualStyleBackColor = false;
            buttonResize.Click += buttonResize_Click;
            buttonResize.MouseDown += buttonResize_MouseDown;
            buttonResize.MouseMove += buttonResize_MouseMove;
            buttonResize.MouseUp += buttonResize_MouseUp;
            // 
            // buttonSettings
            // 
            buttonSettings.BackColor = Color.FromArgb(13, 13, 13);
            buttonSettings.FlatAppearance.BorderSize = 0;
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSettings.ForeColor = Color.Silver;
            buttonSettings.Image = Properties.Resources._16_menu;
            buttonSettings.Location = new Point(0, 475);
            buttonSettings.Margin = new Padding(0, 0, 0, 3);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(40, 40);
            buttonSettings.TabIndex = 110;
            toolTip1.SetToolTip(buttonSettings, "Settings");
            buttonSettings.UseVisualStyleBackColor = false;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // buttonDefaultSettings
            // 
            buttonDefaultSettings.BackColor = Color.FromArgb(85, 35, 25);
            buttonDefaultSettings.Cursor = Cursors.Hand;
            buttonDefaultSettings.Enabled = false;
            buttonDefaultSettings.FlatAppearance.BorderSize = 0;
            buttonDefaultSettings.FlatStyle = FlatStyle.Flat;
            buttonDefaultSettings.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDefaultSettings.ForeColor = Color.Silver;
            buttonDefaultSettings.Image = Properties.Resources._16_process;
            buttonDefaultSettings.Location = new Point(0, 435);
            buttonDefaultSettings.Margin = new Padding(0, 3, 0, 0);
            buttonDefaultSettings.Name = "buttonDefaultSettings";
            buttonDefaultSettings.Size = new Size(40, 40);
            buttonDefaultSettings.TabIndex = 111;
            buttonDefaultSettings.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(buttonDefaultSettings, "Use WebUI Settings");
            buttonDefaultSettings.UseVisualStyleBackColor = false;
            buttonDefaultSettings.Click += buttonDefaultSettings_Click;
            // 
            // timerFadeOut
            // 
            timerFadeOut.Interval = 20;
            timerFadeOut.Tick += timerFadeOut_Tick;
            // 
            // timerBlink
            // 
            timerBlink.Interval = 500;
            timerBlink.Tick += timerBlink_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 15, 35);
            ClientSize = new Size(598, 618);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(614, 657);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fictiverse : Redream";
            TopMost = true;
            tableLayoutPanel1.ResumeLayout(false);
            panelImage.ResumeLayout(false);
            panelImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanelPrompts.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelPrompt.ResumeLayout(false);
            panelPrompt.PerformLayout();
            tableLayoutPanelRightMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonStart;
        private Panel panelImage;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerFadeOut;
        private FlowLayoutPanel panelMenu;
        private Button buttonScreenshot;
        private Button buttonShape;
        private Button buttonSave;
        private Button buttonFav;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private System.Windows.Forms.Timer timerBlink;
        private Button buttonSteps;
        private Button buttonStrength;
        private ToolTip toolTip1;
        private Button buttonSeed;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonInterrogate;
        private Button buttonDiscord;
        private Button buttonCFGScale;
        private Button buttonBrowse;
        private TableLayoutPanel tableLayoutPanelPrompts;
        private Panel panel1;
        private TextBox textBoxPromptN;
        private Panel panelPrompt;
        private TextBox textBoxPrompt;
        private Button buttonClearPromptN;
        private Button buttonClearPrompt;
        private TableLayoutPanel tableLayoutPanelRightMenu;
        private Button buttonSettings;
        private Button buttonResize;
        private Button buttonDefaultSettings;
        private Button buttonSampler;
    }
}
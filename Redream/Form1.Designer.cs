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
            panelMain = new TableLayoutPanel();
            panelLeft = new TableLayoutPanel();
            buttonSampler = new Button();
            buttonCFGScale = new Button();
            buttonStrength = new Button();
            buttonSteps = new Button();
            buttonSeed = new Button();
            buttonNormSize = new Button();
            buttonShape = new Button();
            buttonMask = new Button();
            buttonScreenshot = new Button();
            buttonStart = new Button();
            buttonSettings = new Button();
            buttonInterrogate = new Button();
            buttonFav = new Button();
            panelTop = new TableLayoutPanel();
            buttonClearPromptN = new Button();
            panel1 = new Panel();
            textBoxPromptN = new TextBox();
            panelPrompt = new Panel();
            textBoxPrompt = new TextBox();
            buttonClearPrompt = new Button();
            panelRight = new TableLayoutPanel();
            buttonResize = new Button();
            buttonSave = new Button();
            buttonCopy = new Button();
            buttonBrowse = new Button();
            panelCenter = new TableLayoutPanel();
            panelImage = new Panel();
            pictureBox1 = new PictureBox();
            panelBottom = new TableLayoutPanel();
            panelM = new TableLayoutPanel();
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
            panelPlayer = new TableLayoutPanel();
            buttonPlay = new Button();
            colorTrackBarPlayer = new ColorTrackBar();
            buttonSaveFrames = new Button();
            buttonDelete = new Button();
            timerFadeOut = new System.Windows.Forms.Timer(components);
            timerBlink = new System.Windows.Forms.Timer(components);
            toolTip1 = new ToolTip(components);
            timerPlayer = new System.Windows.Forms.Timer(components);
            panelMain.SuspendLayout();
            panelLeft.SuspendLayout();
            panelTop.SuspendLayout();
            panel1.SuspendLayout();
            panelPrompt.SuspendLayout();
            panelRight.SuspendLayout();
            panelCenter.SuspendLayout();
            panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBottom.SuspendLayout();
            panelM.SuspendLayout();
            panelPlayer.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(27, 27, 27);
            panelMain.ColumnCount = 3;
            panelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            panelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            panelMain.Controls.Add(panelLeft, 0, 1);
            panelMain.Controls.Add(buttonStart, 0, 0);
            panelMain.Controls.Add(buttonSettings, 2, 2);
            panelMain.Controls.Add(buttonInterrogate, 2, 0);
            panelMain.Controls.Add(buttonFav, 0, 2);
            panelMain.Controls.Add(panelTop, 1, 0);
            panelMain.Controls.Add(panelRight, 2, 1);
            panelMain.Controls.Add(panelCenter, 1, 1);
            panelMain.Controls.Add(panelBottom, 1, 2);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.RowCount = 3;
            panelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            panelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            panelMain.Size = new Size(598, 681);
            panelMain.TabIndex = 0;
            // 
            // panelLeft
            // 
            panelLeft.ColumnCount = 1;
            panelLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelLeft.Controls.Add(buttonSampler, 0, 15);
            panelLeft.Controls.Add(buttonCFGScale, 0, 13);
            panelLeft.Controls.Add(buttonStrength, 0, 11);
            panelLeft.Controls.Add(buttonSteps, 0, 9);
            panelLeft.Controls.Add(buttonSeed, 0, 7);
            panelLeft.Controls.Add(buttonNormSize, 0, 5);
            panelLeft.Controls.Add(buttonShape, 0, 4);
            panelLeft.Controls.Add(buttonMask, 0, 2);
            panelLeft.Controls.Add(buttonScreenshot, 0, 0);
            panelLeft.Dock = DockStyle.Fill;
            panelLeft.Location = new Point(0, 83);
            panelLeft.Margin = new Padding(0, 3, 0, 3);
            panelLeft.Name = "panelLeft";
            panelLeft.RowCount = 16;
            panelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            panelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 3F));
            panelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            panelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            panelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            panelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            panelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            panelLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            panelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            panelLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            panelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            panelLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            panelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            panelLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            panelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            panelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            panelLeft.Size = new Size(40, 515);
            panelLeft.TabIndex = 2;
            // 
            // buttonSampler
            // 
            buttonSampler.BackColor = Color.FromArgb(50, 30, 60);
            buttonSampler.Cursor = Cursors.Hand;
            buttonSampler.Dock = DockStyle.Fill;
            buttonSampler.FlatAppearance.BorderSize = 0;
            buttonSampler.FlatStyle = FlatStyle.Flat;
            buttonSampler.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSampler.ForeColor = Color.Silver;
            buttonSampler.Image = Properties.Resources.network;
            buttonSampler.Location = new Point(0, 475);
            buttonSampler.Margin = new Padding(0);
            buttonSampler.Name = "buttonSampler";
            buttonSampler.Size = new Size(40, 40);
            buttonSampler.TabIndex = 112;
            buttonSampler.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(buttonSampler, "Sampler : Euler");
            buttonSampler.UseVisualStyleBackColor = false;
            buttonSampler.Click += buttonSampler_Click;
            // 
            // buttonCFGScale
            // 
            buttonCFGScale.BackColor = Color.FromArgb(60, 30, 60);
            buttonCFGScale.Cursor = Cursors.Hand;
            buttonCFGScale.Dock = DockStyle.Fill;
            buttonCFGScale.FlatAppearance.BorderSize = 0;
            buttonCFGScale.FlatStyle = FlatStyle.Flat;
            buttonCFGScale.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCFGScale.ForeColor = Color.Silver;
            buttonCFGScale.Image = Properties.Resources._16_scale;
            buttonCFGScale.ImageAlign = ContentAlignment.TopCenter;
            buttonCFGScale.Location = new Point(0, 398);
            buttonCFGScale.Margin = new Padding(0, 1, 0, 0);
            buttonCFGScale.Name = "buttonCFGScale";
            buttonCFGScale.Padding = new Padding(0, 6, 0, 6);
            buttonCFGScale.Size = new Size(40, 65);
            buttonCFGScale.TabIndex = 109;
            buttonCFGScale.Text = "7.5";
            buttonCFGScale.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(buttonCFGScale, "CFG Scale");
            buttonCFGScale.UseVisualStyleBackColor = false;
            buttonCFGScale.Click += buttonCFGScale_Click;
            // 
            // buttonStrength
            // 
            buttonStrength.BackColor = Color.FromArgb(60, 30, 60);
            buttonStrength.Cursor = Cursors.Hand;
            buttonStrength.Dock = DockStyle.Fill;
            buttonStrength.FlatAppearance.BorderSize = 0;
            buttonStrength.FlatStyle = FlatStyle.Flat;
            buttonStrength.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStrength.ForeColor = Color.Silver;
            buttonStrength.Image = Properties.Resources._16_blur;
            buttonStrength.ImageAlign = ContentAlignment.TopCenter;
            buttonStrength.Location = new Point(0, 326);
            buttonStrength.Margin = new Padding(0, 1, 0, 1);
            buttonStrength.Name = "buttonStrength";
            buttonStrength.Padding = new Padding(0, 6, 0, 6);
            buttonStrength.Size = new Size(40, 64);
            buttonStrength.TabIndex = 107;
            buttonStrength.Text = "0.5";
            buttonStrength.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(buttonStrength, "Denoising Strength");
            buttonStrength.UseVisualStyleBackColor = false;
            buttonStrength.Click += buttonStrength_Click;
            // 
            // buttonSteps
            // 
            buttonSteps.BackColor = Color.FromArgb(60, 30, 60);
            buttonSteps.Cursor = Cursors.Hand;
            buttonSteps.Dock = DockStyle.Fill;
            buttonSteps.FlatAppearance.BorderSize = 0;
            buttonSteps.FlatStyle = FlatStyle.Flat;
            buttonSteps.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSteps.ForeColor = Color.Silver;
            buttonSteps.Image = Properties.Resources.level2;
            buttonSteps.ImageAlign = ContentAlignment.TopCenter;
            buttonSteps.Location = new Point(0, 254);
            buttonSteps.Margin = new Padding(0, 1, 0, 1);
            buttonSteps.Name = "buttonSteps";
            buttonSteps.Padding = new Padding(0, 6, 0, 6);
            buttonSteps.Size = new Size(40, 64);
            buttonSteps.TabIndex = 106;
            buttonSteps.Text = "16";
            buttonSteps.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(buttonSteps, "Steps");
            buttonSteps.UseVisualStyleBackColor = false;
            buttonSteps.Click += buttonSteps_Click;
            // 
            // buttonSeed
            // 
            buttonSeed.BackColor = Color.FromArgb(60, 30, 60);
            buttonSeed.Cursor = Cursors.Hand;
            buttonSeed.Dock = DockStyle.Fill;
            buttonSeed.FlatAppearance.BorderSize = 0;
            buttonSeed.FlatStyle = FlatStyle.Flat;
            buttonSeed.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSeed.ForeColor = Color.Silver;
            buttonSeed.Image = Properties.Resources._16_dice;
            buttonSeed.ImageAlign = ContentAlignment.TopCenter;
            buttonSeed.Location = new Point(0, 181);
            buttonSeed.Margin = new Padding(0, 0, 0, 1);
            buttonSeed.Name = "buttonSeed";
            buttonSeed.Padding = new Padding(0, 6, 0, 6);
            buttonSeed.Size = new Size(40, 65);
            buttonSeed.TabIndex = 108;
            buttonSeed.Text = "-1";
            buttonSeed.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(buttonSeed, "Seed");
            buttonSeed.UseVisualStyleBackColor = false;
            buttonSeed.Click += buttonSeed_Click;
            // 
            // buttonNormSize
            // 
            buttonNormSize.BackColor = Color.FromArgb(85, 35, 25);
            buttonNormSize.Cursor = Cursors.Hand;
            buttonNormSize.Dock = DockStyle.Fill;
            buttonNormSize.FlatAppearance.BorderSize = 0;
            buttonNormSize.FlatStyle = FlatStyle.Flat;
            buttonNormSize.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNormSize.ForeColor = Color.Silver;
            buttonNormSize.Image = Properties.Resources._16_resize;
            buttonNormSize.Location = new Point(0, 130);
            buttonNormSize.Margin = new Padding(0, 1, 0, 0);
            buttonNormSize.Name = "buttonNormSize";
            buttonNormSize.Size = new Size(40, 39);
            buttonNormSize.TabIndex = 110;
            buttonNormSize.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(buttonNormSize, "Normalize Size");
            buttonNormSize.UseVisualStyleBackColor = false;
            buttonNormSize.Click += buttonNormSize_Click;
            // 
            // buttonShape
            // 
            buttonShape.BackColor = Color.FromArgb(40, 60, 80);
            buttonShape.Cursor = Cursors.Hand;
            buttonShape.Dock = DockStyle.Fill;
            buttonShape.FlatAppearance.BorderSize = 0;
            buttonShape.FlatStyle = FlatStyle.Flat;
            buttonShape.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonShape.ForeColor = Color.Silver;
            buttonShape.Image = Properties.Resources.rounded_black_square_shapeS_1;
            buttonShape.Location = new Point(0, 89);
            buttonShape.Margin = new Padding(0, 0, 0, 1);
            buttonShape.Name = "buttonShape";
            buttonShape.Size = new Size(40, 39);
            buttonShape.TabIndex = 104;
            buttonShape.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(buttonShape, "Aspect Ratio");
            buttonShape.UseVisualStyleBackColor = false;
            buttonShape.Click += buttonShape_Click;
            // 
            // buttonMask
            // 
            buttonMask.BackColor = Color.FromArgb(25, 85, 35);
            buttonMask.Cursor = Cursors.Hand;
            buttonMask.Dock = DockStyle.Fill;
            buttonMask.FlatAppearance.BorderSize = 0;
            buttonMask.FlatStyle = FlatStyle.Flat;
            buttonMask.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMask.ForeColor = Color.Silver;
            buttonMask.Image = Properties.Resources.mask;
            buttonMask.Location = new Point(0, 43);
            buttonMask.Margin = new Padding(0);
            buttonMask.Name = "buttonMask";
            buttonMask.Size = new Size(40, 40);
            buttonMask.TabIndex = 111;
            buttonMask.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(buttonMask, "Inpaint Mask");
            buttonMask.UseVisualStyleBackColor = false;
            buttonMask.Click += buttonMask_Click;
            // 
            // buttonScreenshot
            // 
            buttonScreenshot.BackColor = Color.FromArgb(85, 35, 25);
            buttonScreenshot.Cursor = Cursors.Hand;
            buttonScreenshot.Dock = DockStyle.Fill;
            buttonScreenshot.FlatAppearance.BorderSize = 0;
            buttonScreenshot.FlatStyle = FlatStyle.Flat;
            buttonScreenshot.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonScreenshot.ForeColor = Color.Silver;
            buttonScreenshot.Image = Properties.Resources.selection;
            buttonScreenshot.Location = new Point(0, 0);
            buttonScreenshot.Margin = new Padding(0);
            buttonScreenshot.Name = "buttonScreenshot";
            buttonScreenshot.Size = new Size(40, 40);
            buttonScreenshot.TabIndex = 103;
            buttonScreenshot.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(buttonScreenshot, "Capture Selector");
            buttonScreenshot.UseVisualStyleBackColor = false;
            buttonScreenshot.Click += buttonScreenshot_Click;
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
            buttonStart.Size = new Size(40, 80);
            buttonStart.TabIndex = 3;
            toolTip1.SetToolTip(buttonStart, "Start / Stop");
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.BackColor = Color.FromArgb(43, 43, 43);
            buttonSettings.Dock = DockStyle.Fill;
            buttonSettings.FlatAppearance.BorderSize = 0;
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSettings.ForeColor = Color.Silver;
            buttonSettings.Image = Properties.Resources._16_menu;
            buttonSettings.Location = new Point(558, 601);
            buttonSettings.Margin = new Padding(0);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(40, 80);
            buttonSettings.TabIndex = 110;
            toolTip1.SetToolTip(buttonSettings, "Settings");
            buttonSettings.UseVisualStyleBackColor = false;
            buttonSettings.Click += buttonSettings_Click;
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
            buttonInterrogate.Size = new Size(40, 80);
            buttonInterrogate.TabIndex = 10;
            toolTip1.SetToolTip(buttonInterrogate, "Interrogate Image");
            buttonInterrogate.UseVisualStyleBackColor = false;
            buttonInterrogate.Click += buttonInterrogate_Click;
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
            buttonFav.Location = new Point(0, 601);
            buttonFav.Margin = new Padding(0);
            buttonFav.Name = "buttonFav";
            buttonFav.Size = new Size(40, 80);
            buttonFav.TabIndex = 8;
            toolTip1.SetToolTip(buttonFav, "Add prompt to fav");
            buttonFav.UseVisualStyleBackColor = false;
            buttonFav.Click += buttonFav_Click;
            // 
            // panelTop
            // 
            panelTop.ColumnCount = 2;
            panelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            panelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            panelTop.Controls.Add(buttonClearPromptN, 1, 1);
            panelTop.Controls.Add(panel1, 0, 1);
            panelTop.Controls.Add(panelPrompt, 0, 0);
            panelTop.Controls.Add(buttonClearPrompt, 1, 0);
            panelTop.Dock = DockStyle.Fill;
            panelTop.Location = new Point(40, 0);
            panelTop.Margin = new Padding(0, 0, 3, 0);
            panelTop.Name = "panelTop";
            panelTop.RowCount = 2;
            panelTop.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelTop.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelTop.Size = new Size(515, 80);
            panelTop.TabIndex = 110;
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
            buttonClearPromptN.Location = new Point(485, 41);
            buttonClearPromptN.Margin = new Padding(0, 1, 0, 0);
            buttonClearPromptN.Name = "buttonClearPromptN";
            buttonClearPromptN.Size = new Size(30, 39);
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
            panel1.Location = new Point(3, 40);
            panel1.Margin = new Padding(3, 0, 3, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(6, 7, 6, 0);
            panel1.Size = new Size(479, 40);
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
            textBoxPromptN.Text = "deformed, bad art, ugly, disfigured";
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
            panelPrompt.Size = new Size(479, 40);
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
            textBoxPrompt.Text = "cartoon 3d pixar disney character, miniature, model, claymation";
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
            buttonClearPrompt.Margin = new Padding(0, 0, 0, 1);
            buttonClearPrompt.Name = "buttonClearPrompt";
            buttonClearPrompt.Size = new Size(30, 39);
            buttonClearPrompt.TabIndex = 105;
            buttonClearPrompt.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(buttonClearPrompt, "Clear Positive Prompt");
            buttonClearPrompt.UseVisualStyleBackColor = false;
            buttonClearPrompt.Click += buttonClearPrompt_Click;
            // 
            // panelRight
            // 
            panelRight.ColumnCount = 1;
            panelRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelRight.Controls.Add(buttonResize, 0, 3);
            panelRight.Controls.Add(buttonSave, 0, 1);
            panelRight.Controls.Add(buttonCopy, 0, 0);
            panelRight.Controls.Add(buttonBrowse, 0, 2);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(558, 80);
            panelRight.Margin = new Padding(0);
            panelRight.Name = "panelRight";
            panelRight.RowCount = 4;
            panelRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            panelRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            panelRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            panelRight.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            panelRight.Size = new Size(40, 521);
            panelRight.TabIndex = 111;
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
            buttonResize.Location = new Point(0, 132);
            buttonResize.Margin = new Padding(0, 3, 0, 3);
            buttonResize.Name = "buttonResize";
            buttonResize.Size = new Size(40, 386);
            buttonResize.TabIndex = 12;
            toolTip1.SetToolTip(buttonResize, "Resize");
            buttonResize.UseVisualStyleBackColor = false;
            buttonResize.Click += buttonResize_Click;
            buttonResize.MouseDown += buttonResize_MouseDown;
            buttonResize.MouseMove += buttonResize_MouseMove;
            buttonResize.MouseUp += buttonResize_MouseUp;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(85, 35, 25);
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.Dock = DockStyle.Fill;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.ForeColor = Color.Silver;
            buttonSave.Image = Properties.Resources.save1;
            buttonSave.Location = new Point(0, 46);
            buttonSave.Margin = new Padding(0, 3, 0, 0);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(40, 40);
            buttonSave.TabIndex = 105;
            buttonSave.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(buttonSave, "Always save Frames");
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCopy
            // 
            buttonCopy.BackColor = Color.FromArgb(30, 50, 60);
            buttonCopy.Cursor = Cursors.Hand;
            buttonCopy.Dock = DockStyle.Fill;
            buttonCopy.FlatAppearance.BorderSize = 0;
            buttonCopy.FlatStyle = FlatStyle.Flat;
            buttonCopy.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCopy.ForeColor = Color.Silver;
            buttonCopy.Image = Properties.Resources._16_paste;
            buttonCopy.Location = new Point(0, 3);
            buttonCopy.Margin = new Padding(0, 3, 0, 0);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new Size(40, 40);
            buttonCopy.TabIndex = 111;
            buttonCopy.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(buttonCopy, "Copy image to Clipboard");
            buttonCopy.UseVisualStyleBackColor = false;
            buttonCopy.Click += buttonCopy_Click;
            // 
            // buttonBrowse
            // 
            buttonBrowse.BackColor = Color.FromArgb(30, 50, 60);
            buttonBrowse.Cursor = Cursors.Hand;
            buttonBrowse.FlatAppearance.BorderSize = 0;
            buttonBrowse.FlatStyle = FlatStyle.Flat;
            buttonBrowse.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBrowse.ForeColor = Color.Silver;
            buttonBrowse.Image = Properties.Resources.search;
            buttonBrowse.Location = new Point(0, 89);
            buttonBrowse.Margin = new Padding(0, 3, 0, 0);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(40, 39);
            buttonBrowse.TabIndex = 112;
            buttonBrowse.TextAlign = ContentAlignment.BottomCenter;
            buttonBrowse.UseVisualStyleBackColor = false;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // panelCenter
            // 
            panelCenter.ColumnCount = 1;
            panelCenter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelCenter.Controls.Add(panelImage, 0, 0);
            panelCenter.Dock = DockStyle.Fill;
            panelCenter.Location = new Point(40, 80);
            panelCenter.Margin = new Padding(0);
            panelCenter.Name = "panelCenter";
            panelCenter.RowCount = 1;
            panelCenter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelCenter.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            panelCenter.Size = new Size(518, 521);
            panelCenter.TabIndex = 113;
            // 
            // panelImage
            // 
            panelImage.BackColor = Color.FromArgb(35, 35, 35);
            panelImage.Controls.Add(pictureBox1);
            panelImage.Dock = DockStyle.Fill;
            panelImage.Location = new Point(3, 3);
            panelImage.Name = "panelImage";
            panelImage.Size = new Size(512, 515);
            panelImage.TabIndex = 5;
            panelImage.MouseDown += panelImage_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(7, 7, 7);
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(512, 515);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // panelBottom
            // 
            panelBottom.ColumnCount = 1;
            panelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelBottom.Controls.Add(panelM, 0, 1);
            panelBottom.Controls.Add(panelPlayer, 0, 0);
            panelBottom.Dock = DockStyle.Fill;
            panelBottom.Location = new Point(43, 601);
            panelBottom.Margin = new Padding(3, 0, 3, 0);
            panelBottom.Name = "panelBottom";
            panelBottom.RowCount = 2;
            panelBottom.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelBottom.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelBottom.Size = new Size(512, 80);
            panelBottom.TabIndex = 114;
            // 
            // panelM
            // 
            panelM.ColumnCount = 10;
            panelM.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            panelM.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            panelM.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            panelM.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            panelM.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            panelM.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            panelM.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            panelM.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            panelM.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            panelM.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            panelM.Controls.Add(button10, 9, 0);
            panelM.Controls.Add(button9, 8, 0);
            panelM.Controls.Add(button8, 7, 0);
            panelM.Controls.Add(button7, 6, 0);
            panelM.Controls.Add(button6, 5, 0);
            panelM.Controls.Add(button5, 4, 0);
            panelM.Controls.Add(button4, 3, 0);
            panelM.Controls.Add(button3, 2, 0);
            panelM.Controls.Add(button2, 1, 0);
            panelM.Controls.Add(button1, 0, 0);
            panelM.Dock = DockStyle.Fill;
            panelM.Location = new Point(0, 40);
            panelM.Margin = new Padding(0);
            panelM.Name = "panelM";
            panelM.RowCount = 1;
            panelM.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelM.Size = new Size(512, 40);
            panelM.TabIndex = 9;
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
            button10.Margin = new Padding(1, 0, 0, 0);
            button10.Name = "button10";
            button10.Size = new Size(52, 40);
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
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(0, 0, 1, 0);
            button1.Name = "button1";
            button1.Size = new Size(50, 40);
            button1.TabIndex = 105;
            button1.Text = "1";
            toolTip1.SetToolTip(button1, "Slot 1");
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonM_Click;
            // 
            // panelPlayer
            // 
            panelPlayer.ColumnCount = 4;
            panelPlayer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            panelPlayer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelPlayer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            panelPlayer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            panelPlayer.Controls.Add(buttonPlay, 0, 0);
            panelPlayer.Controls.Add(colorTrackBarPlayer, 1, 0);
            panelPlayer.Controls.Add(buttonSaveFrames, 3, 0);
            panelPlayer.Controls.Add(buttonDelete, 2, 0);
            panelPlayer.Dock = DockStyle.Fill;
            panelPlayer.Enabled = false;
            panelPlayer.Location = new Point(0, 0);
            panelPlayer.Margin = new Padding(0, 0, 0, 3);
            panelPlayer.Name = "panelPlayer";
            panelPlayer.RowCount = 1;
            panelPlayer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelPlayer.Size = new Size(512, 37);
            panelPlayer.TabIndex = 10;
            // 
            // buttonPlay
            // 
            buttonPlay.BackColor = Color.FromArgb(85, 35, 25);
            buttonPlay.Cursor = Cursors.Hand;
            buttonPlay.Dock = DockStyle.Fill;
            buttonPlay.FlatAppearance.BorderSize = 0;
            buttonPlay.FlatStyle = FlatStyle.Flat;
            buttonPlay.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPlay.ForeColor = Color.Silver;
            buttonPlay.Image = Properties.Resources.play;
            buttonPlay.Location = new Point(0, 0);
            buttonPlay.Margin = new Padding(0);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(40, 37);
            buttonPlay.TabIndex = 112;
            buttonPlay.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(buttonPlay, "Play frames");
            buttonPlay.UseVisualStyleBackColor = false;
            buttonPlay.Click += buttonPlay_Click;
            // 
            // colorTrackBarPlayer
            // 
            colorTrackBarPlayer.BarBorderColor = Color.FromArgb(15, 25, 15);
            colorTrackBarPlayer.BarColor = Color.FromArgb(15, 25, 15);
            colorTrackBarPlayer.BarOrientation = Orientations.Horizontal;
            colorTrackBarPlayer.ControlCornerStyle = CornerStyles.Square;
            colorTrackBarPlayer.Dock = DockStyle.Fill;
            colorTrackBarPlayer.Location = new Point(43, 0);
            colorTrackBarPlayer.Margin = new Padding(3, 0, 3, 0);
            colorTrackBarPlayer.Maximum = 10;
            colorTrackBarPlayer.MaximumValueSide = Poles.Right;
            colorTrackBarPlayer.Minimum = 0;
            colorTrackBarPlayer.Name = "colorTrackBarPlayer";
            colorTrackBarPlayer.Size = new Size(386, 37);
            colorTrackBarPlayer.TabIndex = 6;
            colorTrackBarPlayer.Text = "colorTrackBar1";
            colorTrackBarPlayer.TrackerBorderColor = Color.FromArgb(45, 85, 65);
            colorTrackBarPlayer.TrackerColor = Color.FromArgb(45, 85, 65);
            colorTrackBarPlayer.TrackerSize = 25;
            colorTrackBarPlayer.Value = 0;
            colorTrackBarPlayer.ValueChanged += colorTrackBarPlayer_ValueChanged;
            // 
            // buttonSaveFrames
            // 
            buttonSaveFrames.BackColor = Color.FromArgb(30, 40, 60);
            buttonSaveFrames.Cursor = Cursors.Hand;
            buttonSaveFrames.Dock = DockStyle.Fill;
            buttonSaveFrames.FlatAppearance.BorderSize = 0;
            buttonSaveFrames.FlatStyle = FlatStyle.Flat;
            buttonSaveFrames.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSaveFrames.ForeColor = Color.Silver;
            buttonSaveFrames.Image = Properties.Resources.save1;
            buttonSaveFrames.Location = new Point(473, 0);
            buttonSaveFrames.Margin = new Padding(1, 0, 0, 0);
            buttonSaveFrames.Name = "buttonSaveFrames";
            buttonSaveFrames.Size = new Size(39, 37);
            buttonSaveFrames.TabIndex = 112;
            buttonSaveFrames.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(buttonSaveFrames, "Save Frames");
            buttonSaveFrames.UseVisualStyleBackColor = false;
            buttonSaveFrames.Click += buttonSaveFrames_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(100, 30, 40);
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.Dock = DockStyle.Fill;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.ForeColor = Color.Silver;
            buttonDelete.Image = Properties.Resources.delete_cross;
            buttonDelete.Location = new Point(432, 0);
            buttonDelete.Margin = new Padding(0, 0, 1, 0);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(39, 37);
            buttonDelete.TabIndex = 112;
            buttonDelete.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(buttonDelete, "Delete current frame");
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
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
            // timerPlayer
            // 
            timerPlayer.Tick += timerPlayer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 15, 35);
            ClientSize = new Size(598, 681);
            Controls.Add(panelMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(614, 720);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fictiverse : Redream";
            TopMost = true;
            Load += Form1_Load;
            ResizeEnd += Form1_ResizeEnd;
            panelMain.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelPrompt.ResumeLayout(false);
            panelPrompt.PerformLayout();
            panelRight.ResumeLayout(false);
            panelCenter.ResumeLayout(false);
            panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBottom.ResumeLayout(false);
            panelM.ResumeLayout(false);
            panelPlayer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel panelMain;
        private Button buttonStart;
        private Panel panelImage;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerFadeOut;
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
        private TableLayoutPanel panelM;
        private Button buttonInterrogate;
        private Button buttonCFGScale;
        private Button buttonNormSize;
        private TableLayoutPanel panelTop;
        private Panel panel1;
        private TextBox textBoxPromptN;
        private Panel panelPrompt;
        private TextBox textBoxPrompt;
        private Button buttonClearPromptN;
        private Button buttonClearPrompt;
        private TableLayoutPanel panelRight;
        private Button buttonSettings;
        private Button buttonResize;
        private Button buttonMask;
        private Button buttonSampler;
        private Button buttonCopy;
        private TableLayoutPanel panelCenter;
        private ColorTrackBar colorTrackBarPlayer;
        private TableLayoutPanel panelBottom;
        private TableLayoutPanel panelLeft;
        private TableLayoutPanel panelPlayer;
        private Button buttonPlay;
        private Button buttonSaveFrames;
        private System.Windows.Forms.Timer timerPlayer;
        private Button buttonDelete;
        private Button buttonBrowse;
    }
}
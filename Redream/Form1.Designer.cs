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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxPrompt = new System.Windows.Forms.TextBox();
            this.panelImage = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonScreenshot = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonShape = new System.Windows.Forms.Button();
            this.buttonSeed = new System.Windows.Forms.Button();
            this.buttonSteps = new System.Windows.Forms.Button();
            this.buttonStrength = new System.Windows.Forms.Button();
            this.buttonCFGScale = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonInterrogate = new System.Windows.Forms.Button();
            this.buttonDiscord = new System.Windows.Forms.Button();
            this.buttonFav = new System.Windows.Forms.Button();
            this.buttonResize = new System.Windows.Forms.Button();
            this.timerFadeOut = new System.Windows.Forms.Timer(this.components);
            this.timerBlink = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Controls.Add(this.buttonStart, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelImage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelMenu, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonInterrogate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonDiscord, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonFav, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonResize, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(599, 601);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(35)))), ((int)(((byte)(25)))));
            this.buttonStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStart.ForeColor = System.Drawing.Color.Silver;
            this.buttonStart.Image = global::Redream.Properties.Resources.play;
            this.buttonStart.Location = new System.Drawing.Point(0, 0);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(0);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(40, 40);
            this.buttonStart.TabIndex = 3;
            this.toolTip1.SetToolTip(this.buttonStart, "Start / Stop");
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.panel1.Controls.Add(this.textBoxPrompt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(43, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(6, 11, 6, 0);
            this.panel1.Size = new System.Drawing.Size(513, 40);
            this.panel1.TabIndex = 4;
            // 
            // textBoxPrompt
            // 
            this.textBoxPrompt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.textBoxPrompt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPrompt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPrompt.ForeColor = System.Drawing.Color.Silver;
            this.textBoxPrompt.Location = new System.Drawing.Point(6, 11);
            this.textBoxPrompt.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.textBoxPrompt.Name = "textBoxPrompt";
            this.textBoxPrompt.Size = new System.Drawing.Size(501, 16);
            this.textBoxPrompt.TabIndex = 0;
            this.textBoxPrompt.Text = "Visual Novel";
            // 
            // panelImage
            // 
            this.panelImage.AutoScroll = true;
            this.panelImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelImage.Controls.Add(this.pictureBox1);
            this.panelImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImage.Location = new System.Drawing.Point(43, 43);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(513, 515);
            this.panelImage.TabIndex = 5;
            this.panelImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelImage_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.buttonScreenshot);
            this.panelMenu.Controls.Add(this.buttonSave);
            this.panelMenu.Controls.Add(this.buttonBrowse);
            this.panelMenu.Controls.Add(this.buttonShape);
            this.panelMenu.Controls.Add(this.buttonSeed);
            this.panelMenu.Controls.Add(this.buttonSteps);
            this.panelMenu.Controls.Add(this.buttonStrength);
            this.panelMenu.Controls.Add(this.buttonCFGScale);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 43);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(40, 518);
            this.panelMenu.TabIndex = 7;
            // 
            // buttonScreenshot
            // 
            this.buttonScreenshot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(35)))), ((int)(((byte)(25)))));
            this.buttonScreenshot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonScreenshot.FlatAppearance.BorderSize = 0;
            this.buttonScreenshot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScreenshot.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonScreenshot.ForeColor = System.Drawing.Color.Silver;
            this.buttonScreenshot.Image = global::Redream.Properties.Resources.selection;
            this.buttonScreenshot.Location = new System.Drawing.Point(0, 0);
            this.buttonScreenshot.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.buttonScreenshot.Name = "buttonScreenshot";
            this.buttonScreenshot.Size = new System.Drawing.Size(40, 40);
            this.buttonScreenshot.TabIndex = 103;
            this.buttonScreenshot.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.buttonScreenshot, "Zone Selector");
            this.buttonScreenshot.UseVisualStyleBackColor = false;
            this.buttonScreenshot.Click += new System.EventHandler(this.buttonScreenshot_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(35)))), ((int)(((byte)(25)))));
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.Color.Silver;
            this.buttonSave.Image = global::Redream.Properties.Resources.save1;
            this.buttonSave.Location = new System.Drawing.Point(0, 49);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(0, 6, 0, 1);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(40, 40);
            this.buttonSave.TabIndex = 105;
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.buttonSave, "Save Frames");
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.buttonBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBrowse.FlatAppearance.BorderSize = 0;
            this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowse.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBrowse.ForeColor = System.Drawing.Color.Silver;
            this.buttonBrowse.Image = global::Redream.Properties.Resources.search;
            this.buttonBrowse.Location = new System.Drawing.Point(0, 91);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(0, 1, 0, 3);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(40, 40);
            this.buttonBrowse.TabIndex = 110;
            this.buttonBrowse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.buttonBrowse, "Aspect Ratio");
            this.buttonBrowse.UseVisualStyleBackColor = false;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonShape
            // 
            this.buttonShape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(50)))), ((int)(((byte)(40)))));
            this.buttonShape.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShape.FlatAppearance.BorderSize = 0;
            this.buttonShape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShape.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonShape.ForeColor = System.Drawing.Color.Silver;
            this.buttonShape.Image = global::Redream.Properties.Resources.rounded_black_square_shapeS_;
            this.buttonShape.Location = new System.Drawing.Point(0, 140);
            this.buttonShape.Margin = new System.Windows.Forms.Padding(0, 6, 0, 3);
            this.buttonShape.Name = "buttonShape";
            this.buttonShape.Size = new System.Drawing.Size(40, 40);
            this.buttonShape.TabIndex = 104;
            this.buttonShape.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.buttonShape, "Aspect Ratio");
            this.buttonShape.UseVisualStyleBackColor = false;
            this.buttonShape.Click += new System.EventHandler(this.buttonShape_Click);
            // 
            // buttonSeed
            // 
            this.buttonSeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.buttonSeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSeed.FlatAppearance.BorderSize = 0;
            this.buttonSeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSeed.ForeColor = System.Drawing.Color.Silver;
            this.buttonSeed.Image = global::Redream.Properties.Resources._16_dice;
            this.buttonSeed.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSeed.Location = new System.Drawing.Point(0, 189);
            this.buttonSeed.Margin = new System.Windows.Forms.Padding(0, 6, 0, 1);
            this.buttonSeed.Name = "buttonSeed";
            this.buttonSeed.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.buttonSeed.Size = new System.Drawing.Size(40, 80);
            this.buttonSeed.TabIndex = 108;
            this.buttonSeed.Text = "-1";
            this.buttonSeed.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.buttonSeed, "Seed");
            this.buttonSeed.UseVisualStyleBackColor = false;
            this.buttonSeed.Click += new System.EventHandler(this.buttonSeed_Click);
            // 
            // buttonSteps
            // 
            this.buttonSteps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.buttonSteps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSteps.FlatAppearance.BorderSize = 0;
            this.buttonSteps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSteps.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSteps.ForeColor = System.Drawing.Color.Silver;
            this.buttonSteps.Image = global::Redream.Properties.Resources.level2;
            this.buttonSteps.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSteps.Location = new System.Drawing.Point(0, 271);
            this.buttonSteps.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.buttonSteps.Name = "buttonSteps";
            this.buttonSteps.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.buttonSteps.Size = new System.Drawing.Size(40, 80);
            this.buttonSteps.TabIndex = 106;
            this.buttonSteps.Text = "16";
            this.buttonSteps.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.buttonSteps, "Steps");
            this.buttonSteps.UseVisualStyleBackColor = false;
            this.buttonSteps.Click += new System.EventHandler(this.buttonSteps_Click);
            // 
            // buttonStrength
            // 
            this.buttonStrength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.buttonStrength.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStrength.FlatAppearance.BorderSize = 0;
            this.buttonStrength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStrength.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStrength.ForeColor = System.Drawing.Color.Silver;
            this.buttonStrength.Image = global::Redream.Properties.Resources._16_blur;
            this.buttonStrength.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonStrength.Location = new System.Drawing.Point(0, 353);
            this.buttonStrength.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.buttonStrength.Name = "buttonStrength";
            this.buttonStrength.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.buttonStrength.Size = new System.Drawing.Size(40, 80);
            this.buttonStrength.TabIndex = 107;
            this.buttonStrength.Text = "0.5";
            this.buttonStrength.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.buttonStrength, "Denoising Strength");
            this.buttonStrength.UseVisualStyleBackColor = false;
            this.buttonStrength.Click += new System.EventHandler(this.buttonStrength_Click);
            // 
            // buttonCFGScale
            // 
            this.buttonCFGScale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.buttonCFGScale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCFGScale.FlatAppearance.BorderSize = 0;
            this.buttonCFGScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCFGScale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCFGScale.ForeColor = System.Drawing.Color.Silver;
            this.buttonCFGScale.Image = global::Redream.Properties.Resources._16_scale;
            this.buttonCFGScale.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCFGScale.Location = new System.Drawing.Point(0, 435);
            this.buttonCFGScale.Margin = new System.Windows.Forms.Padding(0, 1, 0, 3);
            this.buttonCFGScale.Name = "buttonCFGScale";
            this.buttonCFGScale.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.buttonCFGScale.Size = new System.Drawing.Size(40, 80);
            this.buttonCFGScale.TabIndex = 109;
            this.buttonCFGScale.Text = "7.5";
            this.buttonCFGScale.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.buttonCFGScale, "Denoising Strength");
            this.buttonCFGScale.UseVisualStyleBackColor = false;
            this.buttonCFGScale.Click += new System.EventHandler(this.buttonCFGScale_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 10;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.button10, 9, 0);
            this.tableLayoutPanel2.Controls.Add(this.button9, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.button8, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.button7, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.button6, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.button5, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.button4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(43, 561);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(513, 40);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.Color.Silver;
            this.button10.Location = new System.Drawing.Point(460, 0);
            this.button10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(52, 40);
            this.button10.TabIndex = 114;
            this.button10.Text = "10";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.buttonM_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.Color.Silver;
            this.button9.Location = new System.Drawing.Point(409, 0);
            this.button9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(49, 40);
            this.button9.TabIndex = 113;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.buttonM_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.Color.Silver;
            this.button8.Location = new System.Drawing.Point(358, 0);
            this.button8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(49, 40);
            this.button8.TabIndex = 112;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.buttonM_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.Silver;
            this.button7.Location = new System.Drawing.Point(307, 0);
            this.button7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 40);
            this.button7.TabIndex = 111;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.buttonM_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.Silver;
            this.button6.Location = new System.Drawing.Point(256, 0);
            this.button6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(49, 40);
            this.button6.TabIndex = 110;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.buttonM_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.Silver;
            this.button5.Location = new System.Drawing.Point(205, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 40);
            this.button5.TabIndex = 109;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.buttonM_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Silver;
            this.button4.Location = new System.Drawing.Point(154, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 40);
            this.button4.TabIndex = 108;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.buttonM_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(103, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 40);
            this.button3.TabIndex = 107;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttonM_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(52, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 40);
            this.button2.TabIndex = 106;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonM_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(1, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 40);
            this.button1.TabIndex = 105;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonM_Click);
            // 
            // buttonInterrogate
            // 
            this.buttonInterrogate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.buttonInterrogate.FlatAppearance.BorderSize = 0;
            this.buttonInterrogate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInterrogate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonInterrogate.ForeColor = System.Drawing.Color.Silver;
            this.buttonInterrogate.Image = global::Redream.Properties.Resources.text;
            this.buttonInterrogate.Location = new System.Drawing.Point(559, 0);
            this.buttonInterrogate.Margin = new System.Windows.Forms.Padding(0);
            this.buttonInterrogate.Name = "buttonInterrogate";
            this.buttonInterrogate.Size = new System.Drawing.Size(40, 40);
            this.buttonInterrogate.TabIndex = 10;
            this.toolTip1.SetToolTip(this.buttonInterrogate, "Interrogate Image");
            this.buttonInterrogate.UseVisualStyleBackColor = false;
            this.buttonInterrogate.Click += new System.EventHandler(this.buttonInterrogate_Click);
            // 
            // buttonDiscord
            // 
            this.buttonDiscord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.buttonDiscord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDiscord.FlatAppearance.BorderSize = 0;
            this.buttonDiscord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiscord.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDiscord.ForeColor = System.Drawing.Color.Silver;
            this.buttonDiscord.Image = global::Redream.Properties.Resources.discord;
            this.buttonDiscord.Location = new System.Drawing.Point(559, 561);
            this.buttonDiscord.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDiscord.Name = "buttonDiscord";
            this.buttonDiscord.Size = new System.Drawing.Size(40, 40);
            this.buttonDiscord.TabIndex = 109;
            this.toolTip1.SetToolTip(this.buttonDiscord, "Start / Stop");
            this.buttonDiscord.UseVisualStyleBackColor = false;
            this.buttonDiscord.Click += new System.EventHandler(this.buttonDiscord_Click);
            // 
            // buttonFav
            // 
            this.buttonFav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(35)))), ((int)(((byte)(25)))));
            this.buttonFav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFav.FlatAppearance.BorderSize = 0;
            this.buttonFav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFav.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFav.ForeColor = System.Drawing.Color.Silver;
            this.buttonFav.Image = global::Redream.Properties.Resources.favourite;
            this.buttonFav.Location = new System.Drawing.Point(0, 561);
            this.buttonFav.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFav.Name = "buttonFav";
            this.buttonFav.Size = new System.Drawing.Size(40, 40);
            this.buttonFav.TabIndex = 8;
            this.toolTip1.SetToolTip(this.buttonFav, "Add prompt to fav");
            this.buttonFav.UseVisualStyleBackColor = false;
            this.buttonFav.Click += new System.EventHandler(this.buttonFav_Click);
            // 
            // buttonResize
            // 
            this.buttonResize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.buttonResize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonResize.FlatAppearance.BorderSize = 0;
            this.buttonResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResize.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonResize.ForeColor = System.Drawing.Color.Silver;
            this.buttonResize.Image = global::Redream.Properties.Resources.flip;
            this.buttonResize.Location = new System.Drawing.Point(559, 43);
            this.buttonResize.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.buttonResize.Name = "buttonResize";
            this.buttonResize.Size = new System.Drawing.Size(40, 515);
            this.buttonResize.TabIndex = 11;
            this.toolTip1.SetToolTip(this.buttonResize, "Start / Stop");
            this.buttonResize.UseVisualStyleBackColor = false;
            this.buttonResize.Click += new System.EventHandler(this.buttonResize_Click);
            this.buttonResize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonResize_MouseDown);
            this.buttonResize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonResize_MouseMove);
            this.buttonResize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonResize_MouseUp);
            // 
            // timerFadeOut
            // 
            this.timerFadeOut.Interval = 20;
            this.timerFadeOut.Tick += new System.EventHandler(this.timerFadeOut_Tick);
            // 
            // timerBlink
            // 
            this.timerBlink.Interval = 500;
            this.timerBlink.Tick += new System.EventHandler(this.timerBlink_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(599, 601);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(615, 640);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fictiverse : Redream";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelImage.ResumeLayout(false);
            this.panelImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonStart;
        private Panel panel1;
        private TextBox textBoxPrompt;
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
        private Button buttonResize;
        private Button buttonDiscord;
        private Button buttonCFGScale;
        private Button buttonBrowse;
    }
}
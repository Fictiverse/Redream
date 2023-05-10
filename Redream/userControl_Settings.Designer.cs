namespace Redream
{
    partial class userControl_Settings
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panelMenu = new FlowLayoutPanel();
            buttonScreenshot = new Button();
            button564 = new Button();
            buttonBrowse = new Button();
            buttonShape = new Button();
            buttonSeed = new Button();
            buttonSteps = new Button();
            buttonStrength = new Button();
            buttonCFGScale = new Button();
            buttonSampler = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            dataModels = new DataGridView();
            Folder = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewImageColumn2 = new DataGridViewImageColumn();
            model = new DataGridViewTextBoxColumn();
            Tokens = new DataGridViewTextBoxColumn();
            panelHeaderModels = new TableLayoutPanel();
            buttonUndo = new Button();
            buttonRefreshModels = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            dataControlNet = new DataGridView();
            buttonControlNet = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonModel = new Button();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewImageColumn();
            nameHash = new DataGridViewTextBoxColumn();
            tableLayoutPanel3 = new TableLayoutPanel();
            button1 = new Button();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewImageColumn1 = new DataGridViewImageColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewImageColumn3 = new DataGridViewImageColumn();
            Pre = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            panelMenu.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataModels).BeginInit();
            panelHeaderModels.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataControlNet).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(buttonScreenshot);
            panelMenu.Controls.Add(button564);
            panelMenu.Controls.Add(buttonBrowse);
            panelMenu.Controls.Add(buttonShape);
            panelMenu.Controls.Add(buttonSeed);
            panelMenu.Controls.Add(buttonSteps);
            panelMenu.Controls.Add(buttonStrength);
            panelMenu.Controls.Add(buttonCFGScale);
            panelMenu.Controls.Add(buttonSampler);
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(100, 615);
            panelMenu.TabIndex = 8;
            // 
            // buttonScreenshot
            // 
            buttonScreenshot.BackColor = Color.FromArgb(85, 35, 25);
            buttonScreenshot.Cursor = Cursors.Hand;
            buttonScreenshot.FlatAppearance.BorderSize = 0;
            buttonScreenshot.FlatStyle = FlatStyle.Flat;
            buttonScreenshot.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonScreenshot.ForeColor = Color.Silver;
            buttonScreenshot.Location = new Point(0, 0);
            buttonScreenshot.Margin = new Padding(0, 0, 0, 1);
            buttonScreenshot.Name = "buttonScreenshot";
            buttonScreenshot.Size = new Size(100, 40);
            buttonScreenshot.TabIndex = 103;
            buttonScreenshot.Text = "From Screen";
            buttonScreenshot.UseVisualStyleBackColor = false;
            // 
            // button564
            // 
            button564.BackColor = Color.FromArgb(85, 35, 25);
            button564.Cursor = Cursors.Hand;
            button564.FlatAppearance.BorderSize = 0;
            button564.FlatStyle = FlatStyle.Flat;
            button564.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button564.ForeColor = Color.Silver;
            button564.Location = new Point(0, 42);
            button564.Margin = new Padding(0, 1, 0, 3);
            button564.Name = "button564";
            button564.Size = new Size(100, 40);
            button564.TabIndex = 110;
            button564.Text = "From Video";
            button564.UseVisualStyleBackColor = false;
            button564.Visible = false;
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
            buttonBrowse.Location = new Point(0, 88);
            buttonBrowse.Margin = new Padding(0, 3, 0, 3);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(100, 40);
            buttonBrowse.TabIndex = 105;
            buttonBrowse.TextAlign = ContentAlignment.BottomCenter;
            buttonBrowse.UseVisualStyleBackColor = false;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // buttonShape
            // 
            buttonShape.BackColor = Color.FromArgb(60, 50, 40);
            buttonShape.Cursor = Cursors.Hand;
            buttonShape.FlatAppearance.BorderSize = 0;
            buttonShape.FlatStyle = FlatStyle.Flat;
            buttonShape.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonShape.ForeColor = Color.Silver;
            buttonShape.Location = new Point(0, 134);
            buttonShape.Margin = new Padding(0, 3, 0, 3);
            buttonShape.Name = "buttonShape";
            buttonShape.Size = new Size(100, 40);
            buttonShape.TabIndex = 104;
            buttonShape.Text = "1 / 1";
            buttonShape.UseVisualStyleBackColor = false;
            buttonShape.Click += buttonShape_Click;
            // 
            // buttonSeed
            // 
            buttonSeed.BackColor = Color.FromArgb(60, 30, 60);
            buttonSeed.Cursor = Cursors.Hand;
            buttonSeed.FlatAppearance.BorderSize = 0;
            buttonSeed.FlatStyle = FlatStyle.Flat;
            buttonSeed.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSeed.ForeColor = Color.Silver;
            buttonSeed.ImageAlign = ContentAlignment.TopCenter;
            buttonSeed.Location = new Point(0, 180);
            buttonSeed.Margin = new Padding(0, 3, 0, 1);
            buttonSeed.Name = "buttonSeed";
            buttonSeed.Padding = new Padding(0, 6, 0, 6);
            buttonSeed.Size = new Size(100, 70);
            buttonSeed.TabIndex = 108;
            buttonSeed.Text = "-1";
            buttonSeed.UseVisualStyleBackColor = false;
            buttonSeed.Click += buttonSeed_Click;
            // 
            // buttonSteps
            // 
            buttonSteps.BackColor = Color.FromArgb(60, 30, 60);
            buttonSteps.Cursor = Cursors.Hand;
            buttonSteps.FlatAppearance.BorderSize = 0;
            buttonSteps.FlatStyle = FlatStyle.Flat;
            buttonSteps.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSteps.ForeColor = Color.Silver;
            buttonSteps.ImageAlign = ContentAlignment.TopCenter;
            buttonSteps.Location = new Point(0, 252);
            buttonSteps.Margin = new Padding(0, 1, 0, 1);
            buttonSteps.Name = "buttonSteps";
            buttonSteps.Padding = new Padding(0, 6, 0, 6);
            buttonSteps.Size = new Size(100, 70);
            buttonSteps.TabIndex = 106;
            buttonSteps.Text = "16";
            buttonSteps.UseVisualStyleBackColor = false;
            buttonSteps.Click += buttonSteps_Click;
            // 
            // buttonStrength
            // 
            buttonStrength.BackColor = Color.FromArgb(60, 30, 60);
            buttonStrength.Cursor = Cursors.Hand;
            buttonStrength.FlatAppearance.BorderSize = 0;
            buttonStrength.FlatStyle = FlatStyle.Flat;
            buttonStrength.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStrength.ForeColor = Color.Silver;
            buttonStrength.ImageAlign = ContentAlignment.TopCenter;
            buttonStrength.Location = new Point(0, 324);
            buttonStrength.Margin = new Padding(0, 1, 0, 1);
            buttonStrength.Name = "buttonStrength";
            buttonStrength.Padding = new Padding(0, 6, 0, 6);
            buttonStrength.Size = new Size(100, 70);
            buttonStrength.TabIndex = 107;
            buttonStrength.Text = "0.5";
            buttonStrength.UseVisualStyleBackColor = false;
            buttonStrength.Click += buttonStrength_Click;
            // 
            // buttonCFGScale
            // 
            buttonCFGScale.BackColor = Color.FromArgb(60, 30, 60);
            buttonCFGScale.Cursor = Cursors.Hand;
            buttonCFGScale.FlatAppearance.BorderSize = 0;
            buttonCFGScale.FlatStyle = FlatStyle.Flat;
            buttonCFGScale.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCFGScale.ForeColor = Color.Silver;
            buttonCFGScale.ImageAlign = ContentAlignment.TopCenter;
            buttonCFGScale.Location = new Point(0, 396);
            buttonCFGScale.Margin = new Padding(0, 1, 0, 1);
            buttonCFGScale.Name = "buttonCFGScale";
            buttonCFGScale.Padding = new Padding(0, 6, 0, 6);
            buttonCFGScale.Size = new Size(100, 70);
            buttonCFGScale.TabIndex = 109;
            buttonCFGScale.Text = "7.5";
            buttonCFGScale.UseVisualStyleBackColor = false;
            buttonCFGScale.Click += buttonCFGScale_Click;
            // 
            // buttonSampler
            // 
            buttonSampler.BackColor = Color.FromArgb(60, 30, 60);
            buttonSampler.Cursor = Cursors.Hand;
            buttonSampler.FlatAppearance.BorderSize = 0;
            buttonSampler.FlatStyle = FlatStyle.Flat;
            buttonSampler.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSampler.ForeColor = Color.Silver;
            buttonSampler.Location = new Point(0, 470);
            buttonSampler.Margin = new Padding(0, 3, 0, 0);
            buttonSampler.Name = "buttonSampler";
            buttonSampler.Size = new Size(100, 40);
            buttonSampler.TabIndex = 112;
            buttonSampler.Text = "Euler A";
            buttonSampler.UseVisualStyleBackColor = false;
            buttonSampler.Click += buttonSampler_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 6F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.Controls.Add(panelMenu, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 2, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(968, 615);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(dataModels, 0, 1);
            tableLayoutPanel4.Controls.Add(panelHeaderModels, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(109, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(736, 609);
            tableLayoutPanel4.TabIndex = 9;
            // 
            // dataModels
            // 
            dataModels.AllowUserToAddRows = false;
            dataModels.AllowUserToDeleteRows = false;
            dataModels.AllowUserToResizeColumns = false;
            dataModels.AllowUserToResizeRows = false;
            dataModels.BackgroundColor = Color.FromArgb(15, 20, 35);
            dataModels.BorderStyle = BorderStyle.None;
            dataModels.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(15, 10, 15);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(30, 60, 40);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataModels.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataModels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataModels.ColumnHeadersVisible = false;
            dataModels.Columns.AddRange(new DataGridViewColumn[] { Folder, dataGridViewTextBoxColumn5, dataGridViewImageColumn2, model, Tokens });
            dataModels.Cursor = Cursors.Hand;
            dataModels.Dock = DockStyle.Fill;
            dataModels.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataModels.GridColor = Color.FromArgb(10, 10, 10);
            dataModels.Location = new Point(0, 46);
            dataModels.Margin = new Padding(0, 6, 0, 3);
            dataModels.Name = "dataModels";
            dataModels.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataModels.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataModels.RowHeadersVisible = false;
            dataModels.RowTemplate.DividerHeight = 3;
            dataModels.RowTemplate.Height = 72;
            dataModels.ScrollBars = ScrollBars.Vertical;
            dataModels.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataModels.Size = new Size(736, 560);
            dataModels.TabIndex = 88;
            dataModels.CellClick += dataModels_CellClick;
            // 
            // Folder
            // 
            Folder.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(35, 45, 65);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ScrollBar;
            dataGridViewCellStyle2.Padding = new Padding(3, 0, 3, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(40, 70, 50);
            Folder.DefaultCellStyle = dataGridViewCellStyle2;
            Folder.HeaderText = "Folder";
            Folder.Name = "Folder";
            Folder.ReadOnly = true;
            Folder.Width = 5;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(24, 30, 44);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ScrollBar;
            dataGridViewCellStyle3.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(30, 60, 40);
            dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTextBoxColumn5.FillWeight = 400F;
            dataGridViewTextBoxColumn5.HeaderText = "Model Name";
            dataGridViewTextBoxColumn5.MinimumWidth = 100;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Resizable = DataGridViewTriState.False;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(21, 26, 38);
            dataGridViewCellStyle4.ForeColor = SystemColors.ScrollBar;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(25, 55, 35);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ScrollBar;
            dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewImageColumn2.FillWeight = 72F;
            dataGridViewImageColumn2.HeaderText = "Icon";
            dataGridViewImageColumn2.MinimumWidth = 72;
            dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            dataGridViewImageColumn2.ReadOnly = true;
            dataGridViewImageColumn2.Resizable = DataGridViewTriState.False;
            dataGridViewImageColumn2.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewImageColumn2.ToolTipText = "Icon";
            dataGridViewImageColumn2.Width = 72;
            // 
            // model
            // 
            model.HeaderText = "model";
            model.Name = "model";
            model.ReadOnly = true;
            model.Visible = false;
            // 
            // Tokens
            // 
            Tokens.HeaderText = "Tokens";
            Tokens.Name = "Tokens";
            Tokens.ReadOnly = true;
            Tokens.Visible = false;
            // 
            // panelHeaderModels
            // 
            panelHeaderModels.ColumnCount = 2;
            panelHeaderModels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelHeaderModels.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            panelHeaderModels.Controls.Add(buttonUndo, 0, 0);
            panelHeaderModels.Controls.Add(buttonRefreshModels, 0, 0);
            panelHeaderModels.Dock = DockStyle.Fill;
            panelHeaderModels.Location = new Point(0, 0);
            panelHeaderModels.Margin = new Padding(0);
            panelHeaderModels.Name = "panelHeaderModels";
            panelHeaderModels.RowCount = 1;
            panelHeaderModels.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelHeaderModels.Size = new Size(736, 40);
            panelHeaderModels.TabIndex = 87;
            // 
            // buttonUndo
            // 
            buttonUndo.BackColor = Color.FromArgb(70, 50, 40);
            buttonUndo.Cursor = Cursors.Hand;
            buttonUndo.Dock = DockStyle.Fill;
            buttonUndo.FlatAppearance.BorderSize = 0;
            buttonUndo.FlatStyle = FlatStyle.Flat;
            buttonUndo.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUndo.ForeColor = Color.Silver;
            buttonUndo.Location = new Point(696, 0);
            buttonUndo.Margin = new Padding(0);
            buttonUndo.Name = "buttonUndo";
            buttonUndo.Size = new Size(40, 40);
            buttonUndo.TabIndex = 84;
            buttonUndo.UseVisualStyleBackColor = false;
            buttonUndo.Click += buttonUndo_Click;
            // 
            // buttonRefreshModels
            // 
            buttonRefreshModels.AllowDrop = true;
            buttonRefreshModels.BackColor = Color.FromArgb(35, 65, 65);
            buttonRefreshModels.Cursor = Cursors.Hand;
            buttonRefreshModels.Dock = DockStyle.Fill;
            buttonRefreshModels.FlatAppearance.BorderSize = 0;
            buttonRefreshModels.FlatStyle = FlatStyle.Flat;
            buttonRefreshModels.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRefreshModels.ForeColor = Color.Silver;
            buttonRefreshModels.ImageAlign = ContentAlignment.MiddleRight;
            buttonRefreshModels.Location = new Point(0, 0);
            buttonRefreshModels.Margin = new Padding(0, 0, 3, 0);
            buttonRefreshModels.Name = "buttonRefreshModels";
            buttonRefreshModels.Padding = new Padding(6, 0, 6, 0);
            buttonRefreshModels.Size = new Size(693, 40);
            buttonRefreshModels.TabIndex = 83;
            buttonRefreshModels.Text = "Models";
            buttonRefreshModels.TextAlign = ContentAlignment.MiddleLeft;
            buttonRefreshModels.UseVisualStyleBackColor = false;
            buttonRefreshModels.Click += buttonRefreshModels_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(dataControlNet, 0, 1);
            tableLayoutPanel5.Controls.Add(buttonControlNet, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(851, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(114, 609);
            tableLayoutPanel5.TabIndex = 10;
            // 
            // dataControlNet
            // 
            dataControlNet.AllowUserToAddRows = false;
            dataControlNet.AllowUserToDeleteRows = false;
            dataControlNet.AllowUserToResizeColumns = false;
            dataControlNet.AllowUserToResizeRows = false;
            dataControlNet.BackgroundColor = Color.FromArgb(15, 20, 35);
            dataControlNet.BorderStyle = BorderStyle.None;
            dataControlNet.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(15, 10, 15);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(30, 60, 40);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataControlNet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataControlNet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataControlNet.ColumnHeadersVisible = false;
            dataControlNet.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewImageColumn3, Pre, dataGridViewTextBoxColumn8 });
            dataControlNet.Cursor = Cursors.Hand;
            dataControlNet.Dock = DockStyle.Fill;
            dataControlNet.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataControlNet.GridColor = Color.FromArgb(10, 10, 10);
            dataControlNet.Location = new Point(0, 46);
            dataControlNet.Margin = new Padding(0, 6, 0, 3);
            dataControlNet.Name = "dataControlNet";
            dataControlNet.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataControlNet.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataControlNet.RowHeadersVisible = false;
            dataControlNet.RowTemplate.DividerHeight = 3;
            dataControlNet.RowTemplate.Height = 40;
            dataControlNet.ScrollBars = ScrollBars.Vertical;
            dataControlNet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataControlNet.Size = new Size(144, 560);
            dataControlNet.TabIndex = 89;
            dataControlNet.CellClick += dataControlNet_CellClick;
            // 
            // buttonControlNet
            // 
            buttonControlNet.AllowDrop = true;
            buttonControlNet.BackColor = Color.FromArgb(35, 65, 65);
            buttonControlNet.Cursor = Cursors.Hand;
            buttonControlNet.Dock = DockStyle.Fill;
            buttonControlNet.FlatAppearance.BorderSize = 0;
            buttonControlNet.FlatStyle = FlatStyle.Flat;
            buttonControlNet.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonControlNet.ForeColor = Color.Silver;
            buttonControlNet.ImageAlign = ContentAlignment.MiddleRight;
            buttonControlNet.Location = new Point(0, 0);
            buttonControlNet.Margin = new Padding(0, 0, 3, 0);
            buttonControlNet.Name = "buttonControlNet";
            buttonControlNet.Padding = new Padding(6, 0, 6, 0);
            buttonControlNet.Size = new Size(141, 40);
            buttonControlNet.TabIndex = 83;
            buttonControlNet.Text = "ControlNet";
            buttonControlNet.TextAlign = ContentAlignment.MiddleLeft;
            buttonControlNet.UseVisualStyleBackColor = false;
            buttonControlNet.Click += buttonControlNet_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(buttonModel, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonModel
            // 
            buttonModel.AllowDrop = true;
            buttonModel.BackColor = Color.FromArgb(35, 45, 65);
            buttonModel.Cursor = Cursors.Hand;
            buttonModel.FlatAppearance.BorderSize = 0;
            buttonModel.FlatStyle = FlatStyle.Flat;
            buttonModel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonModel.ForeColor = Color.Silver;
            buttonModel.Image = Properties.Resources.connect;
            buttonModel.ImageAlign = ContentAlignment.MiddleRight;
            buttonModel.Location = new Point(0, 0);
            buttonModel.Margin = new Padding(0, 0, 0, 1);
            buttonModel.Name = "buttonModel";
            buttonModel.Padding = new Padding(6, 0, 6, 0);
            buttonModel.Size = new Size(200, 40);
            buttonModel.TabIndex = 86;
            buttonModel.Text = "Model";
            buttonModel.TextAlign = ContentAlignment.MiddleLeft;
            buttonModel.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(24, 30, 44);
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.ScrollBar;
            dataGridViewCellStyle10.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(30, 60, 40);
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewTextBoxColumn3.FillWeight = 400F;
            dataGridViewTextBoxColumn3.HeaderText = "Presets";
            dataGridViewTextBoxColumn3.MinimumWidth = 100;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Resizable = DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(21, 26, 38);
            dataGridViewCellStyle11.ForeColor = SystemColors.ScrollBar;
            dataGridViewCellStyle11.NullValue = null;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(25, 55, 35);
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.ScrollBar;
            dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewTextBoxColumn4.FillWeight = 72F;
            dataGridViewTextBoxColumn4.HeaderText = "Icon";
            dataGridViewTextBoxColumn4.MinimumWidth = 72;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn4.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewTextBoxColumn4.ToolTipText = "Icon";
            dataGridViewTextBoxColumn4.Width = 72;
            // 
            // nameHash
            // 
            nameHash.HeaderText = "nameHash";
            nameHash.Name = "nameHash";
            nameHash.ReadOnly = true;
            nameHash.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(button1, 0, 0);
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // button1
            // 
            button1.AllowDrop = true;
            button1.BackColor = Color.FromArgb(35, 45, 65);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Silver;
            button1.Image = Properties.Resources.connect;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(0, 0, 0, 1);
            button1.Name = "button1";
            button1.Padding = new Padding(6, 0, 6, 0);
            button1.Size = new Size(200, 19);
            button1.TabIndex = 86;
            button1.Text = "Model";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(24, 30, 44);
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.ScrollBar;
            dataGridViewCellStyle12.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(30, 60, 40);
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewTextBoxColumn1.FillWeight = 400F;
            dataGridViewTextBoxColumn1.HeaderText = "Presets";
            dataGridViewTextBoxColumn1.MinimumWidth = 100;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.False;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(21, 26, 38);
            dataGridViewCellStyle13.ForeColor = SystemColors.ScrollBar;
            dataGridViewCellStyle13.NullValue = null;
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(25, 55, 35);
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.ScrollBar;
            dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewImageColumn1.FillWeight = 72F;
            dataGridViewImageColumn1.HeaderText = "Icon";
            dataGridViewImageColumn1.MinimumWidth = 72;
            dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            dataGridViewImageColumn1.ReadOnly = true;
            dataGridViewImageColumn1.Resizable = DataGridViewTriState.False;
            dataGridViewImageColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewImageColumn1.ToolTipText = "Icon";
            dataGridViewImageColumn1.Width = 72;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "nameHash";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(24, 30, 44);
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.ScrollBar;
            dataGridViewCellStyle7.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(30, 60, 40);
            dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewTextBoxColumn7.FillWeight = 400F;
            dataGridViewTextBoxColumn7.HeaderText = "Name";
            dataGridViewTextBoxColumn7.MinimumWidth = 100;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Resizable = DataGridViewTriState.False;
            // 
            // dataGridViewImageColumn3
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(21, 26, 38);
            dataGridViewCellStyle8.ForeColor = SystemColors.ScrollBar;
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(25, 55, 35);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.ScrollBar;
            dataGridViewImageColumn3.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewImageColumn3.FillWeight = 72F;
            dataGridViewImageColumn3.HeaderText = "Icon";
            dataGridViewImageColumn3.MinimumWidth = 72;
            dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            dataGridViewImageColumn3.ReadOnly = true;
            dataGridViewImageColumn3.Resizable = DataGridViewTriState.False;
            dataGridViewImageColumn3.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewImageColumn3.ToolTipText = "Icon";
            dataGridViewImageColumn3.Visible = false;
            dataGridViewImageColumn3.Width = 72;
            // 
            // Pre
            // 
            Pre.HeaderText = "PreProcessor";
            Pre.Name = "Pre";
            Pre.ReadOnly = true;
            Pre.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Model";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Visible = false;
            // 
            // userControl_Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 21, 21);
            Controls.Add(tableLayoutPanel1);
            Name = "userControl_Settings";
            Size = new Size(968, 615);
            Load += userControl_Settings_Load;
            panelMenu.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataModels).EndInit();
            panelHeaderModels.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataControlNet).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panelMenu;
        private Button buttonScreenshot;
        private Button buttonBrowse;
        private Button button564;
        private Button buttonShape;
        private Button buttonSeed;
        private Button buttonSteps;
        private Button buttonStrength;
        private Button buttonCFGScale;
        private Button buttonSampler;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonModel;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewImageColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn nameHash;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel panelHeaderModels;
        private Button buttonUndo;
        private Button buttonRefreshModels;
        private DataGridView dataModels;
        private DataGridViewTextBoxColumn Folder;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewImageColumn dataGridViewImageColumn2;
        private DataGridViewTextBoxColumn model;
        private DataGridViewTextBoxColumn Tokens;
        private TableLayoutPanel tableLayoutPanel5;
        private Button buttonControlNet;
        private DataGridView dataControlNet;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewImageColumn dataGridViewImageColumn3;
        private DataGridViewTextBoxColumn Pre;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}

using osu_trainer.Controls;

namespace osu_trainer
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            BeatmapUpdateTimer = new System.Windows.Forms.Timer(components);
            middlePanel = new Panel();
            showExtrasButton = new Button();
            profileButton4 = new OsuButton();
            profileButton3 = new OsuButton();
            profileButton2 = new OsuButton();
            saveButton4 = new Button();
            profileButton1 = new OsuButton();
            saveButton3 = new Button();
            saveButton2 = new Button();
            saveButton1 = new Button();
            BpmLockCheck = new ToggleIconButton();
            BpmSlider = new OptionSlider();
            HRCheck = new OsuCheckBox();
            ScaleODCheck = new OsuCheckBox();
            ScaleARCheck = new OsuCheckBox();
            BpmMultiplierTextBox = new TextBox();
            NewBpmTextBox = new ScrollableTextBox();
            NewBpmRangeTextBox = new TextBox();
            OriginalBpmRangeTextBox = new TextBox();
            OriginalBpmTextBox = new TextBox();
            renameButton4 = new Button();
            OriginalBpmLabel = new AntiAliasedLabel();
            renameButton3 = new Button();
            NewBpmLabel = new AntiAliasedLabel();
            renameButton2 = new Button();
            BpmMultiplierLabel = new AntiAliasedLabel();
            renameButton1 = new Button();
            editHotkeysButton = new Button();
            Middle1Panel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            ODLockCheck = new ToggleIconButton();
            ARLockCheck = new ToggleIconButton();
            CSLockCheck = new ToggleIconButton();
            odlabel = new AntiAliasedLabel();
            ODDisplay = new TextBox();
            ODSlider = new OptionSlider();
            arlabel = new AntiAliasedLabel();
            ARDisplay = new TextBox();
            ARSlider = new OptionSlider();
            cslabel = new AntiAliasedLabel();
            CSDisplay = new TextBox();
            CSSlider = new OptionSlider();
            hplabel = new AntiAliasedLabel();
            HPDisplay = new TextBox();
            HPSlider = new OptionSlider();
            HPLockCheck = new ToggleIconButton();
            BottomPanel = new Panel();
            ResetButton = new OsuButton();
            GenerateMapButton = new OsuButton();
            SongsFolderButton = new OsuButton();
            TopPanel = new Panel();
            SongDisplay = new SongDisplay();
            OsuRunningTimer = new System.Windows.Forms.Timer(components);
            closeButton = new Button();
            minimizeButton = new Button();
            titlePanel = new Panel();
            BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            formAnimationTimer = new System.Windows.Forms.Timer(components);
            extrasPanel = new Panel();
            ChangePitchCheck = new OsuCheckBox();
            highQualityMp3Check = new OsuCheckBox();
            NoSpinnersCheck = new OsuCheckBox();
            button1 = new Button();
            middlePanel.SuspendLayout();
            Middle1Panel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            BottomPanel.SuspendLayout();
            TopPanel.SuspendLayout();
            titlePanel.SuspendLayout();
            extrasPanel.SuspendLayout();
            SuspendLayout();
            // 
            // BeatmapUpdateTimer
            // 
            BeatmapUpdateTimer.Interval = 20;
            BeatmapUpdateTimer.Tick += BeatmapUpdateTimer_Tick;
            // 
            // middlePanel
            // 
            middlePanel.Controls.Add(showExtrasButton);
            middlePanel.Controls.Add(profileButton4);
            middlePanel.Controls.Add(profileButton3);
            middlePanel.Controls.Add(profileButton2);
            middlePanel.Controls.Add(saveButton4);
            middlePanel.Controls.Add(profileButton1);
            middlePanel.Controls.Add(saveButton3);
            middlePanel.Controls.Add(saveButton2);
            middlePanel.Controls.Add(saveButton1);
            middlePanel.Controls.Add(BpmLockCheck);
            middlePanel.Controls.Add(BpmSlider);
            middlePanel.Controls.Add(HRCheck);
            middlePanel.Controls.Add(ScaleODCheck);
            middlePanel.Controls.Add(ScaleARCheck);
            middlePanel.Controls.Add(BpmMultiplierTextBox);
            middlePanel.Controls.Add(NewBpmTextBox);
            middlePanel.Controls.Add(NewBpmRangeTextBox);
            middlePanel.Controls.Add(OriginalBpmRangeTextBox);
            middlePanel.Controls.Add(OriginalBpmTextBox);
            middlePanel.Controls.Add(renameButton4);
            middlePanel.Controls.Add(OriginalBpmLabel);
            middlePanel.Controls.Add(renameButton3);
            middlePanel.Controls.Add(NewBpmLabel);
            middlePanel.Controls.Add(renameButton2);
            middlePanel.Controls.Add(BpmMultiplierLabel);
            middlePanel.Controls.Add(renameButton1);
            middlePanel.Dock = DockStyle.Top;
            middlePanel.Location = new Point(0, 272);
            middlePanel.Name = "middlePanel";
            middlePanel.Padding = new Padding(10, 5, 10, 5);
            middlePanel.Size = new Size(427, 179);
            middlePanel.TabIndex = 7;
            middlePanel.Click += Unfocus;
            // 
            // showExtrasButton
            // 
            showExtrasButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            showExtrasButton.BackColor = Color.FromArgb(36, 27, 47);
            showExtrasButton.FlatAppearance.BorderSize = 0;
            showExtrasButton.FlatStyle = FlatStyle.Flat;
            showExtrasButton.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showExtrasButton.ForeColor = Color.FromArgb(167, 154, 233);
            showExtrasButton.Location = new Point(0, 159);
            showExtrasButton.Margin = new Padding(0);
            showExtrasButton.Name = "showExtrasButton";
            showExtrasButton.Size = new Size(427, 20);
            showExtrasButton.TabIndex = 26;
            showExtrasButton.Text = "▶ More!";
            showExtrasButton.UseVisualStyleBackColor = false;
            showExtrasButton.Click += showExtrasButton_Click;
            // 
            // profileButton4
            // 
            profileButton4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            profileButton4.ForeColor = Color.White;
            profileButton4.Location = new Point(316, 92);
            profileButton4.Name = "profileButton4";
            profileButton4.Size = new Size(96, 24);
            profileButton4.TabIndex = 24;
            profileButton4.Text = "Profile 4";
            profileButton4.UseVisualStyleBackColor = true;
            profileButton4.Click += profileButton4_Click;
            // 
            // profileButton3
            // 
            profileButton3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            profileButton3.ForeColor = Color.White;
            profileButton3.Location = new Point(214, 92);
            profileButton3.Name = "profileButton3";
            profileButton3.Size = new Size(96, 24);
            profileButton3.TabIndex = 24;
            profileButton3.Text = "Profile 3";
            profileButton3.UseVisualStyleBackColor = true;
            profileButton3.Click += profileButton3_Click;
            // 
            // profileButton2
            // 
            profileButton2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            profileButton2.ForeColor = Color.White;
            profileButton2.Location = new Point(112, 92);
            profileButton2.Name = "profileButton2";
            profileButton2.Size = new Size(96, 24);
            profileButton2.TabIndex = 24;
            profileButton2.Text = "Profile 2";
            profileButton2.UseVisualStyleBackColor = true;
            profileButton2.Click += profileButton2_Click;
            // 
            // saveButton4
            // 
            saveButton4.FlatAppearance.BorderSize = 0;
            saveButton4.FlatStyle = FlatStyle.Flat;
            saveButton4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveButton4.ForeColor = Color.FromArgb(90, 90, 134);
            saveButton4.Location = new Point(315, 115);
            saveButton4.Name = "saveButton4";
            saveButton4.Size = new Size(96, 20);
            saveButton4.TabIndex = 25;
            saveButton4.Text = "Save";
            saveButton4.UseVisualStyleBackColor = true;
            saveButton4.Click += saveButton4_Click;
            // 
            // profileButton1
            // 
            profileButton1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            profileButton1.ForeColor = Color.White;
            profileButton1.Location = new Point(10, 92);
            profileButton1.Name = "profileButton1";
            profileButton1.Size = new Size(96, 24);
            profileButton1.TabIndex = 24;
            profileButton1.Text = "Profile 1";
            profileButton1.UseVisualStyleBackColor = true;
            profileButton1.Click += profileButton1_Click;
            // 
            // saveButton3
            // 
            saveButton3.FlatAppearance.BorderSize = 0;
            saveButton3.FlatStyle = FlatStyle.Flat;
            saveButton3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveButton3.ForeColor = Color.FromArgb(90, 90, 134);
            saveButton3.Location = new Point(214, 115);
            saveButton3.Name = "saveButton3";
            saveButton3.Size = new Size(96, 20);
            saveButton3.TabIndex = 25;
            saveButton3.Text = "Save";
            saveButton3.UseVisualStyleBackColor = true;
            saveButton3.Click += saveButton3_Click;
            // 
            // saveButton2
            // 
            saveButton2.FlatAppearance.BorderSize = 0;
            saveButton2.FlatStyle = FlatStyle.Flat;
            saveButton2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveButton2.ForeColor = Color.FromArgb(90, 90, 134);
            saveButton2.Location = new Point(112, 115);
            saveButton2.Name = "saveButton2";
            saveButton2.Size = new Size(96, 20);
            saveButton2.TabIndex = 25;
            saveButton2.Text = "Save";
            saveButton2.UseVisualStyleBackColor = true;
            saveButton2.Click += saveButton2_Click;
            // 
            // saveButton1
            // 
            saveButton1.FlatAppearance.BorderSize = 0;
            saveButton1.FlatStyle = FlatStyle.Flat;
            saveButton1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveButton1.ForeColor = Color.FromArgb(90, 90, 134);
            saveButton1.Location = new Point(10, 115);
            saveButton1.Name = "saveButton1";
            saveButton1.Size = new Size(96, 20);
            saveButton1.TabIndex = 25;
            saveButton1.Text = "Save";
            saveButton1.UseVisualStyleBackColor = true;
            saveButton1.Click += saveButton1_Click;
            // 
            // BpmLockCheck
            // 
            BpmLockCheck.CheckedImage = (Image)resources.GetObject("BpmLockCheck.CheckedImage");
            BpmLockCheck.Location = new Point(136, 62);
            BpmLockCheck.Name = "BpmLockCheck";
            BpmLockCheck.Size = new Size(21, 21);
            BpmLockCheck.TabIndex = 11;
            BpmLockCheck.UncheckedImage = (Image)resources.GetObject("BpmLockCheck.UncheckedImage");
            BpmLockCheck.UseVisualStyleBackColor = true;
            BpmLockCheck.CheckedChanged += BpmLockCheck_CheckedChanged;
            // 
            // BpmSlider
            // 
            BpmSlider.BodyColor = Color.FromArgb(36, 27, 47);
            BpmSlider.FillDraggingNipple = false;
            BpmSlider.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            BpmSlider.Location = new Point(136, 2);
            BpmSlider.MaxValue = new decimal(new int[] { 2, 0, 0, 0 });
            BpmSlider.MinValue = new decimal(new int[] { 5, 0, 0, 65536 });
            BpmSlider.Name = "BpmSlider";
            BpmSlider.NippleColor = Color.White;
            BpmSlider.NippleDiameter = 15;
            BpmSlider.NippleExpandedDiameter = 18;
            BpmSlider.NippleIdleColor = Color.FromArgb(128, 128, 255);
            BpmSlider.NippleStrokeWidth = 0;
            BpmSlider.Size = new Size(131, 23);
            BpmSlider.TabIndex = 23;
            BpmSlider.Text = "bpmSlider";
            BpmSlider.Thickness = 4;
            BpmSlider.Value = new decimal(new int[] { 1, 0, 0, 0 });
            BpmSlider.ValueChanged += BpmSlider_ValueChanged;
            // 
            // HRCheck
            // 
            HRCheck.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            HRCheck.DisabledColor = Color.FromArgb(136, 134, 144);
            HRCheck.ForeColor = Color.FromArgb(167, 154, 233);
            HRCheck.Location = new Point(285, 4);
            HRCheck.Name = "HRCheck";
            HRCheck.Size = new Size(132, 24);
            HRCheck.TabIndex = 20;
            HRCheck.Text = "HR Circlesize";
            HRCheck.UseVisualStyleBackColor = true;
            HRCheck.CheckedChanged += HRCheck_CheckedChanged;
            // 
            // ScaleODCheck
            // 
            ScaleODCheck.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ScaleODCheck.DisabledColor = Color.FromArgb(136, 134, 144);
            ScaleODCheck.ForeColor = Color.FromArgb(167, 154, 233);
            ScaleODCheck.Location = new Point(313, 61);
            ScaleODCheck.Name = "ScaleODCheck";
            ScaleODCheck.Size = new Size(104, 25);
            ScaleODCheck.TabIndex = 21;
            ScaleODCheck.Text = "Scale OD";
            ScaleODCheck.UseVisualStyleBackColor = true;
            ScaleODCheck.CheckedChanged += ScaleODCheck_CheckedChanged;
            // 
            // ScaleARCheck
            // 
            ScaleARCheck.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ScaleARCheck.DisabledColor = Color.FromArgb(136, 134, 144);
            ScaleARCheck.ForeColor = Color.FromArgb(167, 154, 233);
            ScaleARCheck.Location = new Point(315, 33);
            ScaleARCheck.Name = "ScaleARCheck";
            ScaleARCheck.Size = new Size(102, 24);
            ScaleARCheck.TabIndex = 20;
            ScaleARCheck.Text = "Scale AR";
            ScaleARCheck.UseVisualStyleBackColor = true;
            ScaleARCheck.CheckedChanged += ScaleARCheck_CheckedChanged;
            // 
            // BpmMultiplierTextBox
            // 
            BpmMultiplierTextBox.BackColor = Color.FromArgb(23, 16, 25);
            BpmMultiplierTextBox.BorderStyle = BorderStyle.None;
            BpmMultiplierTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BpmMultiplierTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            BpmMultiplierTextBox.Location = new Point(90, 5);
            BpmMultiplierTextBox.Margin = new Padding(3, 5, 3, 3);
            BpmMultiplierTextBox.Name = "BpmMultiplierTextBox";
            BpmMultiplierTextBox.Size = new Size(42, 20);
            BpmMultiplierTextBox.TabIndex = 10;
            BpmMultiplierTextBox.Text = "1.00";
            BpmMultiplierTextBox.TextAlign = HorizontalAlignment.Center;
            BpmMultiplierTextBox.KeyDown += BpmMultiplierTextBox_KeyDown;
            BpmMultiplierTextBox.Leave += BpmMultiplierTextBox_Submit;
            // 
            // NewBpmTextBox
            // 
            NewBpmTextBox.BackColor = Color.FromArgb(23, 16, 25);
            NewBpmTextBox.BorderStyle = BorderStyle.None;
            NewBpmTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            NewBpmTextBox.Location = new Point(89, 64);
            NewBpmTextBox.Margin = new Padding(3, 5, 3, 3);
            NewBpmTextBox.Name = "NewBpmTextBox";
            NewBpmTextBox.Size = new Size(42, 18);
            NewBpmTextBox.TabIndex = 10;
            NewBpmTextBox.Text = "200";
            NewBpmTextBox.TextAlign = HorizontalAlignment.Center;
            NewBpmTextBox.KeyDown += NewBpmTextBox_KeyDown;
            NewBpmTextBox.KeyPress += NewBpmTextBox_KeyPress;
            NewBpmTextBox.Leave += NewBpmTextBox_Leave;
            // 
            // NewBpmRangeTextBox
            // 
            NewBpmRangeTextBox.BackColor = Color.FromArgb(38, 35, 53);
            NewBpmRangeTextBox.BorderStyle = BorderStyle.None;
            NewBpmRangeTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewBpmRangeTextBox.ForeColor = Color.FromArgb(90, 90, 134);
            NewBpmRangeTextBox.Location = new Point(163, 64);
            NewBpmRangeTextBox.Margin = new Padding(3, 5, 3, 3);
            NewBpmRangeTextBox.Name = "NewBpmRangeTextBox";
            NewBpmRangeTextBox.ReadOnly = true;
            NewBpmRangeTextBox.Size = new Size(85, 18);
            NewBpmRangeTextBox.TabIndex = 10;
            NewBpmRangeTextBox.Text = "(180 - 210)";
            // 
            // OriginalBpmRangeTextBox
            // 
            OriginalBpmRangeTextBox.BackColor = Color.FromArgb(38, 35, 53);
            OriginalBpmRangeTextBox.BorderStyle = BorderStyle.None;
            OriginalBpmRangeTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OriginalBpmRangeTextBox.ForeColor = Color.FromArgb(90, 90, 134);
            OriginalBpmRangeTextBox.Location = new Point(163, 35);
            OriginalBpmRangeTextBox.Margin = new Padding(3, 5, 3, 3);
            OriginalBpmRangeTextBox.Name = "OriginalBpmRangeTextBox";
            OriginalBpmRangeTextBox.ReadOnly = true;
            OriginalBpmRangeTextBox.Size = new Size(85, 18);
            OriginalBpmRangeTextBox.TabIndex = 20;
            OriginalBpmRangeTextBox.Text = "(180 - 210)";
            // 
            // OriginalBpmTextBox
            // 
            OriginalBpmTextBox.BackColor = Color.FromArgb(36, 24, 38);
            OriginalBpmTextBox.BorderStyle = BorderStyle.None;
            OriginalBpmTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OriginalBpmTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            OriginalBpmTextBox.Location = new Point(89, 35);
            OriginalBpmTextBox.Margin = new Padding(3, 5, 3, 3);
            OriginalBpmTextBox.Name = "OriginalBpmTextBox";
            OriginalBpmTextBox.ReadOnly = true;
            OriginalBpmTextBox.Size = new Size(42, 18);
            OriginalBpmTextBox.TabIndex = 10;
            OriginalBpmTextBox.Text = "200";
            OriginalBpmTextBox.TextAlign = HorizontalAlignment.Center;
            OriginalBpmTextBox.Enter += Unfocus;
            // 
            // renameButton4
            // 
            renameButton4.FlatAppearance.BorderSize = 0;
            renameButton4.FlatStyle = FlatStyle.Flat;
            renameButton4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            renameButton4.ForeColor = Color.FromArgb(90, 90, 134);
            renameButton4.Location = new Point(315, 132);
            renameButton4.Name = "renameButton4";
            renameButton4.Size = new Size(96, 20);
            renameButton4.TabIndex = 25;
            renameButton4.Text = "Rename";
            renameButton4.UseVisualStyleBackColor = true;
            renameButton4.Click += renameButton4_Click;
            // 
            // OriginalBpmLabel
            // 
            OriginalBpmLabel.AutoSize = true;
            OriginalBpmLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OriginalBpmLabel.ForeColor = Color.FromArgb(167, 154, 233);
            OriginalBpmLabel.Location = new Point(18, 36);
            OriginalBpmLabel.Margin = new Padding(5, 0, 5, 0);
            OriginalBpmLabel.Name = "OriginalBpmLabel";
            OriginalBpmLabel.Size = new Size(62, 17);
            OriginalBpmLabel.TabIndex = 9;
            OriginalBpmLabel.Text = "Old BPM";
            OriginalBpmLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // renameButton3
            // 
            renameButton3.FlatAppearance.BorderSize = 0;
            renameButton3.FlatStyle = FlatStyle.Flat;
            renameButton3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            renameButton3.ForeColor = Color.FromArgb(90, 90, 134);
            renameButton3.Location = new Point(214, 132);
            renameButton3.Name = "renameButton3";
            renameButton3.Size = new Size(96, 20);
            renameButton3.TabIndex = 25;
            renameButton3.Text = "Rename";
            renameButton3.UseVisualStyleBackColor = true;
            renameButton3.Click += renameButton3_Click;
            // 
            // NewBpmLabel
            // 
            NewBpmLabel.AutoSize = true;
            NewBpmLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NewBpmLabel.ForeColor = Color.FromArgb(167, 154, 233);
            NewBpmLabel.Location = new Point(15, 65);
            NewBpmLabel.Margin = new Padding(5, 0, 5, 0);
            NewBpmLabel.Name = "NewBpmLabel";
            NewBpmLabel.Size = new Size(67, 17);
            NewBpmLabel.TabIndex = 9;
            NewBpmLabel.Text = "New BPM";
            NewBpmLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // renameButton2
            // 
            renameButton2.FlatAppearance.BorderSize = 0;
            renameButton2.FlatStyle = FlatStyle.Flat;
            renameButton2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            renameButton2.ForeColor = Color.FromArgb(90, 90, 134);
            renameButton2.Location = new Point(112, 132);
            renameButton2.Name = "renameButton2";
            renameButton2.Size = new Size(96, 20);
            renameButton2.TabIndex = 25;
            renameButton2.Text = "Rename";
            renameButton2.UseVisualStyleBackColor = true;
            renameButton2.Click += renameButton2_Click;
            // 
            // BpmMultiplierLabel
            // 
            BpmMultiplierLabel.AutoSize = true;
            BpmMultiplierLabel.ForeColor = Color.FromArgb(167, 154, 233);
            BpmMultiplierLabel.Location = new Point(47, 7);
            BpmMultiplierLabel.Margin = new Padding(5, 0, 5, 0);
            BpmMultiplierLabel.Name = "BpmMultiplierLabel";
            BpmMultiplierLabel.Size = new Size(35, 17);
            BpmMultiplierLabel.TabIndex = 1;
            BpmMultiplierLabel.Text = "Rate";
            BpmMultiplierLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // renameButton1
            // 
            renameButton1.DialogResult = DialogResult.OK;
            renameButton1.FlatAppearance.BorderSize = 0;
            renameButton1.FlatStyle = FlatStyle.Flat;
            renameButton1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            renameButton1.ForeColor = Color.FromArgb(90, 90, 134);
            renameButton1.Location = new Point(10, 132);
            renameButton1.Name = "renameButton1";
            renameButton1.Size = new Size(96, 20);
            renameButton1.TabIndex = 25;
            renameButton1.Text = "Rename";
            renameButton1.UseVisualStyleBackColor = true;
            renameButton1.Click += renameButton1_Click;
            // 
            // editHotkeysButton
            // 
            editHotkeysButton.FlatAppearance.BorderSize = 0;
            editHotkeysButton.FlatStyle = FlatStyle.Flat;
            editHotkeysButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editHotkeysButton.ForeColor = Color.FromArgb(167, 154, 233);
            editHotkeysButton.Location = new Point(328, 11);
            editHotkeysButton.Name = "editHotkeysButton";
            editHotkeysButton.Size = new Size(89, 23);
            editHotkeysButton.TabIndex = 25;
            editHotkeysButton.Text = "Edit Hotkeys";
            editHotkeysButton.TextAlign = ContentAlignment.MiddleRight;
            editHotkeysButton.UseVisualStyleBackColor = true;
            editHotkeysButton.Click += editHotkeysButton_Click;
            // 
            // Middle1Panel
            // 
            Middle1Panel.Controls.Add(tableLayoutPanel1);
            Middle1Panel.Dock = DockStyle.Top;
            Middle1Panel.Location = new Point(0, 151);
            Middle1Panel.Margin = new Padding(10, 10, 10, 0);
            Middle1Panel.Name = "Middle1Panel";
            Middle1Panel.Padding = new Padding(10, 3, 15, 5);
            Middle1Panel.Size = new Size(427, 121);
            Middle1Panel.TabIndex = 10;
            Middle1Panel.Click += Unfocus;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.Controls.Add(ODLockCheck, 3, 3);
            tableLayoutPanel1.Controls.Add(ARLockCheck, 3, 2);
            tableLayoutPanel1.Controls.Add(CSLockCheck, 3, 1);
            tableLayoutPanel1.Controls.Add(odlabel, 0, 3);
            tableLayoutPanel1.Controls.Add(ODDisplay, 1, 3);
            tableLayoutPanel1.Controls.Add(ODSlider, 2, 3);
            tableLayoutPanel1.Controls.Add(arlabel, 0, 2);
            tableLayoutPanel1.Controls.Add(ARDisplay, 1, 2);
            tableLayoutPanel1.Controls.Add(ARSlider, 2, 2);
            tableLayoutPanel1.Controls.Add(cslabel, 0, 1);
            tableLayoutPanel1.Controls.Add(CSDisplay, 1, 1);
            tableLayoutPanel1.Controls.Add(CSSlider, 2, 1);
            tableLayoutPanel1.Controls.Add(hplabel, 0, 0);
            tableLayoutPanel1.Controls.Add(HPDisplay, 1, 0);
            tableLayoutPanel1.Controls.Add(HPSlider, 2, 0);
            tableLayoutPanel1.Controls.Add(HPLockCheck, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 12F);
            tableLayoutPanel1.Location = new Point(10, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.00062F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.00063F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.00063F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.99813F));
            tableLayoutPanel1.Size = new Size(402, 113);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ODLockCheck
            // 
            ODLockCheck.CheckedImage = (Image)resources.GetObject("ODLockCheck.CheckedImage");
            ODLockCheck.Location = new Point(379, 87);
            ODLockCheck.Name = "ODLockCheck";
            ODLockCheck.Size = new Size(20, 21);
            ODLockCheck.TabIndex = 15;
            ODLockCheck.UncheckedImage = (Image)resources.GetObject("ODLockCheck.UncheckedImage");
            ODLockCheck.UseVisualStyleBackColor = true;
            ODLockCheck.CheckedChanged += OdLockCheck_CheckedChanged;
            // 
            // ARLockCheck
            // 
            ARLockCheck.CheckedImage = (Image)resources.GetObject("ARLockCheck.CheckedImage");
            ARLockCheck.Location = new Point(379, 59);
            ARLockCheck.Name = "ARLockCheck";
            ARLockCheck.Size = new Size(20, 21);
            ARLockCheck.TabIndex = 14;
            ARLockCheck.UncheckedImage = (Image)resources.GetObject("ARLockCheck.UncheckedImage");
            ARLockCheck.UseVisualStyleBackColor = true;
            ARLockCheck.CheckedChanged += ArLockCheck_CheckedChanged;
            // 
            // CSLockCheck
            // 
            CSLockCheck.CheckedImage = (Image)resources.GetObject("CSLockCheck.CheckedImage");
            CSLockCheck.Location = new Point(379, 31);
            CSLockCheck.Name = "CSLockCheck";
            CSLockCheck.Size = new Size(20, 21);
            CSLockCheck.TabIndex = 13;
            CSLockCheck.UncheckedImage = (Image)resources.GetObject("CSLockCheck.UncheckedImage");
            CSLockCheck.UseVisualStyleBackColor = true;
            CSLockCheck.CheckedChanged += CsLockCheck_CheckedChanged;
            // 
            // odlabel
            // 
            odlabel.AutoSize = true;
            odlabel.Dock = DockStyle.Fill;
            odlabel.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold);
            odlabel.ForeColor = Color.FromArgb(167, 154, 233);
            odlabel.Location = new Point(9, 93);
            odlabel.Margin = new Padding(9, 9, 3, 0);
            odlabel.Name = "odlabel";
            odlabel.Size = new Size(26, 20);
            odlabel.TabIndex = 9;
            odlabel.Text = "OD";
            odlabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ODDisplay
            // 
            ODDisplay.Anchor = AnchorStyles.Left;
            ODDisplay.BackColor = Color.FromArgb(36, 24, 38);
            ODDisplay.BorderStyle = BorderStyle.None;
            ODDisplay.Enabled = false;
            ODDisplay.ForeColor = Color.FromArgb(224, 224, 224);
            ODDisplay.Location = new Point(41, 89);
            ODDisplay.Margin = new Padding(3, 5, 3, 3);
            ODDisplay.Name = "ODDisplay";
            ODDisplay.ReadOnly = true;
            ODDisplay.Size = new Size(35, 22);
            ODDisplay.TabIndex = 10;
            ODDisplay.Text = "0.0";
            ODDisplay.TextAlign = HorizontalAlignment.Center;
            ODDisplay.Enter += Unfocus;
            // 
            // ODSlider
            // 
            ODSlider.BodyColor = Color.FromArgb(36, 27, 47);
            ODSlider.Dock = DockStyle.Fill;
            ODSlider.FillDraggingNipple = false;
            ODSlider.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            ODSlider.Location = new Point(82, 87);
            ODSlider.MaxValue = new decimal(new int[] { 11, 0, 0, 0 });
            ODSlider.MinValue = new decimal(new int[] { 0, 0, 0, 0 });
            ODSlider.Name = "ODSlider";
            ODSlider.NippleColor = Color.FromArgb(240, 240, 255);
            ODSlider.NippleDiameter = 15;
            ODSlider.NippleExpandedDiameter = 18;
            ODSlider.NippleIdleColor = Color.FromArgb(128, 128, 255);
            ODSlider.NippleStrokeWidth = 0;
            ODSlider.Size = new Size(291, 23);
            ODSlider.TabIndex = 11;
            ODSlider.Text = "HPSlider";
            ODSlider.Thickness = 4;
            ODSlider.Value = new decimal(new int[] { 0, 0, 0, 0 });
            ODSlider.ValueChanged += OdSlider_ValueChanged;
            // 
            // arlabel
            // 
            arlabel.AutoSize = true;
            arlabel.Dock = DockStyle.Fill;
            arlabel.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold);
            arlabel.ForeColor = Color.FromArgb(167, 154, 233);
            arlabel.Location = new Point(9, 65);
            arlabel.Margin = new Padding(9, 9, 3, 0);
            arlabel.Name = "arlabel";
            arlabel.Size = new Size(26, 19);
            arlabel.TabIndex = 6;
            arlabel.Text = "AR";
            arlabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ARDisplay
            // 
            ARDisplay.Anchor = AnchorStyles.Left;
            ARDisplay.BackColor = Color.FromArgb(36, 24, 38);
            ARDisplay.BorderStyle = BorderStyle.None;
            ARDisplay.Enabled = false;
            ARDisplay.ForeColor = Color.FromArgb(224, 224, 224);
            ARDisplay.Location = new Point(41, 61);
            ARDisplay.Margin = new Padding(3, 5, 3, 3);
            ARDisplay.Name = "ARDisplay";
            ARDisplay.ReadOnly = true;
            ARDisplay.Size = new Size(35, 22);
            ARDisplay.TabIndex = 7;
            ARDisplay.Text = "0.0";
            ARDisplay.TextAlign = HorizontalAlignment.Center;
            ARDisplay.Enter += Unfocus;
            // 
            // ARSlider
            // 
            ARSlider.BodyColor = Color.FromArgb(36, 27, 47);
            ARSlider.Dock = DockStyle.Fill;
            ARSlider.FillDraggingNipple = false;
            ARSlider.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            ARSlider.Location = new Point(82, 59);
            ARSlider.MaxValue = new decimal(new int[] { 11, 0, 0, 0 });
            ARSlider.MinValue = new decimal(new int[] { 0, 0, 0, 0 });
            ARSlider.Name = "ARSlider";
            ARSlider.NippleColor = Color.FromArgb(240, 240, 255);
            ARSlider.NippleDiameter = 15;
            ARSlider.NippleExpandedDiameter = 18;
            ARSlider.NippleIdleColor = Color.FromArgb(128, 128, 255);
            ARSlider.NippleStrokeWidth = 0;
            ARSlider.Size = new Size(291, 22);
            ARSlider.TabIndex = 8;
            ARSlider.Text = "HPSlider";
            ARSlider.Thickness = 4;
            ARSlider.Value = new decimal(new int[] { 0, 0, 0, 0 });
            ARSlider.ValueChanged += ArSlider_ValueChanged;
            // 
            // cslabel
            // 
            cslabel.AutoSize = true;
            cslabel.Dock = DockStyle.Fill;
            cslabel.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold);
            cslabel.ForeColor = Color.FromArgb(167, 154, 233);
            cslabel.Location = new Point(9, 37);
            cslabel.Margin = new Padding(9, 9, 3, 0);
            cslabel.Name = "cslabel";
            cslabel.Size = new Size(26, 19);
            cslabel.TabIndex = 3;
            cslabel.Text = "CS";
            cslabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CSDisplay
            // 
            CSDisplay.Anchor = AnchorStyles.Left;
            CSDisplay.BackColor = Color.FromArgb(36, 24, 38);
            CSDisplay.BorderStyle = BorderStyle.None;
            CSDisplay.Enabled = false;
            CSDisplay.ForeColor = Color.FromArgb(224, 224, 224);
            CSDisplay.Location = new Point(41, 33);
            CSDisplay.Margin = new Padding(3, 5, 3, 3);
            CSDisplay.Name = "CSDisplay";
            CSDisplay.ReadOnly = true;
            CSDisplay.Size = new Size(35, 22);
            CSDisplay.TabIndex = 4;
            CSDisplay.Text = "0.0";
            CSDisplay.TextAlign = HorizontalAlignment.Center;
            CSDisplay.Enter += Unfocus;
            // 
            // CSSlider
            // 
            CSSlider.BodyColor = Color.FromArgb(36, 27, 47);
            CSSlider.Dock = DockStyle.Fill;
            CSSlider.FillDraggingNipple = false;
            CSSlider.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            CSSlider.Location = new Point(82, 31);
            CSSlider.Margin = new Padding(3, 3, 28, 3);
            CSSlider.MaxValue = new decimal(new int[] { 10, 0, 0, 0 });
            CSSlider.MinValue = new decimal(new int[] { 0, 0, 0, 0 });
            CSSlider.Name = "CSSlider";
            CSSlider.NippleColor = Color.FromArgb(240, 240, 255);
            CSSlider.NippleDiameter = 15;
            CSSlider.NippleExpandedDiameter = 18;
            CSSlider.NippleIdleColor = Color.FromArgb(128, 128, 255);
            CSSlider.NippleStrokeWidth = 0;
            CSSlider.Size = new Size(266, 22);
            CSSlider.TabIndex = 5;
            CSSlider.Text = "HPSlider";
            CSSlider.Thickness = 4;
            CSSlider.Value = new decimal(new int[] { 0, 0, 0, 0 });
            CSSlider.ValueChanged += CsSlider_ValueChanged;
            // 
            // hplabel
            // 
            hplabel.AutoSize = true;
            hplabel.Dock = DockStyle.Fill;
            hplabel.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold);
            hplabel.ForeColor = Color.FromArgb(167, 154, 233);
            hplabel.Location = new Point(9, 9);
            hplabel.Margin = new Padding(9, 9, 3, 0);
            hplabel.Name = "hplabel";
            hplabel.Size = new Size(26, 19);
            hplabel.TabIndex = 0;
            hplabel.Text = "HP";
            hplabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // HPDisplay
            // 
            HPDisplay.Anchor = AnchorStyles.Left;
            HPDisplay.BackColor = Color.FromArgb(36, 24, 38);
            HPDisplay.BorderStyle = BorderStyle.None;
            HPDisplay.Enabled = false;
            HPDisplay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HPDisplay.ForeColor = Color.FromArgb(224, 224, 224);
            HPDisplay.Location = new Point(41, 5);
            HPDisplay.Margin = new Padding(3, 5, 3, 3);
            HPDisplay.Name = "HPDisplay";
            HPDisplay.ReadOnly = true;
            HPDisplay.Size = new Size(35, 22);
            HPDisplay.TabIndex = 1;
            HPDisplay.Text = "0.0";
            HPDisplay.TextAlign = HorizontalAlignment.Center;
            HPDisplay.Enter += Unfocus;
            // 
            // HPSlider
            // 
            HPSlider.BodyColor = Color.FromArgb(36, 27, 47);
            HPSlider.Dock = DockStyle.Fill;
            HPSlider.FillDraggingNipple = false;
            HPSlider.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            HPSlider.Location = new Point(82, 3);
            HPSlider.Margin = new Padding(3, 3, 28, 3);
            HPSlider.MaxValue = new decimal(new int[] { 10, 0, 0, 0 });
            HPSlider.MinValue = new decimal(new int[] { 0, 0, 0, 0 });
            HPSlider.Name = "HPSlider";
            HPSlider.NippleColor = Color.FromArgb(240, 240, 255);
            HPSlider.NippleDiameter = 15;
            HPSlider.NippleExpandedDiameter = 18;
            HPSlider.NippleIdleColor = Color.FromArgb(128, 128, 255);
            HPSlider.NippleStrokeWidth = 0;
            HPSlider.Size = new Size(266, 22);
            HPSlider.TabIndex = 2;
            HPSlider.Text = "HPSlider";
            HPSlider.Thickness = 4;
            HPSlider.Value = new decimal(new int[] { 0, 0, 0, 0 });
            HPSlider.ValueChanged += HpSlider_ValueChanged;
            // 
            // HPLockCheck
            // 
            HPLockCheck.CheckedImage = (Image)resources.GetObject("HPLockCheck.CheckedImage");
            HPLockCheck.Location = new Point(379, 3);
            HPLockCheck.Name = "HPLockCheck";
            HPLockCheck.Size = new Size(20, 21);
            HPLockCheck.TabIndex = 12;
            HPLockCheck.UncheckedImage = (Image)resources.GetObject("HPLockCheck.UncheckedImage");
            HPLockCheck.UseVisualStyleBackColor = true;
            HPLockCheck.CheckedChanged += HpLockCheck_CheckedChanged;
            // 
            // BottomPanel
            // 
            BottomPanel.Controls.Add(ResetButton);
            BottomPanel.Controls.Add(GenerateMapButton);
            BottomPanel.Controls.Add(SongsFolderButton);
            BottomPanel.Dock = DockStyle.Bottom;
            BottomPanel.Location = new Point(0, 552);
            BottomPanel.Name = "BottomPanel";
            BottomPanel.Padding = new Padding(10, 5, 10, 10);
            BottomPanel.Size = new Size(427, 111);
            BottomPanel.TabIndex = 11;
            BottomPanel.Click += Unfocus;
            // 
            // ResetButton
            // 
            ResetButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ResetButton.FlatAppearance.BorderColor = Color.DarkGray;
            ResetButton.FlatStyle = FlatStyle.Flat;
            ResetButton.Font = new Font("Segoe UI", 12F);
            ResetButton.ForeColor = Color.White;
            ResetButton.Location = new Point(10, 37);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(130, 61);
            ResetButton.TabIndex = 1;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // GenerateMapButton
            // 
            GenerateMapButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            GenerateMapButton.BackColor = Color.Transparent;
            GenerateMapButton.FlatStyle = FlatStyle.Flat;
            GenerateMapButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GenerateMapButton.ForeColor = Color.White;
            GenerateMapButton.Location = new Point(146, 37);
            GenerateMapButton.Margin = new Padding(30, 3, 30, 3);
            GenerateMapButton.Name = "GenerateMapButton";
            GenerateMapButton.Size = new Size(271, 62);
            GenerateMapButton.TabIndex = 0;
            GenerateMapButton.Text = "Create Map";
            GenerateMapButton.UseVisualStyleBackColor = false;
            GenerateMapButton.Click += GenerateMapButton_Click;
            // 
            // SongsFolderButton
            // 
            SongsFolderButton.FlatAppearance.BorderColor = Color.DarkGray;
            SongsFolderButton.FlatStyle = FlatStyle.Flat;
            SongsFolderButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SongsFolderButton.ForeColor = Color.White;
            SongsFolderButton.Location = new Point(10, 3);
            SongsFolderButton.Name = "SongsFolderButton";
            SongsFolderButton.Size = new Size(407, 28);
            SongsFolderButton.TabIndex = 1;
            SongsFolderButton.Text = "Songs Folder";
            SongsFolderButton.UseVisualStyleBackColor = true;
            SongsFolderButton.Click += SongsFolderButton_Click;
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.FromArgb(36, 27, 47);
            TopPanel.Controls.Add(SongDisplay);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 30);
            TopPanel.Name = "TopPanel";
            TopPanel.Padding = new Padding(10);
            TopPanel.Size = new Size(427, 121);
            TopPanel.TabIndex = 12;
            // 
            // SongDisplay
            // 
            SongDisplay.Dock = DockStyle.Fill;
            SongDisplay.Location = new Point(10, 10);
            SongDisplay.Name = "SongDisplay";
            SongDisplay.Size = new Size(407, 101);
            SongDisplay.TabIndex = 7;
            SongDisplay.Text = "songDisplay1";
            // 
            // OsuRunningTimer
            // 
            OsuRunningTimer.Interval = 500;
            OsuRunningTimer.Tick += OsuRunningTimer_Tick;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.FromArgb(36, 27, 47);
            closeButton.Dock = DockStyle.Right;
            closeButton.FlatAppearance.BorderColor = Color.FromArgb(36, 27, 47);
            closeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(139, 10, 20);
            closeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 17, 35);
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Segoe UI Semilight", 9F);
            closeButton.ForeColor = SystemColors.ButtonFace;
            closeButton.Location = new Point(382, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(45, 30);
            closeButton.TabIndex = 3;
            closeButton.Text = "✕";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // minimizeButton
            // 
            minimizeButton.BackColor = Color.FromArgb(36, 27, 47);
            minimizeButton.Dock = DockStyle.Right;
            minimizeButton.FlatAppearance.BorderColor = Color.FromArgb(36, 27, 47);
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.Font = new Font("Segoe UI Semilight", 9F);
            minimizeButton.ForeColor = SystemColors.ButtonFace;
            minimizeButton.Location = new Point(337, 0);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new Size(45, 30);
            minimizeButton.TabIndex = 3;
            minimizeButton.Text = "🗕";
            minimizeButton.UseVisualStyleBackColor = false;
            minimizeButton.Click += minimizeButton_Click;
            // 
            // titlePanel
            // 
            titlePanel.BackColor = Color.FromArgb(36, 27, 47);
            titlePanel.Controls.Add(minimizeButton);
            titlePanel.Controls.Add(closeButton);
            titlePanel.Dock = DockStyle.Top;
            titlePanel.Location = new Point(0, 0);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(427, 30);
            titlePanel.TabIndex = 14;
            titlePanel.Paint += titlePanel_Paint;
            titlePanel.MouseDown += PanelMove_MouseDown;
            titlePanel.MouseMove += PanelMove_MouseMove;
            titlePanel.MouseUp += PanelMove_MouseUp;
            // 
            // BackgroundWorker
            // 
            BackgroundWorker.DoWork += BackgroundWorker_DoWork;
            BackgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            // 
            // formAnimationTimer
            // 
            formAnimationTimer.Interval = 16;
            formAnimationTimer.Tick += formAnimationTimer_Tick;
            // 
            // extrasPanel
            // 
            extrasPanel.BackColor = Color.FromArgb(31, 29, 44);
            extrasPanel.Controls.Add(ChangePitchCheck);
            extrasPanel.Controls.Add(highQualityMp3Check);
            extrasPanel.Controls.Add(NoSpinnersCheck);
            extrasPanel.Controls.Add(button1);
            extrasPanel.Controls.Add(editHotkeysButton);
            extrasPanel.Dock = DockStyle.Top;
            extrasPanel.Location = new Point(0, 451);
            extrasPanel.Name = "extrasPanel";
            extrasPanel.Size = new Size(427, 102);
            extrasPanel.TabIndex = 15;
            extrasPanel.Visible = false;
            // 
            // ChangePitchCheck
            // 
            ChangePitchCheck.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ChangePitchCheck.DisabledColor = Color.FromArgb(136, 134, 144);
            ChangePitchCheck.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            ChangePitchCheck.ForeColor = Color.FromArgb(167, 154, 233);
            ChangePitchCheck.Location = new Point(2, 9);
            ChangePitchCheck.Name = "ChangePitchCheck";
            ChangePitchCheck.RightToLeft = RightToLeft.No;
            ChangePitchCheck.Size = new Size(130, 24);
            ChangePitchCheck.TabIndex = 22;
            ChangePitchCheck.Text = "Change pitch";
            ChangePitchCheck.TextOnRight = true;
            ChangePitchCheck.UseVisualStyleBackColor = true;
            ChangePitchCheck.CheckedChanged += ChangePitchButton_CheckedChanged;
            // 
            // highQualityMp3Check
            // 
            highQualityMp3Check.DisabledColor = Color.FromArgb(136, 134, 144);
            highQualityMp3Check.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            highQualityMp3Check.ForeColor = Color.FromArgb(167, 154, 233);
            highQualityMp3Check.Location = new Point(2, 69);
            highQualityMp3Check.Name = "highQualityMp3Check";
            highQualityMp3Check.Size = new Size(155, 24);
            highQualityMp3Check.TabIndex = 20;
            highQualityMp3Check.Text = "High quality mp3";
            highQualityMp3Check.TextOnRight = true;
            highQualityMp3Check.UseVisualStyleBackColor = true;
            highQualityMp3Check.CheckedChanged += highQualityCheckBox_CheckedChanged;
            // 
            // NoSpinnersCheck
            // 
            NoSpinnersCheck.DisabledColor = Color.FromArgb(136, 134, 144);
            NoSpinnersCheck.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            NoSpinnersCheck.ForeColor = Color.FromArgb(167, 154, 233);
            NoSpinnersCheck.Location = new Point(2, 39);
            NoSpinnersCheck.Name = "NoSpinnersCheck";
            NoSpinnersCheck.Size = new Size(124, 24);
            NoSpinnersCheck.TabIndex = 20;
            NoSpinnersCheck.Text = "No spinners";
            NoSpinnersCheck.TextOnRight = true;
            NoSpinnersCheck.UseVisualStyleBackColor = true;
            NoSpinnersCheck.CheckedChanged += NoSpinnerCheckBox_CheckedChanged;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(167, 154, 233);
            button1.Location = new Point(280, 38);
            button1.Name = "button1";
            button1.Size = new Size(137, 23);
            button1.TabIndex = 25;
            button1.Text = "Delete Unused MP3s";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += DeleteButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 35, 53);
            ClientSize = new Size(427, 663);
            Controls.Add(extrasPanel);
            Controls.Add(middlePanel);
            Controls.Add(Middle1Panel);
            Controls.Add(BottomPanel);
            Controls.Add(TopPanel);
            Controls.Add(titlePanel);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(5, 3, 5, 3);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "osu trainer";
            FormClosing += MainForm_FormClosing;
            middlePanel.ResumeLayout(false);
            middlePanel.PerformLayout();
            Middle1Panel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            BottomPanel.ResumeLayout(false);
            TopPanel.ResumeLayout(false);
            titlePanel.ResumeLayout(false);
            extrasPanel.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private AntiAliasedLabel BpmMultiplierLabel;
        private System.Windows.Forms.Timer BeatmapUpdateTimer;
        private AntiAliasedLabel OriginalBpmLabel;
        private AntiAliasedLabel NewBpmLabel;
        private OsuButton GenerateMapButton;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel middlePanel;
        private System.Windows.Forms.Panel Middle1Panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private AntiAliasedLabel hplabel;
        private System.Windows.Forms.TextBox HPDisplay;
        private OptionSlider HPSlider;
        private AntiAliasedLabel odlabel;
        private System.Windows.Forms.TextBox ODDisplay;
        private OptionSlider ODSlider;
        private AntiAliasedLabel arlabel;
        private System.Windows.Forms.TextBox ARDisplay;
        private OptionSlider ARSlider;
        private AntiAliasedLabel cslabel;
        private System.Windows.Forms.TextBox CSDisplay;
        private OptionSlider CSSlider;
        private System.Windows.Forms.TextBox NewBpmRangeTextBox;
        private System.Windows.Forms.TextBox OriginalBpmRangeTextBox;
        private System.Windows.Forms.TextBox OriginalBpmTextBox;
        private OsuButton ResetButton;
        private System.Windows.Forms.Timer OsuRunningTimer;
        private OsuCheckBox ScaleARCheck;
        private OsuCheckBox ChangePitchCheck;
        private OsuCheckBox ScaleODCheck;
        private ToggleIconButton ODLockCheck;
        private ToggleIconButton ARLockCheck;
        private ToggleIconButton CSLockCheck;
        private ToggleIconButton HPLockCheck;
        private SongDisplay SongDisplay;
        private OsuCheckBox NoSpinnersCheck;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Panel titlePanel;
        private OptionSlider BpmSlider;
        private ToggleIconButton BpmLockCheck;
        private OsuCheckBox HRCheck;
        private OsuButton SongsFolderButton;
        private ScrollableTextBox NewBpmTextBox;
        private System.Windows.Forms.TextBox BpmMultiplierTextBox;
        private System.Windows.Forms.Button renameButton1;
        private System.Windows.Forms.Button saveButton1;
        private OsuButton profileButton3;
        private OsuButton profileButton2;
        private OsuButton profileButton1;
        private System.Windows.Forms.Button saveButton3;
        private System.Windows.Forms.Button saveButton2;
        private System.Windows.Forms.Button renameButton3;
        private System.Windows.Forms.Button renameButton2;
        private OsuButton profileButton4;
        private System.Windows.Forms.Button saveButton4;
        private System.Windows.Forms.Button renameButton4;
        private System.Windows.Forms.Button editHotkeysButton;
        public System.ComponentModel.BackgroundWorker BackgroundWorker;
        private System.Windows.Forms.Timer formAnimationTimer;
        private System.Windows.Forms.Button showExtrasButton;
        private System.Windows.Forms.Panel extrasPanel;
        private System.Windows.Forms.Button button1;
        private OsuCheckBox highQualityMp3Check;
    }
}
﻿// <copyright file="ConsolidateDirectoryForm.Designer.cs" company="PUblicDomain.com">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
// <auto-generated />
namespace ConsolidateDirectory
{
    partial class ConsolidateDirectoryForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsolidateDirectoryForm));
        	this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
        	this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.dailyReleasesPublicDomainDailycomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.originalThreadDonationCodercomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.sourceCodeGithubcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
        	this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
        	this.mainToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.countToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.patternTextBox = new System.Windows.Forms.TextBox();
        	this.patternReferenceLinkLabel = new System.Windows.Forms.LinkLabel();
        	this.filterLabel = new System.Windows.Forms.Label();
        	this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
        	this.onFinishGroupBox = new System.Windows.Forms.GroupBox();
        	this.zapSourceCheckBox = new System.Windows.Forms.CheckBox();
        	this.modeGroupBox = new System.Windows.Forms.GroupBox();
        	this.moveFilesRadioButton = new System.Windows.Forms.RadioButton();
        	this.copyFilesRadioButton = new System.Windows.Forms.RadioButton();
        	this.consolidateDirectoryButton = new System.Windows.Forms.Button();
        	this.destionationGroupBox = new System.Windows.Forms.GroupBox();
        	this.selectedRadioButton = new System.Windows.Forms.RadioButton();
        	this.browseRadioButton = new System.Windows.Forms.RadioButton();
        	this.onFileExistsGroupBox = new System.Windows.Forms.GroupBox();
        	this.overwriteCheckBox = new System.Windows.Forms.CheckBox();
        	this.subdirectoriesGroupBox = new System.Windows.Forms.GroupBox();
        	this.flattenRadioButton = new System.Windows.Forms.RadioButton();
        	this.preserveRadioButton = new System.Windows.Forms.RadioButton();
        	this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
        	this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
        	this.mainMenuStrip.SuspendLayout();
        	this.mainStatusStrip.SuspendLayout();
        	this.tableLayoutPanel.SuspendLayout();
        	this.onFinishGroupBox.SuspendLayout();
        	this.modeGroupBox.SuspendLayout();
        	this.destionationGroupBox.SuspendLayout();
        	this.onFileExistsGroupBox.SuspendLayout();
        	this.subdirectoriesGroupBox.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// mainMenuStrip
        	// 
        	this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.fileToolStripMenuItem,
        	        	        	this.helpToolStripMenuItem,
        	        	        	this.minimizeToolStripMenuItem});
        	this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
        	this.mainMenuStrip.Name = "mainMenuStrip";
        	this.mainMenuStrip.Size = new System.Drawing.Size(244, 24);
        	this.mainMenuStrip.TabIndex = 21;
        	// 
        	// fileToolStripMenuItem
        	// 
        	this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.exitToolStripMenuItem});
        	this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        	this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
        	this.fileToolStripMenuItem.Text = "&File";
        	// 
        	// exitToolStripMenuItem
        	// 
        	this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        	this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
        	this.exitToolStripMenuItem.Text = "E&xit";
        	this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
        	// 
        	// helpToolStripMenuItem
        	// 
        	this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.dailyReleasesPublicDomainDailycomToolStripMenuItem,
        	        	        	this.originalThreadDonationCodercomToolStripMenuItem,
        	        	        	this.sourceCodeGithubcomToolStripMenuItem,
        	        	        	this.toolStripSeparator2,
        	        	        	this.aboutToolStripMenuItem});
        	this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        	this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
        	this.helpToolStripMenuItem.Text = "&Help";
        	// 
        	// dailyReleasesPublicDomainDailycomToolStripMenuItem
        	// 
        	this.dailyReleasesPublicDomainDailycomToolStripMenuItem.Name = "dailyReleasesPublicDomainDailycomToolStripMenuItem";
        	this.dailyReleasesPublicDomainDailycomToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
        	this.dailyReleasesPublicDomainDailycomToolStripMenuItem.Text = "Daily releases @ PublicDomainDaily.com";
        	// 
        	// originalThreadDonationCodercomToolStripMenuItem
        	// 
        	this.originalThreadDonationCodercomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("originalThreadDonationCodercomToolStripMenuItem.Image")));
        	this.originalThreadDonationCodercomToolStripMenuItem.Name = "originalThreadDonationCodercomToolStripMenuItem";
        	this.originalThreadDonationCodercomToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
        	this.originalThreadDonationCodercomToolStripMenuItem.Text = "&Original thread @ DonationCoder.com";
        	// 
        	// sourceCodeGithubcomToolStripMenuItem
        	// 
        	this.sourceCodeGithubcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sourceCodeGithubcomToolStripMenuItem.Image")));
        	this.sourceCodeGithubcomToolStripMenuItem.Name = "sourceCodeGithubcomToolStripMenuItem";
        	this.sourceCodeGithubcomToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
        	this.sourceCodeGithubcomToolStripMenuItem.Text = "Source code @ Github.com";
        	// 
        	// toolStripSeparator2
        	// 
        	this.toolStripSeparator2.Name = "toolStripSeparator2";
        	this.toolStripSeparator2.Size = new System.Drawing.Size(286, 6);
        	// 
        	// aboutToolStripMenuItem
        	// 
        	this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        	this.aboutToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
        	this.aboutToolStripMenuItem.Text = "&About...";
        	// 
        	// minimizeToolStripMenuItem
        	// 
        	this.minimizeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
        	this.minimizeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("minimizeToolStripMenuItem.Image")));
        	this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
        	this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
        	this.minimizeToolStripMenuItem.Visible = false;
        	// 
        	// mainStatusStrip
        	// 
        	this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.mainToolStripStatusLabel,
        	        	        	this.countToolStripStatusLabel});
        	this.mainStatusStrip.Location = new System.Drawing.Point(0, 277);
        	this.mainStatusStrip.Name = "mainStatusStrip";
        	this.mainStatusStrip.Size = new System.Drawing.Size(244, 22);
        	this.mainStatusStrip.SizingGrip = false;
        	this.mainStatusStrip.TabIndex = 20;
        	this.mainStatusStrip.Text = "HELLO";
        	// 
        	// mainToolStripStatusLabel
        	// 
        	this.mainToolStripStatusLabel.Name = "mainToolStripStatusLabel";
        	this.mainToolStripStatusLabel.Size = new System.Drawing.Size(90, 17);
        	this.mainToolStripStatusLabel.Text = "Files to process:";
        	// 
        	// countToolStripStatusLabel
        	// 
        	this.countToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.countToolStripStatusLabel.Name = "countToolStripStatusLabel";
        	this.countToolStripStatusLabel.Size = new System.Drawing.Size(75, 17);
        	this.countToolStripStatusLabel.Text = "Calculating...";
        	// 
        	// patternTextBox
        	// 
        	this.tableLayoutPanel.SetColumnSpan(this.patternTextBox, 2);
        	this.patternTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.patternTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.patternTextBox.Location = new System.Drawing.Point(3, 23);
        	this.patternTextBox.Name = "patternTextBox";
        	this.patternTextBox.Size = new System.Drawing.Size(238, 20);
        	this.patternTextBox.TabIndex = 0;
        	this.patternTextBox.Text = "*.*";
        	this.patternTextBox.TextChanged += new System.EventHandler(this.OnPatternTextBoxTextChanged);
        	// 
        	// patternReferenceLinkLabel
        	// 
        	this.patternReferenceLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.patternReferenceLinkLabel.Location = new System.Drawing.Point(125, 0);
        	this.patternReferenceLinkLabel.Name = "patternReferenceLinkLabel";
        	this.patternReferenceLinkLabel.Size = new System.Drawing.Size(116, 20);
        	this.patternReferenceLinkLabel.TabIndex = 1;
        	this.patternReferenceLinkLabel.TabStop = true;
        	this.patternReferenceLinkLabel.Text = "(Pattern &reference)";
        	this.patternReferenceLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        	this.patternReferenceLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnPatternReferenceLinkLabelLinkClicked);
        	// 
        	// filterLabel
        	// 
        	this.filterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.filterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.filterLabel.Location = new System.Drawing.Point(3, 0);
        	this.filterLabel.Name = "filterLabel";
        	this.filterLabel.Size = new System.Drawing.Size(116, 20);
        	this.filterLabel.TabIndex = 0;
        	this.filterLabel.Text = "Filter:";
        	this.filterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// tableLayoutPanel
        	// 
        	this.tableLayoutPanel.ColumnCount = 2;
        	this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.tableLayoutPanel.Controls.Add(this.onFinishGroupBox, 1, 3);
        	this.tableLayoutPanel.Controls.Add(this.modeGroupBox, 0, 2);
        	this.tableLayoutPanel.Controls.Add(this.filterLabel, 0, 0);
        	this.tableLayoutPanel.Controls.Add(this.patternReferenceLinkLabel, 1, 0);
        	this.tableLayoutPanel.Controls.Add(this.patternTextBox, 0, 1);
        	this.tableLayoutPanel.Controls.Add(this.consolidateDirectoryButton, 0, 5);
        	this.tableLayoutPanel.Controls.Add(this.destionationGroupBox, 1, 2);
        	this.tableLayoutPanel.Controls.Add(this.onFileExistsGroupBox, 0, 3);
        	this.tableLayoutPanel.Controls.Add(this.subdirectoriesGroupBox, 0, 4);
        	this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tableLayoutPanel.Location = new System.Drawing.Point(0, 24);
        	this.tableLayoutPanel.Name = "tableLayoutPanel";
        	this.tableLayoutPanel.RowCount = 6;
        	this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        	this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        	this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
        	this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
        	this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
        	this.tableLayoutPanel.Size = new System.Drawing.Size(244, 253);
        	this.tableLayoutPanel.TabIndex = 22;
        	// 
        	// onFinishGroupBox
        	// 
        	this.onFinishGroupBox.Controls.Add(this.zapSourceCheckBox);
        	this.onFinishGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.onFinishGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
        	this.onFinishGroupBox.Location = new System.Drawing.Point(125, 117);
        	this.onFinishGroupBox.Name = "onFinishGroupBox";
        	this.onFinishGroupBox.Size = new System.Drawing.Size(116, 46);
        	this.onFinishGroupBox.TabIndex = 26;
        	this.onFinishGroupBox.TabStop = false;
        	this.onFinishGroupBox.Text = "On finish";
        	// 
        	// zapSourceCheckBox
        	// 
        	this.zapSourceCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
        	this.zapSourceCheckBox.Location = new System.Drawing.Point(12, 18);
        	this.zapSourceCheckBox.Name = "zapSourceCheckBox";
        	this.zapSourceCheckBox.Size = new System.Drawing.Size(104, 24);
        	this.zapSourceCheckBox.TabIndex = 0;
        	this.zapSourceCheckBox.Text = "&Zap source";
        	this.zapSourceCheckBox.UseVisualStyleBackColor = true;
        	this.zapSourceCheckBox.CheckedChanged += new System.EventHandler(this.OnCheckBoxCheckedChanged);
        	// 
        	// modeGroupBox
        	// 
        	this.modeGroupBox.Controls.Add(this.moveFilesRadioButton);
        	this.modeGroupBox.Controls.Add(this.copyFilesRadioButton);
        	this.modeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.modeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.modeGroupBox.Location = new System.Drawing.Point(3, 43);
        	this.modeGroupBox.Name = "modeGroupBox";
        	this.modeGroupBox.Size = new System.Drawing.Size(116, 68);
        	this.modeGroupBox.TabIndex = 23;
        	this.modeGroupBox.TabStop = false;
        	this.modeGroupBox.Text = "Mode";
        	// 
        	// moveFilesRadioButton
        	// 
        	this.moveFilesRadioButton.Checked = true;
        	this.moveFilesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.moveFilesRadioButton.ForeColor = System.Drawing.Color.Red;
        	this.moveFilesRadioButton.Location = new System.Drawing.Point(12, 19);
        	this.moveFilesRadioButton.Name = "moveFilesRadioButton";
        	this.moveFilesRadioButton.Size = new System.Drawing.Size(104, 24);
        	this.moveFilesRadioButton.TabIndex = 1;
        	this.moveFilesRadioButton.TabStop = true;
        	this.moveFilesRadioButton.Text = "&Move files";
        	this.moveFilesRadioButton.UseVisualStyleBackColor = true;
        	this.moveFilesRadioButton.CheckedChanged += new System.EventHandler(this.OnRadioButtonCheckedChanged);
        	// 
        	// copyFilesRadioButton
        	// 
        	this.copyFilesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.copyFilesRadioButton.Location = new System.Drawing.Point(12, 43);
        	this.copyFilesRadioButton.Name = "copyFilesRadioButton";
        	this.copyFilesRadioButton.Size = new System.Drawing.Size(104, 24);
        	this.copyFilesRadioButton.TabIndex = 1;
        	this.copyFilesRadioButton.Text = "&Copy files";
        	this.copyFilesRadioButton.UseVisualStyleBackColor = true;
        	this.copyFilesRadioButton.CheckedChanged += new System.EventHandler(this.OnRadioButtonCheckedChanged);
        	// 
        	// consolidateDirectoryButton
        	// 
        	this.tableLayoutPanel.SetColumnSpan(this.consolidateDirectoryButton, 2);
        	this.consolidateDirectoryButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.consolidateDirectoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.consolidateDirectoryButton.Location = new System.Drawing.Point(3, 221);
        	this.consolidateDirectoryButton.Name = "consolidateDirectoryButton";
        	this.consolidateDirectoryButton.Size = new System.Drawing.Size(238, 29);
        	this.consolidateDirectoryButton.TabIndex = 3;
        	this.consolidateDirectoryButton.Text = "Consolidate directory";
        	this.consolidateDirectoryButton.UseVisualStyleBackColor = true;
        	this.consolidateDirectoryButton.Click += new System.EventHandler(this.OnConsolidateDirectoryButtonClick);
        	// 
        	// destionationGroupBox
        	// 
        	this.destionationGroupBox.Controls.Add(this.selectedRadioButton);
        	this.destionationGroupBox.Controls.Add(this.browseRadioButton);
        	this.destionationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.destionationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.destionationGroupBox.Location = new System.Drawing.Point(125, 43);
        	this.destionationGroupBox.Name = "destionationGroupBox";
        	this.destionationGroupBox.Size = new System.Drawing.Size(116, 68);
        	this.destionationGroupBox.TabIndex = 24;
        	this.destionationGroupBox.TabStop = false;
        	this.destionationGroupBox.Text = "Destination";
        	// 
        	// selectedRadioButton
        	// 
        	this.selectedRadioButton.Checked = true;
        	this.selectedRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.selectedRadioButton.ForeColor = System.Drawing.Color.Red;
        	this.selectedRadioButton.Location = new System.Drawing.Point(12, 19);
        	this.selectedRadioButton.Name = "selectedRadioButton";
        	this.selectedRadioButton.Size = new System.Drawing.Size(104, 24);
        	this.selectedRadioButton.TabIndex = 2;
        	this.selectedRadioButton.TabStop = true;
        	this.selectedRadioButton.Text = "&Selected";
        	this.selectedRadioButton.UseVisualStyleBackColor = true;
        	this.selectedRadioButton.CheckedChanged += new System.EventHandler(this.OnRadioButtonCheckedChanged);
        	// 
        	// browseRadioButton
        	// 
        	this.browseRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.browseRadioButton.Location = new System.Drawing.Point(12, 43);
        	this.browseRadioButton.Name = "browseRadioButton";
        	this.browseRadioButton.Size = new System.Drawing.Size(104, 19);
        	this.browseRadioButton.TabIndex = 2;
        	this.browseRadioButton.Text = "&Browse";
        	this.browseRadioButton.UseVisualStyleBackColor = true;
        	this.browseRadioButton.CheckedChanged += new System.EventHandler(this.OnRadioButtonCheckedChanged);
        	// 
        	// onFileExistsGroupBox
        	// 
        	this.onFileExistsGroupBox.Controls.Add(this.overwriteCheckBox);
        	this.onFileExistsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.onFileExistsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
        	this.onFileExistsGroupBox.Location = new System.Drawing.Point(3, 117);
        	this.onFileExistsGroupBox.Name = "onFileExistsGroupBox";
        	this.onFileExistsGroupBox.Size = new System.Drawing.Size(116, 46);
        	this.onFileExistsGroupBox.TabIndex = 25;
        	this.onFileExistsGroupBox.TabStop = false;
        	this.onFileExistsGroupBox.Text = "On file exists";
        	// 
        	// overwriteCheckBox
        	// 
        	this.overwriteCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
        	this.overwriteCheckBox.Location = new System.Drawing.Point(12, 19);
        	this.overwriteCheckBox.Name = "overwriteCheckBox";
        	this.overwriteCheckBox.Size = new System.Drawing.Size(104, 24);
        	this.overwriteCheckBox.TabIndex = 0;
        	this.overwriteCheckBox.Text = "&Overwrite";
        	this.overwriteCheckBox.UseVisualStyleBackColor = true;
        	this.overwriteCheckBox.CheckedChanged += new System.EventHandler(this.OnCheckBoxCheckedChanged);
        	// 
        	// subdirectoriesGroupBox
        	// 
        	this.tableLayoutPanel.SetColumnSpan(this.subdirectoriesGroupBox, 2);
        	this.subdirectoriesGroupBox.Controls.Add(this.flattenRadioButton);
        	this.subdirectoriesGroupBox.Controls.Add(this.preserveRadioButton);
        	this.subdirectoriesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.subdirectoriesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
        	this.subdirectoriesGroupBox.Location = new System.Drawing.Point(3, 169);
        	this.subdirectoriesGroupBox.Name = "subdirectoriesGroupBox";
        	this.subdirectoriesGroupBox.Size = new System.Drawing.Size(238, 46);
        	this.subdirectoriesGroupBox.TabIndex = 27;
        	this.subdirectoriesGroupBox.TabStop = false;
        	this.subdirectoriesGroupBox.Text = "Subdirectories";
        	// 
        	// flattenRadioButton
        	// 
        	this.flattenRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
        	this.flattenRadioButton.Location = new System.Drawing.Point(128, 19);
        	this.flattenRadioButton.Name = "flattenRadioButton";
        	this.flattenRadioButton.Size = new System.Drawing.Size(104, 24);
        	this.flattenRadioButton.TabIndex = 1;
        	this.flattenRadioButton.TabStop = true;
        	this.flattenRadioButton.Text = "&Flatten";
        	this.flattenRadioButton.UseVisualStyleBackColor = true;
        	this.flattenRadioButton.CheckedChanged += new System.EventHandler(this.OnRadioButtonCheckedChanged);
        	// 
        	// preserveRadioButton
        	// 
        	this.preserveRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
        	this.preserveRadioButton.ForeColor = System.Drawing.Color.Red;
        	this.preserveRadioButton.Location = new System.Drawing.Point(12, 19);
        	this.preserveRadioButton.Name = "preserveRadioButton";
        	this.preserveRadioButton.Size = new System.Drawing.Size(104, 24);
        	this.preserveRadioButton.TabIndex = 0;
        	this.preserveRadioButton.TabStop = true;
        	this.preserveRadioButton.Text = "&Preserve";
        	this.preserveRadioButton.UseVisualStyleBackColor = true;
        	this.preserveRadioButton.CheckedChanged += new System.EventHandler(this.OnRadioButtonCheckedChanged);
        	// 
        	// toolStripProgressBar1
        	// 
        	this.toolStripProgressBar1.Name = "toolStripProgressBar1";
        	this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 15);
        	// 
        	// folderBrowserDialog
        	// 
        	this.folderBrowserDialog.Description = "Please choose destination";
        	// 
        	// ConsolidateDirectoryForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(244, 299);
        	this.Controls.Add(this.tableLayoutPanel);
        	this.Controls.Add(this.mainMenuStrip);
        	this.Controls.Add(this.mainStatusStrip);
        	this.MaximizeBox = false;
        	this.MinimumSize = new System.Drawing.Size(260, 337);
        	this.Name = "ConsolidateDirectoryForm";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Consolidate Directory";
        	this.Shown += new System.EventHandler(this.OnConsolidateDirectoryFormShown);
        	this.mainMenuStrip.ResumeLayout(false);
        	this.mainMenuStrip.PerformLayout();
        	this.mainStatusStrip.ResumeLayout(false);
        	this.mainStatusStrip.PerformLayout();
        	this.tableLayoutPanel.ResumeLayout(false);
        	this.tableLayoutPanel.PerformLayout();
        	this.onFinishGroupBox.ResumeLayout(false);
        	this.modeGroupBox.ResumeLayout(false);
        	this.destionationGroupBox.ResumeLayout(false);
        	this.onFileExistsGroupBox.ResumeLayout(false);
        	this.subdirectoriesGroupBox.ResumeLayout(false);
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.RadioButton preserveRadioButton;
        private System.Windows.Forms.RadioButton flattenRadioButton;
        private System.Windows.Forms.GroupBox subdirectoriesGroupBox;
        private System.Windows.Forms.CheckBox overwriteCheckBox;
        private System.Windows.Forms.GroupBox onFileExistsGroupBox;
        private System.Windows.Forms.CheckBox zapSourceCheckBox;
        private System.Windows.Forms.GroupBox onFinishGroupBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.GroupBox destionationGroupBox;
        private System.Windows.Forms.GroupBox modeGroupBox;
        private System.Windows.Forms.RadioButton browseRadioButton;
        private System.Windows.Forms.RadioButton selectedRadioButton;
        private System.Windows.Forms.RadioButton copyFilesRadioButton;
        private System.Windows.Forms.RadioButton moveFilesRadioButton;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button consolidateDirectoryButton;
        private System.Windows.Forms.TextBox patternTextBox;
        private System.Windows.Forms.LinkLabel patternReferenceLinkLabel;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.ToolStripStatusLabel countToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel mainToolStripStatusLabel;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeGithubcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalThreadDonationCodercomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyReleasesPublicDomainDailycomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
    }
}

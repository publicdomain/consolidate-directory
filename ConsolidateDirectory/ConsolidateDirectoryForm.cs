// <copyright file="ConsolidateDirectoryForm.cs" company="PublicDomain.com">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>

namespace ConsolidateDirectory
{
    // Directives
    using System;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// Description of ConsolidateDirectoryForm.
    /// </summary>
    public partial class ConsolidateDirectoryForm : Form
    {
        /// <summary>
        /// The main form.
        /// </summary>
        private MainForm mainForm = new MainForm();

        /// <summary>
        /// The directory path.
        /// </summary>
        private string directoryPath;

        /// <summary>
        /// The directory file string array.
        /// </summary>
        private string[] directoryFileStringArray;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ConsolidateDirectory.ConsolidateDirectoryForm"/> class.
        /// </summary>
        /// <param name="directoryPath">Directory path.</param>
        public ConsolidateDirectoryForm(string directoryPath)
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();

            // Set icon
            this.Icon = this.mainForm.Icon;

            // Set directory path
            this.directoryPath = directoryPath;

            // Map event handlers to main form
            this.dailyReleasesPublicDomainDailycomToolStripMenuItem.Click += new System.EventHandler(this.mainForm.OnDailyReleasesPublicDomainDailycomToolStripMenuItemClick);
            this.originalThreadDonationCodercomToolStripMenuItem.Click += new System.EventHandler(this.mainForm.OnOriginalThreadDonationCodercomToolStripMenuItemClick);
            this.sourceCodeGithubcomToolStripMenuItem.Click += new System.EventHandler(this.mainForm.OnSourceCodeGithubcomToolStripMenuItemClick);
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.mainForm.OnAboutToolStripMenuItemClick);
        }

        /// <summary>
        /// Handles the consolidate directory button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnConsolidateDirectoryButtonClick(object sender, EventArgs e)
        {
            // Check there are files to cnsolidate
            if (this.directoryFileStringArray.Length == 0)
            {
                // No files, advise user
                MessageBox.Show("There are no files to consolidate!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Halt flow
                return;
            }

            // Set destination directory, using this.folderBrowserDialog.SelectedPath as working variable
            if (this.selectedRadioButton.Checked)
            {
                // Set selected path
                this.folderBrowserDialog.SelectedPath = this.directoryPath;
            }
            else
            {
                // Browse directory loop
                while (true)
                {
                    // Show folder browser dialog
                    if (this.folderBrowserDialog.ShowDialog() != DialogResult.OK)
                    {
                        // User cancelled dialog, ask to retry
                        if (MessageBox.Show($"Target directory was not set. Retry?{Environment.NewLine}{Environment.NewLine}No = halt consolidation process.", "Retry or Halt", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                        {
                            // Halt flow
                            return;
                        }
                    }
                    else
                    {
                        // Exit loop
                        break;
                    }
                }
            }

            /* TODO Consolidate directory [Can be optimized i.e. add true to File.Copy() selectively, etc.] */

            // Try to perform consolidate process
            try
            {
                // Verify target directory is there
                if (!Directory.Exists(this.folderBrowserDialog.SelectedPath))
                {
                    // Target doesn't exist, create it
                    Directory.CreateDirectory(this.folderBrowserDialog.SelectedPath);
                }

                // Iterate files
                foreach (string sourceFilePath in this.directoryFileStringArray)
                {
                    // Set source file directory
                    string sourceFileDirectory = Path.GetDirectoryName(sourceFilePath);

                    /* Target file path and directory */

                    // Declare target file path string
                    string targetFilePath;

                    // Check if must preserve subdirectory structure
                    if (this.preserveRadioButton.Checked)
                    {
                        // Replace source directory path with target
                        targetFilePath = Path.Combine(this.folderBrowserDialog.SelectedPath, sourceFilePath.Remove(0, this.directoryPath.Length));
                    }
                    else
                    {
                        // Set flattened target file path
                        targetFilePath = Path.Combine(this.folderBrowserDialog.SelectedPath, Path.GetFileName(sourceFilePath));
                    }

                    /* File processing */

                    // Check for existing file
                    if (File.Exists(targetFilePath))
                    {
                        // Check if must skip existing files
                        if (!this.overwriteCheckBox.Checked)
                        {
                            // Skip file
                            continue;
                        }

                        // TODO Overwrite == delete file first [Can be made differently i.e. refactor to use File.Copy() true flag on third parameter]
                        File.Delete(targetFilePath);
                    }

                    // Check if must move
                    if (this.moveFilesRadioButton.Checked)
                    {
                        // Move file
                        File.Move(sourceFilePath, targetFilePath);
                    }
                    else
                    {
                        // Copy file
                        File.Copy(sourceFilePath, targetFilePath);
                    }

                    // Check if the user wants to zap source (skipping consolidate directory path itself)
                    if (this.zapSourceCheckBox.Checked && (sourceFileDirectory != this.directoryPath))
                    {
                        // Delete source file
                        File.Delete(sourceFilePath);

                        // Check if source file's directory is empty
                        if (!Directory.EnumerateFileSystemEntries(sourceFileDirectory).Any())
                        {
                            // Delete it
                            Directory.Delete(sourceFileDirectory);
                        }
                    }
                }

                // The very last thing: check if all files are removed from consolidate directory path and the user wants to zap source to delete source dir
                if (this.zapSourceCheckBox.Checked && (this.folderBrowserDialog.SelectedPath != this.directoryPath) && !Directory.EnumerateFileSystemEntries(this.directoryPath).Any())
                {
                    // Delete it
                    Directory.Delete(this.directoryPath);
                }

                /* Process completed */

                // Success! Inform user
                MessageBox.Show($"Directory consolidation process completed successfully!{Environment.NewLine}{Environment.NewLine}Files: {this.directoryFileStringArray.Length}{Environment.NewLine}Source: {this.directoryPath}{Environment.NewLine}Destination: {this.folderBrowserDialog.SelectedPath}", "Consolidated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Update status
                this.countToolStripStatusLabel.Text = "Consolidated!";
            }
            catch (Exception ex)
            {
                // Advise user
                MessageBox.Show($"File processing error:{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the pattern reference link label link clicked event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnPatternReferenceLinkLabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Inform user
            MessageBox.Show($"* (asterisk) = zero or more characters.{Environment.NewLine}? (question mark) = one (1) of any character.{Environment.NewLine}{Environment.NewLine}All other valid characters are literal.{Environment.NewLine}{Environment.NewLine}? (question mark) note: It is officially documented as matching zero or one, yet in most platforms/implementations matches exactly one (1) character. Please check behavior when using.", "File pattern", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Handles the exit tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Close application
            this.Close();
        }

        /// <summary>
        /// Handles the consolidate directory form shown event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnConsolidateDirectoryFormShown(object sender, EventArgs e)
        {
            // Update file count while setting directory file string array
            this.SetDirectoryFileStringArrayAndUpdateFileCount();
        }

        /// <summary>
        /// Sets the directory file string array and update file count.
        /// </summary>
        private void SetDirectoryFileStringArrayAndUpdateFileCount()
        {
            // Set directory file string array
            this.directoryFileStringArray = Directory.GetFiles(this.directoryPath, this.patternTextBox.Text, SearchOption.AllDirectories);

            // Update file count
            this.countToolStripStatusLabel.Text = this.directoryFileStringArray.Count().ToString();
        }

        /// <summary>
        /// Handles the pattern text box text changed event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnPatternTextBoxTextChanged(object sender, EventArgs e)
        {
            // Update status label
            this.countToolStripStatusLabel.Text = "Calculating...";

            // Update file count while setting directory file string array
            this.SetDirectoryFileStringArrayAndUpdateFileCount();
        }

        /// <summary>
        /// Handles the check box checked changed.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the radio button checked changed.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            // TODO Add code
        }
    }
}

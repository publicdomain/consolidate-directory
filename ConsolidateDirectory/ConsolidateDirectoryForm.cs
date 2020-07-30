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
            // TODO Add code
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
        /// <param name="e">Event arguments.</param>C
        private void OnPatternTextBoxTextChanged(object sender, EventArgs e)
        {
            // Update status label
            this.countToolStripStatusLabel.Text = "Calculating...";

            // Update file count while setting directory file string array
            this.SetDirectoryFileStringArrayAndUpdateFileCount();
        }
    }
}

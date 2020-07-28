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
            // TODO Add code
        }

        /// <summary>
        /// Handles the pattern text box leave event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnPatternTextBoxLeave(object sender, EventArgs e)
        {
            // TODO Add code
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
            // TODO Add code
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
    }
}

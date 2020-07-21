// <copyright file="MainForm.cs" company="PublicDomain.com">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>

namespace ConsolidateDirectory
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using Microsoft.Win32;

    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// The name of the icon file.
        /// </summary>
        private string iconFileName = "cd-menu-icon.ico";

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ConsolidateDirectory.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();
        }

        /// <summary>
        /// Handles the add button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAddButtonClick(object sender, EventArgs e)
        {
            try
            {
                // Add consolidate command to registry
                RegistryKey registryKey;
                registryKey = Registry.CurrentUser.CreateSubKey(@"Software\Classes\directory\shell\Consolidate");
                registryKey.SetValue("icon", $"{Path.Combine(Application.StartupPath, this.iconFileName)}");
                registryKey.SetValue("position", "Top");
                registryKey = Registry.CurrentUser.CreateSubKey(@"Software\Classes\directory\shell\Consolidate\command");
                registryKey.SetValue(string.Empty, $"{Path.Combine(Application.StartupPath, Application.ExecutablePath)} \"%1\"");
                registryKey.Close();

                // Create icon if it does not exist
                if (!File.Exists(this.iconFileName))
                {
                    // Use file stream
                    using (FileStream fileStream = File.Create(this.iconFileName))
                    {
                        // Save main form icon to file
                        this.Icon.Save(fileStream);
                    }
                }

                // Update status
                this.activityToolStripStatusLabel.Text = "Active";

                // Notify user
                MessageBox.Show($"Consolidate command added to registry!{Environment.NewLine}{Environment.NewLine}Right-click directory on Windows Explorer to use.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Notify user
                MessageBox.Show($"Error when adding consolidate command to registry.{Environment.NewLine}{Environment.NewLine}Message:{Environment.NewLine}{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the remove button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnRemoveButtonClick(object sender, EventArgs e)
        {
            try
            {
                // Remove consolidate command to registry
                Registry.CurrentUser.DeleteSubKeyTree(@"Software\Classes\directory\shell\Consolidate");

                // Remove icon
                File.Delete(this.iconFileName);

                // Update status
                this.activityToolStripStatusLabel.Text = "Inactive";

                // Notify user
                MessageBox.Show("Consolidate command removed from registry!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Notify user
                MessageBox.Show($"Error when removing consolidate command from registry.{Environment.NewLine}{Environment.NewLine}Message:{Environment.NewLine}{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the exit tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the daily releases public domain dailycom tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnDailyReleasesPublicDomainDailycomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open current website
            Process.Start("https://publicdomaindaily.com");
        }

        /// <summary>
        /// Handles the original thread donation codercom tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOriginalThreadDonationCodercomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open original thread @ DonationCoder
            Process.Start("https://www.donationcoder.com/forum/index.php?topic=46630.0");
        }

        /// <summary>
        /// Handles the source code githubcom tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open GitHub
            Process.Start("https://github.com/publicdomain");
        }

        /// <summary>
        /// Handles the about tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }
    }
}

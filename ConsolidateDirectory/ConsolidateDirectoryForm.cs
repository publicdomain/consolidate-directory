// <copyright file="ConsolidateDirectoryForm.cs" company="PublicDomain.com">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>

namespace ConsolidateDirectory
{
    // Directives
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// Description of ConsolidateDirectoryForm.
    /// </summary>
    public partial class ConsolidateDirectoryForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:ConsolidateDirectory.ConsolidateDirectoryForm"/> class.
        /// </summary>
        /// <param name="directoryPath">Directory path.</param>
        public ConsolidateDirectoryForm(string directoryPath)
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();
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
    }
}

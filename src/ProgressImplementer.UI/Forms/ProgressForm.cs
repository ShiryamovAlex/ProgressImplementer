namespace ProgressImplementer.UI.Forms
{
    using System.Windows.Forms;

    /// <summary>
    /// Окно с прогрессом.
    /// </summary>
    public partial class ProgressForm : Form
    {
        /// <summary>
        /// Окно с прогрессом.
        /// </summary>
        public ProgressForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Отменить операцию.
        /// </summary>
        private void CancelOperation(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
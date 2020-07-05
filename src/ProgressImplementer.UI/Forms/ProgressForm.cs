namespace ProgressImplementer.UI.Forms
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Окно с прогрессом.
    /// </summary>
    public partial class ProgressForm : Form
    {
        private bool _inProgress;

        /// <summary>
        /// Окно с прогрессом.
        /// </summary>
        public ProgressForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Отменить операцию или закрыть окно.
        /// </summary>
        private void CancelOperation(object sender, EventArgs e)
        {
            if (_inProgress)
            {
                _inProgress = false;
                ChangeEnableState();
            }
            else
            {
                Close();
            }
        }

        /// <summary>
        /// Изменить доступность элементов окна.
        /// </summary>
        private void ChangeEnableState()
        {
            OkButton.Enabled = !_inProgress;
        }

        /// <summary>
        /// Запустить прогресс.
        /// </summary>
        private void StartProgress(object sender, EventArgs e)
        {
            _inProgress = true;
            ChangeEnableState();
            // TODO: запуск прогресса.
        }
    }
}
namespace ProgressImplementer.UI.ViewModels
{
    using ProgressImplementer.UI.Commands;
    using ProgressImplementer.UI.Interfaces;

    /// <summary>
    /// Вью-модель окна с прогрессом.
    /// </summary>
    public class ProgressWindowVM : BaseViewModel
    {
        /// <inheritdoc cref="InProgress"/>
        private bool _inProgress;

        /// <summary>
        /// Вью-модель окна с прогрессом.
        /// </summary>
        /// <param name="progressOperation">Операция с прогрессом.</param>
        public ProgressWindowVM(IProgressOperation progressOperation)
        {
            ProgressOperation = progressOperation;

            ProgressBarVM = new ProgressBarVM();
            AbortProgressOperation = new AbortProgressOperation();
            StartProgressCommand = new StartProgressCommand();
        }

        /// <summary>
        /// Команда прерывания операции.
        /// </summary>
        public AbortProgressOperation AbortProgressOperation { get; }

        /// <summary>
        /// Флаг, что окно находится в состоянии прогресса.
        /// </summary>
        public bool InProgress
        {
            get => _inProgress;
            set
            {
                _inProgress = value;
                OnPropertyChanged(nameof(IsEnabled));
            }
        }

        /// <summary> 
        /// Флаг доступности элементов окна.
        /// </summary>
        public bool IsEnabled => !InProgress;

        /// <summary>
        /// Вью-модель прогресса.
        /// </summary>
        public ProgressBarVM ProgressBarVM { get; set; }

        /// <summary>
        /// Операция с прогрессом.
        /// </summary>
        internal IProgressOperation ProgressOperation { get; }

        /// <summary>
        /// Команда запуска прогресса.
        /// </summary>
        public StartProgressCommand StartProgressCommand { get; }
    }
}
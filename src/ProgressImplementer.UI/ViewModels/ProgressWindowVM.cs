namespace ProgressImplementer.UI.ViewModels
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    using ProgressImplementer.UI.Commands;
    using ProgressImplementer.UI.Interfaces;

    /// <summary>
    /// Вью-модель окна с прогрессом.
    /// </summary>
    public class ProgressWindowVM : INotifyPropertyChanged
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

            ProgressBarVM = new ProgressBarVM(1000);
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

        /// <inheritdoc cref="INotifyPropertyChanged.PropertyChanged"/>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Оповестить об изменении свойства.
        /// </summary>
        /// <param name="propertyName">Имя свойства</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
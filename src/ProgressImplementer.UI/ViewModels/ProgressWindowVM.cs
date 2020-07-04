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
        /// <inheritdoc cref="IsEnabled"/>
        private bool _isEnabled;

        /// <summary>
        /// Вью-модель окна с прогрессом.
        /// </summary>
        /// <param name="progressOperation">Операция с прогрессом.</param>
        public ProgressWindowVM(IProgressOperation progressOperation)
        {
            _isEnabled = true;
            ProgressOperation = progressOperation;

            ProgressBarVM = new ProgressBarVM(1000);
            StartProgressCommand = new StartProgressCommand();
        }

        /// <summary> 
        /// Флаг доступности элементов окна.
        /// </summary>
        public bool IsEnabled
        {
            get => _isEnabled;
            set
            {
                _isEnabled = value;
                OnPropertyChanged();
            }
        }

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
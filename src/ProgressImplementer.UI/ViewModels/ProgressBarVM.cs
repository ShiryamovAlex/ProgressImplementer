namespace ProgressImplementer.UI.ViewModels
{
    using System;
    using System.Windows;

    using ProgressImplementer.UI.Enums;

    /// <summary>
    /// Вью-модель прогресса.
    /// </summary>
    public class ProgressBarVM : BaseViewModel
    {
        /// <inheritdoc cref="CurrentValue"/>
        private int _currentValue;

        /// <inheritdoc cref="IsAborted"/>
        private bool _isAborted;

        /// <inheritdoc cref="ProgressTextMode"/>
        private ProgressTextMode _progressTextMode;

        /// <inheritdoc cref="Text"/>
        private string _text;

        /// <summary>
        /// Вью-модель прогресса.
        /// </summary>
        /// <param name="maxValue">Максимальное значение.</param>
        public ProgressBarVM(int maxValue)
        {
            MaxValue = maxValue;
        }

        /// <summary>
        /// Текущее значение.
        /// </summary>
        public int CurrentValue
        {
            get => _currentValue;
            set
            {
                _currentValue = value;
                OnPropertyChanged();
                Text = GetProgressText();
            }
        }

        /// <summary>
        /// Флаг, что операция приостановлена.
        /// </summary>
        public bool InPause { get; private set; }

        /// <summary>
        /// Флаг, что операция отменена пользователем.
        /// </summary>
        public bool IsAborted
        {
            get => _isAborted;
            set
            {
                _isAborted = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Максимальное значение прогресса.
        /// </summary>
        public int MaxValue { get; }

        /// <summary>
        /// Режим вывода текста.
        /// </summary>
        public ProgressTextMode ProgressTextMode
        {
            get => _progressTextMode;
            set
            {
                _progressTextMode = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Текст прогресса.
        /// </summary>
        public string Text
        {
            get => _text;
            set
            {
                _text = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Отменить прогресс.
        /// </summary>
        public void Abort()
        {
            InPause = true;
            var needToAbort = MessageBox.Show("Вы действительно хотите прерывать операцию?", "Прерывание операции",
                                  MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes;

            InPause = false;

            if (!needToAbort)
                return;

            IsAborted = true;
            Text = "Прерывание операции";
        }

        /// <summary>
        /// Обнулить значения прогресса.
        /// </summary>
        public void Reset()
        {
            CurrentValue = 0;
            Text = null;
            IsAborted = false;
        }

        /// <summary>
        /// Получить значение текста прогресса.
        /// </summary>
        /// <returns>Текст прогресса в зависимости от режима вывода.</returns>
        private string GetProgressText()
        {
            switch (ProgressTextMode)
            {
                case ProgressTextMode.None:
                    return null;

                case ProgressTextMode.Percent:
                    return _currentValue == 0 ? string.Empty : $"{(int)((double)_currentValue / MaxValue * 100)}%";

                case ProgressTextMode.Proportion:
                    return _currentValue == 0 ? string.Empty : $"{_currentValue}/{MaxValue}";

                default:
                    throw new NotImplementedException($"Передан неопределённый тип перечисления {ProgressTextMode}");
            }
        }
    }
}
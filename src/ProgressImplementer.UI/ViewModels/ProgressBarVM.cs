﻿namespace ProgressImplementer.UI.ViewModels
{
    using System;

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
                UpdateText();
            }
        }

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
        public ProgressTextMode ProgressTextMode { get; set; }

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
        /// Обнулить значения прогресса.
        /// </summary>
        public void Reset()
        {
            CurrentValue = 0;
            Text = string.Empty;
            IsAborted = false;
        }

        /// <summary>
        /// Обновить текст прогресса.
        /// </summary>
        private void UpdateText()
        {
            switch (ProgressTextMode)
            {
                case ProgressTextMode.Percent:
                    Text = _currentValue == 0 ? string.Empty : $"{(int)((double)_currentValue / MaxValue * 100)}%";
                    return;

                case ProgressTextMode.Proportion:
                    Text = _currentValue == 0 ? string.Empty : $"{_currentValue}/{MaxValue}";
                    return;

                default:
                    throw new NotImplementedException($"Передан неопределённый тип перечисления {ProgressTextMode}");
            }
        }
    }
}
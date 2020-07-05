namespace ProgressImplementer.UI.Converters
{
    using System;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Data;

    /// <summary>
    /// Конвертер для привязки значений enum к RadioButton.
    /// </summary>
    public class EnumBooleanConverter : IValueConverter
    {
        /// <summary>
        /// Проверяет, совпадают ли выбранное значение value и переданное значение в параметре.
        /// Используется для привязки к свойству IsEnabled (IsChecked) у RadioButton.
        /// </summary>
        /// <param name="value">Текущее значение перечисления.</param>
        /// <param name="targetType">Тип перечисления.</param>
        /// <param name="parameter">Строковое значение enum, соответствующее текущему контролу.</param>
        /// <param name="culture">Культура (не используется).</param>
        /// <returns>True если параметр совпадает со значением value. Иначе - false.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return DependencyProperty.UnsetValue;

            if (parameter is Enum enumParameter)
                return enumParameter.Equals(value);

            if (!(parameter is string stringParameter))
                return DependencyProperty.UnsetValue;

            var enumType = value.GetType();
            if (Enum.IsDefined(enumType, value) == false)
                return DependencyProperty.UnsetValue;

            var parameterValue = Enum.Parse(enumType, stringParameter);
            return parameterValue.Equals(value);
        }

        /// <summary>
        /// Преобразует строковый параметр в значение enum заданного типа.
        /// Используется для установки свойства типа enum, привязанного к данному RadioButton.
        /// </summary>
        /// <param name="value">Значение контрола.</param>
        /// <param name="targetType">Тип перечисления.</param>
        /// <param name="parameter">Строковое значение.</param>
        /// <param name="culture">Культура, не используется.</param>
        /// <returns>Значение перечисления заданного типа.</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool?)value == false)
                return Binding.DoNothing;

            if (parameter is Enum enumParameter)
                return enumParameter;

            return parameter is string stringParameter
                ? Enum.Parse(targetType, stringParameter)
                : DependencyProperty.UnsetValue;
        }
    }
}
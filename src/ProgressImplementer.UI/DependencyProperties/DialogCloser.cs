namespace ProgressImplementer.UI.DependencyProperties
{
    using System.Windows;

    /// <summary>
    /// Свойство зависимости для связи свойства DialogResult окна и вью-модели.
    /// </summary>
    public static class DialogCloser
    {
        /// <summary>
        /// Свойство зависимости DialogResult.
        /// </summary>
        public static readonly DependencyProperty DialogResultProperty = DependencyProperty.RegisterAttached(
            "DialogResult",
            typeof(bool?),
            typeof(DialogCloser),
            new PropertyMetadata(DialogResultChanged));

        /// <summary>
        /// Задать DialogResult.
        /// </summary>
        public static void SetDialogResult(Window target, bool? value)
        {
            target.SetValue(DialogResultProperty, value);
        }

        /// <summary>
        /// Обработчик изменения DialogResult.
        /// </summary>
        private static void DialogResultChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            if (dependencyObject is Window window)
                window.DialogResult = e.NewValue as bool?;
        }
    }
}
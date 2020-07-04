namespace ProgressImplementer.UI.Interfaces
{
    using ProgressImplementer.UI.ViewModels;

    /// <summary>
    /// Интерфейс операции с прогрессом.
    /// </summary>
    public interface IProgressOperation
    {
        /// <summary>
        /// Выполнить операцию.
        /// </summary>
        /// <param name="progressBarVM">Вью-модель прогресса.</param>
        void Execute(ProgressBarVM progressBarVM);
    }
}
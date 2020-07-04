namespace ProgressImplementer.BL
{
    using System.Threading;

    /// <summary>
    /// Модель ожидания времени.
    /// </summary>
    /// <remarks>Это мог быть любой другой класс, выполняющий затратную операцию.</remarks>
    public class TimeWaiting
    {
        /// <summary>
        /// Время ожидания в мс.
        /// </summary>
        private readonly int _milliseconds;

        /// <summary>
        /// Модель ожидания времени.
        /// </summary>
        /// <param name="milliseconds">Время ожидания в мс.</param>
        public TimeWaiting(int milliseconds)
        {
            _milliseconds = milliseconds;
        }

        /// <summary>
        /// Выполнить ожидание.
        /// </summary>
        public void Wait()
        {
            Thread.Sleep(_milliseconds);
        }
    }
}
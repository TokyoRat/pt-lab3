using System;

namespace Lalalend_3.core.commands
{
    /// <summary>
    /// Команда отображения статистики.
    /// </summary>
    internal abstract class AbstractChartCommand
    {
        /// <summary>
        /// Текущие данные статистики.
        /// </summary>
        readonly string data;

        /// <param name="data">Текст статистики.</param>
        public AbstractChartCommand(String data)
        {
            this.data = data;
        }

        /// <summary>
        /// Выполнить команду.
        /// </summary>
        /// <param name="presenter">Презентер, отвечающий за отображение на экране.</param>
        public abstract void Run(IChartPresenter presenter);
    }
}

using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lalalend_3.core
{
    public interface IChartPresenter
    {
        /// <summary>
        /// Выводит на экран график [series]
        /// </summary>
        void ShowChart(Series series);
        /// <summary>
        /// Выводит на экран сообщение [info]
        /// </summary>
        void ShowAdditionalInfo(string info);
        /// <summary>
        /// Выводит на экран таблицу.
        /// </summary>
        /// <param name="columnsName">Названия столбцов</param>
        /// <param name="rows">Данные таблицы</param>
        void ShowGrid(List<string> columnsName, List<List<string>> rows);
    }
}

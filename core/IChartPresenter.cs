using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lalalend_3.core
{
    public interface IChartPresenter
    {
        void ShowChart(Series series);
        void ShowAdditionalInfo(string info);
        void ShowGrid(List<string> columnsName, List<List<string>> rows);
    }
}

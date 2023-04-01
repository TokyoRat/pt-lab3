using Lalalend_3.src.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lalalend_3.core
{
    internal class ChartPresenter : IChartPresenter
    {
        IChartView view;
        public IChartView View { set
            {
                view.RequestedStatistics -= RunCommand;
                view = value;
                view.RequestedStatistics += RunCommand;
            }
        }

        public void ShowAdditionalInfo(string info)
        {
            view.ShowAdditionalInfo(info);
        }

        public void ShowChart(List<Series> series)
        {
            view.ShowChart(series);
        }

        public void ShowGrid(List<string> columnsName, List<List<string>> rows)
        {
            view.ShowGrid(columnsName, rows);
        }

        private void RunCommand()
        {

        }
    }
}

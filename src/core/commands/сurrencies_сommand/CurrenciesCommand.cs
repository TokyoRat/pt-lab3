using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lalalend_3.core.commands
{
    internal class CurrenciesCommand : IChartCommand
    {
        public List<List<string>> data;
        public CurrenciesCommand(List<List<string>> data)
        {
            this.data = data;
        }

        public void Run(IChartPresenter presenter)
        {
            presenter.ShowGrid(new List<string>() { "Дата", "Курс к доллару", "Курс к евро" }, data);
        }
    }
}

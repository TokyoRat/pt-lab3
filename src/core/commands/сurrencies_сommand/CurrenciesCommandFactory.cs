using Lalalend_3.core.commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lalalend_3.src.core.commands.сurrencies_сommand
{
    internal class CurrenciesCommandFactory : AbstractCommandFactory
    {
        public override IChartCommand CreateFromCSV(string csv)
        {
            List<List<string>> list = (List<List<string>>)csv.Split('\n').Select((e) => e.Split(';'));

            return new CurrenciesCommand(list);
        }
    }
}

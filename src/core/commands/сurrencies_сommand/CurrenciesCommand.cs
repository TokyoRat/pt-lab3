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
            string[] dollarMax = { "0", "0", "0" };
            string[] euroMax = { "0", "0", "0" }; ;
            float difference;
            for (int i = 1; i < data.Count; i++)
            {
                difference = float.Parse(data[i][1]) - float.Parse(data[i - 1][1]);
                if (difference > float.Parse(dollarMax[2]))
                {
                    dollarMax[0] = data[i][0];
                    dollarMax[1] = data[i][1];
                    dollarMax[2] = difference.ToString();
                }
                difference = float.Parse(data[i][2]) - float.Parse(data[i - 1][2]);
                if (difference > float.Parse(euroMax[2]))
                {
                    euroMax[0] = data[i][0];
                    euroMax[1] = data[i][2];
                    euroMax[2] = difference.ToString();
                }
            }
            presenter.ShowAdditionalInfo($"Наибольший рост доллара (+{dollarMax[2]}) произошел {dollarMax[0]}\nНаибольший рост евро (+{euroMax[2]}) произошел {euroMax[0]}");
        }
    }
}

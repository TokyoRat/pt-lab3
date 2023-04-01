using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lalalend_3.core.commands
{
    internal abstract class AbstractChartCommand
    {
        readonly string filePath;

        public AbstractChartCommand(String path)
        {
            filePath = path;
        }

        public abstract void Run(IChartPresenter presenter);
    }
}

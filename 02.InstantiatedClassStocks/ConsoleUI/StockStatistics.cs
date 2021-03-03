using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocks
{
    public class StockStatistics
    {
        public StockStatistics()
        {
            HighestStock = 0;
            LowestStock = float.MaxValue;
        }

        public float AverageStock;
        public float HighestStock;
        public float LowestStock;
    }
}

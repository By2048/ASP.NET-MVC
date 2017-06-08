using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSLS.Domain.Model
{
    public class FineStatistics
    {
        public List<decimal> FineMoney { get; set; }
        public List<int> PeopelFineCount { get; set; }
        public List<int> OverTime { get; set; }
        public decimal TotalMoney { get; set; }
        public double IsPay { get; set; }
    }
}

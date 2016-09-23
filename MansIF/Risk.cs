using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MansIF
{
    public class Risk
    {
        public int RiskId { get; set; }

        public string RiskName { get; set; }

        public DateTime RiskValidFrom { get; set; }

        public DateTime RiskValidTill { get; set; }

        public decimal RiskCoef { get; set; }

        public Cover Cover { get; set; }

    }
}
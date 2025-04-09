using System;
using System.Collections.Generic;
using System.Text;

namespace BestHB.Domain.Entities
{
    public class InstrumentInfo
    {
        public string ISIN { get; set; }
        public string Symbol { get; set; }
        public string Description { get; set; }
        public string Exchange { get; set; }
        public decimal MinLot { get; set; }
        public decimal MaxLot { get; set; }
        public decimal LotStep { get; set; }
        public InstrumentType Type { get; set; }
    }

    public enum InstrumentType //TODO: retirar o 0 do stock
    {
        Stock = 0,
        Future,
        Options,
        Forward
    }

}

using System;

namespace Altria.DVP.AOC.Models.Offers
{
    public class Details
    {
        public DateTime EffectiveDate { get; set; }
        public DateTime TerminationDate { get; set; }
        public int Quantity { get; set; }
        public string CurrencySymbol { get; set; }
        public string CurrencySymbolPlacement { get; set; }
        public string ItemValue { get; set; }
        public string ItemValueText { get; set; }
        public string ItemProgramId { get; set; }
        public int ItemConsumerLimit { get; set; }
        public bool ItemInventoryAvailable { get; set; }
        public string statusCode { get; set; }
        public string statusMessage { get; set; }
    }
}
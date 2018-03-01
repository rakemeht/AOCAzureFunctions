using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altria.DVP.AOC.Models.Offers
{
    public class Offers
    {
        public string id { get; set; }
        public string offerType { get; set; }
        public string quantity { get; set; }
        public string text { get; set; }
        public string discountCode { get; set; }
        public decimal itemValue { get; set; }
        public string currencySymbol { get; set; }
        public string currencySymbolPlacement { get; set; }
        public string itemValueText { get; set; }
        public string appliesTo { get; set; }
        public bool isDigital { get; set; }
        public int pointsCost { get; set; }
        public bool physicalDeliveryOption { get; set; }
        public string offerStatusCode { get; set; }
        public string offerStatusMessage { get; set; }
    }

    public class ItemProgramDetails
    {
        public string quantity { get; set; }
        public double itemValue { get; set; }
        public string currencySymbol { get; set; }
        public string currencySymbolPlacement { get; set; }
        public string itemValueText { get; set; }
        public string appliesTo { get; set; }
        public bool isDigital { get; set; }
        public int pointsCost { get; set; }
        public bool physicalDeliveryOption { get; set; }
    }
}

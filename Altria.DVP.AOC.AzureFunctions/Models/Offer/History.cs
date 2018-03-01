using System;

namespace Altria.DVP.AOC.Models.Offers
{
    public class History
    {
        public string posNumber { get; set; }
        public string itemProgramId { get; set; }
        public DateTime LastRedemptiondate { get; set; }
        public int RedeemedQty { get; set; }
    }
}
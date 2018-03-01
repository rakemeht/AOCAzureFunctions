using System.Collections.Generic;

namespace Altria.DVP.AOC.Models.Offers
{
    public class Item
    {
        public Details details { get; set; }
        public List<History> history { get; set; }
    }
}
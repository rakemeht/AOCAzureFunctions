using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altria.DVP.AOC.Models.Offers
{
    public class OfferResponse
    {
        public Status status { get; set; }
        public string ccn { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string clientCode { get; set; }
        public string offerType { get; set; }
        public List<Offers> offers { get; set; }
    }
}

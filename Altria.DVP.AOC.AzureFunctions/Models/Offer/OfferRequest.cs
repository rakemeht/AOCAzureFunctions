using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Altria.DVP.AOC.Models.Offers
{
    public class OfferRequest
    {
        public string CCN { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string ClientCode { get; set; }
        public string OfferType { get; set; }
        public string ServerDate { get; set; }
        public string ServerTime { get; set; }
        public long UTCOffsetInSecs { get; set; }
        public string Channel { get; set; }
        public string FlavorFranchise { get; set; }
        public List<ProgramMaster> program { get; set; }
    }

}

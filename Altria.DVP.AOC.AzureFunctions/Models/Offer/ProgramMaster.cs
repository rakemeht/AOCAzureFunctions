using System;
using System.Collections.Generic;

namespace Altria.DVP.AOC.Models.Offers
{
    public class ProgramMaster
    {
        public string ProgramCode { get; set; }
        public DateTime ProgramStartDate { get; set; }
        public DateTime ProgramEndDate { get; set; }
        public int ProgramConsumerLimit { get; set; }
        public List<Item> Item { get; set; }
    }
}
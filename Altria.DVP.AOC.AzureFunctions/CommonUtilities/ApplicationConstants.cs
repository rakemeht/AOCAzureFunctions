namespace CommonUtilities
{
    public static class ApplicationConstants
    {
        public static readonly string SegmentationElementChannel = "consumerChannel";
        public static readonly string SegmentationElementSDate = "ServerDate";
        public static readonly string SegmentationElementStime = "ServerTime";
        public static readonly string SegmentationElementFlavor = "flavorFranchise";
        public static readonly string CampaignId = "667";
        public static readonly string ClientId = "667";
        public static readonly string RequestType = "MULTI";
        public static readonly string success = "000";
        public static readonly string Code000 = "Success";
        public static readonly string Code1000 = "Input parameters validation failed";
        public static readonly string Code1001 = "Invalid Client code or Client code not found";
        public static readonly string Code1002 = "Invalid Offer/Program type or Offer/Program type not found";
        public static readonly string Code1003 = "No Order history found for given Limit days/Limit count";
        public static readonly string Code1004 = "No Offer(s) found for given offer type";
        public static readonly string Code1005 = "Unable to connect to database(SQL/Redis) OR Redis Key not Found";
        public static readonly string Code9999 = "Something went wrong with API.Please try again later OR make sure that valid request is sent to API";
        public static readonly string Code9998 = "Something went wrong when Parsing PFS response.Please try again later";
        public static readonly string Code125 = "ATC does not currently have an active subscription";
        public static readonly string Code126 = "No Offer(s) can be redeemed within the blackout window";
        public static readonly string Code051 = "ATC has reached one or more limits related to this offer";
        public static readonly string Code052 = "ATC’s residence address restricts the availability of this offer";
        public static readonly string Code063 = "";
        public static readonly string Code066 = "";
        public static readonly string Code113 = "Offer already redeemed or is not on file";
        public static readonly string Code114 = "Offer not available for Nebraska State";
    }
}
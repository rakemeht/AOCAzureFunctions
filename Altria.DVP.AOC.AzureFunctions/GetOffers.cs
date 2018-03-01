using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Altria.DVP.AOC.Models.Offers;
using CommonUtilities;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace Altria.DVP.AOC.AzureFunctions
{
    public static class GetOffers
    {
        [FunctionName("GetOffers")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            OfferRequest offerRequest = null;
            offerRequest = await req.Content.ReadAsAsync<OfferRequest>();
            bool IsRedemptionError = false;
            // parse query parameter
            foreach (var Program in offerRequest.program)
            {
                IsRedemptionError = false;
                foreach (var item in Program.Item)
                {
                    if (item.history != null)
                    {
                        foreach (var history in item.history)
                        {
                            if ((DateTime.UtcNow - history.LastRedemptiondate).TotalDays < 30)
                            {
                                IsRedemptionError = true;
                                break;
                            }

                        }
                    }
                    if (IsRedemptionError)
                    {
                        break;
                    }
                }
                if (IsRedemptionError)
                {
                    foreach (var item in Program.Item)
                    {
                        item.details.statusCode = "113";
                        item.details.statusMessage = ApplicationConstants.Code113;
                    }
                }
            }

            if (offerRequest.State == "NE")
            {

                foreach (var Program in offerRequest.program)
                {
                    foreach (var item in Program.Item)
                    {
                        item.details.statusCode = "052";
                        item.details.statusMessage = ApplicationConstants.Code052;
                    }

                }
            }
            return req.CreateResponse(HttpStatusCode.OK, offerRequest);
        }
    }
}


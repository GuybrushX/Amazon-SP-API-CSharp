﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace FikaAmazonAPI.NotificationMessages
{
    /// <summary>
    /// An explanation about the purpose of this instance.
    /// </summary>
    public abstract class SummaryBase
    {
        /// <summary>
        /// Required. A list that contains the total number of offers for the item for the given conditions and fulfillment channels.
        /// </summary>
        [JsonProperty("NumberOfOffers")]
        public List<OfferCountElement> NumberOfOffers { get; set; }

        /// <summary>
        /// Required. A list that contains the lowest prices of the item for the given conditions and fulfillment channels.
        /// </summary>
        [JsonProperty("LowestPrices")]
        public List<LowestPrice> LowestPrices { get; set; }

        /// <summary>
        /// Optional. A list that contains the Buy Box price of the item for the given conditions.
        /// </summary>
        [JsonProperty("BuyBoxPrices")]
        public List<BuyBoxPrice> BuyBoxPrices { get; set; }
    }
}

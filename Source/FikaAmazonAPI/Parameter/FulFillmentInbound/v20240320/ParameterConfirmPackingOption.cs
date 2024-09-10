﻿using FikaAmazonAPI.Search;

namespace FikaAmazonAPI.Parameter.FulFillmentInbound.v20240320
{
    public class ParameterConfirmPackingOption : ParameterBased 
    {
        public string InboundPlanId { get; set; }
        public string PackingOptionId { get; set; }
    }
}

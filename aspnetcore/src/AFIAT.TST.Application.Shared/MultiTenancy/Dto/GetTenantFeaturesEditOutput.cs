using System.Collections.Generic;
using Abp.Application.Services.Dto;
using AFIAT.TST.Editions.Dto;

namespace AFIAT.TST.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}
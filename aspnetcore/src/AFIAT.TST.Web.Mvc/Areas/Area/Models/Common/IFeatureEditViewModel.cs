using System.Collections.Generic;
using Abp.Application.Services.Dto;
using AFIAT.TST.Editions.Dto;

namespace AFIAT.TST.Web.Areas.Area.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}
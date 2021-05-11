using Abp.AutoMapper;
using AFIAT.TST.Sessions.Dto;

namespace AFIAT.TST.Models.Common
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput)),
     AutoMapTo(typeof(GetCurrentLoginInformationsOutput))]
    public class CurrentLoginInformationPersistanceModel
    {
        public UserLoginInfoPersistanceModel User { get; set; }

        public TenantLoginInfoPersistanceModel Tenant { get; set; }

        public ApplicationInfoPersistanceModel Application { get; set; }
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using AFIAT.TST.Dto;

namespace AFIAT.TST.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}

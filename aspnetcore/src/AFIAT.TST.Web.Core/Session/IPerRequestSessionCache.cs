using System.Threading.Tasks;
using AFIAT.TST.Sessions.Dto;

namespace AFIAT.TST.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}

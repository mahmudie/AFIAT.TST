using System.Threading.Tasks;

namespace AFIAT.TST.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}
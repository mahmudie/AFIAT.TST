using System.Threading.Tasks;

namespace AFIAT.TST.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}
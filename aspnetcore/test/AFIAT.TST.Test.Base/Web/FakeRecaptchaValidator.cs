using System.Threading.Tasks;
using AFIAT.TST.Security.Recaptcha;

namespace AFIAT.TST.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}

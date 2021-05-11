using System.Threading.Tasks;
using AFIAT.TST.Views;
using Xamarin.Forms;

namespace AFIAT.TST.Services.Modal
{
    public interface IModalService
    {
        Task ShowModalAsync(Page page);

        Task ShowModalAsync<TView>(object navigationParameter) where TView : IXamarinView;

        Task<Page> CloseModalAsync();
    }
}

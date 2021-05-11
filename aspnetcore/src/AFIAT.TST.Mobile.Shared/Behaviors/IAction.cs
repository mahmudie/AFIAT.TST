using Xamarin.Forms.Internals;

namespace AFIAT.TST.Behaviors
{
    [Preserve(AllMembers = true)]
    public interface IAction
    {
        bool Execute(object sender, object parameter);
    }
}
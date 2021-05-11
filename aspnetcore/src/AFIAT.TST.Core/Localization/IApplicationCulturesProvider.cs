using System.Globalization;

namespace AFIAT.TST.Localization
{
    public interface IApplicationCulturesProvider
    {
        CultureInfo[] GetAllCultures();
    }
}
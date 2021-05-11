namespace AFIAT.TST.Configuration
{
    public interface IAppConfigurationWriter
    {
        void Write(string key, string value);
    }
}

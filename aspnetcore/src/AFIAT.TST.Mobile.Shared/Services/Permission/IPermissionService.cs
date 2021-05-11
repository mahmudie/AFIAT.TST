namespace AFIAT.TST.Services.Permission
{
    public interface IPermissionService
    {
        bool HasPermission(string key);
    }
}
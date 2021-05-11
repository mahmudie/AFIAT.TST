using System.Collections.Generic;
using AFIAT.TST.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace AFIAT.TST.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}

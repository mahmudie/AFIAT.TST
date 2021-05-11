using System.Collections.Generic;
using AFIAT.TST.Authorization.Users.Dto;
using AFIAT.TST.Dto;

namespace AFIAT.TST.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}
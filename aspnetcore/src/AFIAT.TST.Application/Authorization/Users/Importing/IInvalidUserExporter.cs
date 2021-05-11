using System.Collections.Generic;
using AFIAT.TST.Authorization.Users.Importing.Dto;
using AFIAT.TST.Dto;

namespace AFIAT.TST.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}

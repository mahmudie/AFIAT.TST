using System.Collections.Generic;
using Abp;
using AFIAT.TST.Chat.Dto;
using AFIAT.TST.Dto;

namespace AFIAT.TST.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}

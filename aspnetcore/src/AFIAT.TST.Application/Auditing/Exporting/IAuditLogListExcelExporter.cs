using System.Collections.Generic;
using AFIAT.TST.Auditing.Dto;
using AFIAT.TST.Dto;

namespace AFIAT.TST.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}

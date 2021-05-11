using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using AFIAT.TST.MultiTenancy.Accounting.Dto;

namespace AFIAT.TST.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}

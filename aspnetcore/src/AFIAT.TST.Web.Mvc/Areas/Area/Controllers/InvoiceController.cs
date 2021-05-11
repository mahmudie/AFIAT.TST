using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc;
using AFIAT.TST.MultiTenancy.Accounting;
using AFIAT.TST.Web.Areas.Area.Models.Accounting;
using AFIAT.TST.Web.Controllers;

namespace AFIAT.TST.Web.Areas.Area.Controllers
{
    [Area("Area")]
    public class InvoiceController : TSTControllerBase
    {
        private readonly IInvoiceAppService _invoiceAppService;

        public InvoiceController(IInvoiceAppService invoiceAppService)
        {
            _invoiceAppService = invoiceAppService;
        }


        [HttpGet]
        public async Task<ActionResult> Index(long paymentId)
        {
            var invoice = await _invoiceAppService.GetInvoiceInfo(new EntityDto<long>(paymentId));
            var model = new InvoiceViewModel
            {
                Invoice = invoice
            };

            return View(model);
        }
    }
}
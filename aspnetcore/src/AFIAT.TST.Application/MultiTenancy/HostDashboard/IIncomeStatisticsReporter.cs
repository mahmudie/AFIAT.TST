using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AFIAT.TST.MultiTenancy.HostDashboard.Dto;

namespace AFIAT.TST.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}
using Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _OnlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _OnlinePaymentService = onlinePaymentService;
        }
        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _OnlinePaymentService.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _OnlinePaymentService.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}

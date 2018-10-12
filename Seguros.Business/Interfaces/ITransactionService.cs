using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seguros.Common.Contracts;

namespace Seguros.Business.Interfaces
{
    public interface ITransactionService
    {
        Task<bool> CreateTransactionToInsurancePolicyAsync(InsurancePolicyContract data);
    }
}

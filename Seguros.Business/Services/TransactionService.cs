using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Seguros.Business.Interfaces;
using Seguros.Common.Contracts;
using Seguros.Data.Entities;
using Seguros.Data.Interfaces;

namespace Seguros.Business.Services
{
    public class TransactionService: ITransactionService
    {
        private IInsurancePolicyRepository _insurancePolicyRepository;
        private IMapper _mapper;

        public TransactionService(IInsurancePolicyRepository insurancePolicyRepository, IMapper mapper)
        {
            _mapper = mapper;
            _insurancePolicyRepository = insurancePolicyRepository;
        }

        public  Task<bool> CreateTransactionToInsurancePolicyAsync(InsurancePolicyContract data)
        {
            
            throw new NotImplementedException();
        }
    }
}

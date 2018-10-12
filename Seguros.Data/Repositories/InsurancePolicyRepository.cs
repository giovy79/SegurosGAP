using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seguros.Settings.Classes.Bases.Repository;
using Seguros.Data.Interfaces;
using Seguros.Data.Entities;
using Seguros.Data.Context;
using System.Data.Entity;

namespace Seguros.Data.Repositories
{
    public class InsurancePolicyRepository : BaseCRUDRepository<InsurancePolicy>
    {
        public InsurancePolicyRepository(DataBaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}

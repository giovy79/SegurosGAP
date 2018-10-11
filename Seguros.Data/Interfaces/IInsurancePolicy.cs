using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seguros.Settings.Classes.Bases.Repository.Interfaces;
using Seguros.Data.Entities;

namespace Seguros.Data.Interfaces
{
    public interface IInsurancePolicy : IBaseCRUDRepository<InsurancePolicy>
    {

    }
}

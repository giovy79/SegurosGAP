using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.Common.Contracts
{
    [DataContract]
    public class InsurancePolicyContract
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public DateTime BeginDate { get; set; }

        [DataMember]
        public int Range { get; set; }

        [DataMember]
        public Decimal Price { get; set; }

        [DataMember]
        public int Risk { get; set; }

        [DataMember]
        public int Coverage { get; set; }

        [DataMember]
        public int Percentage { get; set; }
    }
}

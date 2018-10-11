namespace Seguros.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InsurancePolicy")]
    public partial class InsurancePolicy
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        public DateTime BeginDate { get; set; }

        public int Range { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public int Risk { get; set; }

        public int Coverage { get; set; }

        public int Percentage { get; set; }

        public virtual RiskCoverage RiskCoverage { get; set; }

        public virtual RiskType RiskType { get; set; }
    }
}

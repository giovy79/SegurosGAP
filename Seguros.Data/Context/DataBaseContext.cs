namespace Seguros.Data.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Seguros.Data.Entities;

    public class DataBaseContext : DbContext
    {
        public DataBaseContext()
            : base("name=DataBaseContext")
        {
        }

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<InsurancePolicy> InsurancePolicy { get; set; }
        public virtual DbSet<InsurancePolicyByClient> InsurancePolicyByClient { get; set; }
        public virtual DbSet<RiskCoverage> RiskCoverage { get; set; }
        public virtual DbSet<RiskType> RiskType { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasMany(e => e.InsurancePolicyByClient)
                .WithRequired(e => e.Client)
                .HasForeignKey(e => e.IdClient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InsurancePolicy>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<RiskCoverage>()
                .HasMany(e => e.InsurancePolicy)
                .WithRequired(e => e.RiskCoverage)
                .HasForeignKey(e => e.Coverage)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RiskType>()
                .HasMany(e => e.InsurancePolicy)
                .WithRequired(e => e.RiskType)
                .HasForeignKey(e => e.Risk)
                .WillCascadeOnDelete(false);
        }
    }
}

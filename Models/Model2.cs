using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ApiMVC.Models
{
    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<TBLOGRENCI> TBLOGRENCI { get; set; }
        public virtual DbSet<TBLOGRETMEN> TBLOGRETMEN { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TBLOGRENCI>()
                .Property(e => e.KULLANICIAD)
                .IsUnicode(false);

            modelBuilder.Entity<TBLOGRENCI>()
                .Property(e => e.SIFRE)
                .IsUnicode(false);

            modelBuilder.Entity<TBLOGRENCI>()
                .Property(e => e.MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<TBLOGRENCI>()
                .Property(e => e.SEHİR)
                .IsUnicode(false);
        }
    }
}

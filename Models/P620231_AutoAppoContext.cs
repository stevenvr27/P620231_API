using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace P620231_API.Models
{
    public partial class P620231_AutoAppoContext : DbContext
    {
        public P620231_AutoAppoContext()
        {
        }

        public P620231_AutoAppoContext(DbContextOptions<P620231_AutoAppoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<RecoveryCode> RecoveryCodes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("SERVER=.;DATABASE=P620231_AutoAppo;INTEGRATED SECURITY=TRUE;User Id=;Password=");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecoveryCode>(entity =>
            {
                entity.ToTable("RecoveryCode");

                entity.Property(e => e.RecoveryCodeId).HasColumnName("RecoveryCodeID");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.GenerateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecoveryCode1)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("RecoveryCode");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

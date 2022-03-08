using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EntityFrameworkSample.DBModels
{
    public partial class TournamentContext : DbContext
    {
        public TournamentContext()
        {
        }

        public TournamentContext(DbContextOptions<TournamentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Matchh> Matchhs { get; set; }
        public virtual DbSet<Team> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=BHAVNAWKS759;Database=Tournament;User ID=sa;Password=Bhavna@123;Encrypt=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Matchh>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK__Matchh__C1F8DC5947A32FCE");

                entity.ToTable("Matchh");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Namee)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Team1Navigation)
                    .WithMany(p => p.MatchhTeam1Navigations)
                    .HasForeignKey(d => d.Team1)
                    .HasConstraintName("FK__Matchh__Team1__2C3393D0");

                entity.HasOne(d => d.Team2Navigation)
                    .WithMany(p => p.MatchhTeam2Navigations)
                    .HasForeignKey(d => d.Team2)
                    .HasConstraintName("FK__Matchh__Team2__2D27B809");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.ToTable("Team");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TeamName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

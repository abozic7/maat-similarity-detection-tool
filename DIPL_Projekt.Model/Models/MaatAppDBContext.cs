using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DIPL_Projekt.Model.Models
{
    public partial class MaatAppDBContext : DbContext
    {
        public MaatAppDBContext()
        {
        }

        public MaatAppDBContext(DbContextOptions<MaatAppDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ComparisonResult> ComparisonResult { get; set; }
        public virtual DbSet<FileEntry> FileEntry { get; set; }
        public virtual DbSet<Task> Task { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=MaatAppDB;User ID=;Password=;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ComparisonResult>(entity =>
            {
                entity.HasKey(e => new { e.File1Id, e.File2Id });

                entity.Property(e => e.File1Id).HasColumnName("File1ID");

                entity.Property(e => e.File2Id).HasColumnName("File2ID");

                entity.Property(e => e.Jmbag1)
                    .IsRequired()
                    .HasColumnName("JMBAG1")
                    .HasMaxLength(255);

                entity.Property(e => e.Jmbag2)
                    .IsRequired()
                    .HasColumnName("JMBAG2")
                    .HasMaxLength(255);

                entity.Property(e => e.Similarity).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.WinnowingSimilarity).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.CheckSumSimilarity).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PropertiesSimilarity).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.HasOne(d => d.File1)
                    .WithMany(p => p.ComparisonResultFile1)
                    .HasForeignKey(d => d.File1Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_File1ComparisonResult");

                entity.HasOne(d => d.File2)
                    .WithMany(p => p.ComparisonResultFile2)
                    .HasForeignKey(d => d.File2Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_File2ComparisonResult");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.ComparisonResult)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TaskComparisonResult");
            });

            modelBuilder.Entity<FileEntry>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FileAuthor)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FileCheckSumAfterPreprocessing)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FileCheckSumBeforePreprocessing)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FileContent).IsRequired();

                entity.Property(e => e.FileContentAfterLexAnalysis).HasColumnName("FileContentAfterLexAnalysis");

                entity.Property(e => e.FileExtension)
                    .IsRequired()
                    .HasMaxLength(7);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FileSize).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FileNoOfLines).HasColumnName("FileNoOfLines");

                entity.Property(e => e.FileNoOfLineComments).HasColumnName("FileNoOfLineComments");

                entity.Property(e => e.FileNoOfBlockComments).HasColumnName("FileNoOfBlockComments");

                entity.Property(e => e.FileNoOfEmptyLines).HasColumnName("FileNoOfEmptyLines");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.FileEntry)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TaskFile");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.KgramLength)
                    .HasColumnName("KGramLength")
                    .HasDefaultValueSql("((3))");

                entity.Property(e => e.Pproperties)
                    .HasColumnName("PProperties")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CompareHashValues)
                    .HasColumnName("CompareHashValues")
                    .HasDefaultValue(true);

                entity.Property(e => e.Pwinnowing)
                    .HasColumnName("PWinnowing")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TaskCourse)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TaskCreatedOn).HasColumnType("datetime");

                entity.Property(e => e.TaskDesc).IsRequired();

                entity.Property(e => e.TaskName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.WindowSize).HasDefaultValueSql("((6))");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LibMan.Models.DB
{
    public partial class LibManContext : DbContext
    {
        public LibManContext()
        {
        }

        public LibManContext(DbContextOptions<LibManContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblLibrary> TblLibrary { get; set; }
        public virtual DbSet<TblUser> TblUser { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-N4G90AK\\SQLEXPRESS;Database=LibMan;Trusted_Connection=True;");
            }
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblLibrary>(entity =>
            {
                entity.HasKey(e => e.BookId);

                entity.Property(e => e.BookId)
                    .HasColumnName("Book_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Author).HasMaxLength(50);

                entity.Property(e => e.BookCoverName).HasColumnName("BookCover_Name").HasMaxLength(50);

                entity.Property(e => e.Catagories).HasMaxLength(50);

                entity.Property(e => e.Descripton).HasMaxLength(100);

                entity.Property(e => e.Publisher).HasMaxLength(50);

                entity.Property(e => e.Rate).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.Translator).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("User_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblLibrary)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_TblLibrary_TblUser");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BirthDate).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.PhotoName).HasMaxLength(50); 

                entity.Property(e => e.Surname).HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }


        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

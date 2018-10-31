using Microsoft.EntityFrameworkCore;

namespace Data.Models
{
    public partial class XYIncContext : DbContext
    {
        public XYIncContext()
        {
        }

        public XYIncContext(DbContextOptions<XYIncContext> options) : base(options)
        {
        }

        public virtual DbSet<TbPoi> TbPoi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Initial Catalog=db_xy_inc;Integrated Security=True;");
            //}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbPoi>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });
        }
    }
}

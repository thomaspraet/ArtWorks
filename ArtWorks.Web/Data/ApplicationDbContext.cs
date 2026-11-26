using ArtWorks.Web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ArtWorks.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Technics> Technics { get; set; }
   


        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Technics>().HasData(

            new Technics { Id = 1, DisplayOrder = 1, Name = "Acryl" },
            new Technics { Id = 2, DisplayOrder = 2, Name = "Aquarel" },
            new Technics { Id = 3, DisplayOrder = 3, Name = "Aquarel & fineliner" },
            new Technics { Id = 4, DisplayOrder = 4, Name = "Aquatint" },
            new Technics { Id = 5, DisplayOrder = 5, Name = "Bister" },
            new Technics { Id = 6, DisplayOrder = 6, Name = "Balpen & markers" },
            new Technics { Id = 7, DisplayOrder = 7, Name = "Cement" },
            new Technics { Id = 8, DisplayOrder = 8, Name = "Ets" },
            new Technics { Id = 9, DisplayOrder = 9, Name = "Ets, droge naald" },
            new Technics { Id = 10, DisplayOrder = 10, Name = "Gemengde techniek" },
            new Technics { Id = 11, DisplayOrder = 11, Name = "Gouache" },
            new Technics { Id = 12, DisplayOrder = 12, Name = "Houtsnede" },
            new Technics { Id = 13, DisplayOrder = 13, Name = "Keramiek" },
            new Technics { Id = 14, DisplayOrder = 14, Name = "Klei" },
            new Technics { Id = 15, DisplayOrder = 15, Name = "Kleurpotlood" },
            new Technics { Id = 16, DisplayOrder = 16, Name = "Linosnede" },
            new Technics { Id = 17, DisplayOrder = 17, Name = "Nagellak" },
            new Technics { Id = 18, DisplayOrder = 18, Name = "Litho" },
            new Technics { Id = 19, DisplayOrder = 19, Name = "Offset druk" },
            new Technics { Id = 20, DisplayOrder = 20, Name = "Olieverf" },
            new Technics { Id = 21, DisplayOrder = 21, Name = "Oostindische inkt" },
            new Technics { Id = 22, DisplayOrder = 22, Name = "Opgehoogde zeefdruk" },
            new Technics { Id = 23, DisplayOrder = 23, Name = "PC grafiek" },
            new Technics { Id = 24, DisplayOrder = 24, Name = "Print op doek" },
            new Technics { Id = 25, DisplayOrder = 25, Name = "Print op fotopapier" },
            new Technics { Id = 26, DisplayOrder = 26, Name = "Resin" },
            new Technics { Id = 27, DisplayOrder = 27, Name = "Zeefdruk" }

            );
        }
    }
}


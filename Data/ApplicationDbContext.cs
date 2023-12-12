using ContactManagerProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ContactManagerProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public static void Initialize(ApplicationDbContext context)
        {
            // Seed des catégories
            context.Categories.AddRange(
                new Categorie { Nom = "Famille" },
                new Categorie { Nom = "Ami" },
                new Categorie { Nom = "Travail" },
                new Categorie { Nom = "Autre" }
            );

            context.SaveChanges();
        }
    }
}

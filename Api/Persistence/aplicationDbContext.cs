using Aplicacion.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Api.Persistence;

    public class aplicationDbContext : DbContext
    {
        public aplicationDbContext(DbContextOptions<aplicationDbContext> opciones)
            :base(opciones)
        {
            
        }

        public DbSet<Store> Stores {get; set;}
        public DbSet<Seller> Sellers {get; set;}

        public DbSet<Categories> Categories {get; set;}
        public DbSet<Product> Products {get; set;}
        public DbSet<Publications> publications {get; set;}
        public DbSet<Users> users {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Store>().HasData(
            new Store ("Nike"),
            new Store ("Adidas"),
            new Store ("Puma")
        );
        var user1 = new Users("Usuario1", "pass123");
        var user2 = new Users("Usuario2", "pass1234");

        modelBuilder.Entity<Users>().HasData(
            new Users("Usuario1", "pass123"),
            new Users("Usuario2", "pass123"),
            user1,
            user2
        );

        modelBuilder.Entity<Seller>().HasData(
            new Seller(20463633836, "Franco", "Salinas", "Av San Juan", user1),
            new Seller(22993949399, "Facundo", "Mansilla", "Lanus", user2)
        );
    }
}


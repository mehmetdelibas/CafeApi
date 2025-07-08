using CafeApi.WebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace CafeApi.WebApi.Context
{
    public class ApiContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;initial catalog = ApiYummyDb; integrated security=true;TrustServerCertificate=True;");
        }

        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<Cheff> Cheffs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}

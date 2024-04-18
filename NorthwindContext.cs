using Microsoft.EntityFrameworkCore;

namespace Kirk_Module5CodingChallenge
{
    public class NorthwindContext : DbContext
    {
        //the dbset class reps a set of entities that you can perform create, read, update, and delete ops (CRUD)
        public DbSet<Customer> Customers { get; set; }

        //Overload the OnConfiguring method in parent class to set configuration
        //Important: replace yourcomputer with the name of your computer
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=NOAHS-PC\ANOKATECH;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }//end class
}//end namespace

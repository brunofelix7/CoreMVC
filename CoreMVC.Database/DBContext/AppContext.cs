using CoreMVC.Model.Model;
using Microsoft.EntityFrameworkCore;

namespace CoreMVC.Database.DBContext {

    public class AppContext : DbContext{

        public AppContext(DbContextOptions<AppContext> options) : base(options) {

        }

        public DbSet<Customer> Customers {get; set;}

    }
}
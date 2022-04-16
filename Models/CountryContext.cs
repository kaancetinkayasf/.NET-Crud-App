using Microsoft.EntityFrameworkCore;

namespace CountryApp.Models
{
    public class CountryContext:DbContext
    {
        public CountryContext(DbContextOptions<CountryContext>options): base(options){

        }

        public DbSet<CountryItem> CountryItems{get; set;} = null!;
        
    }
}
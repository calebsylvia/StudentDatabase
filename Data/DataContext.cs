using Microsoft.EntityFrameworkCore;
using SylviaCMiniChallenge.Models;

namespace SylviaCMiniChallenge.Data;

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; } 
    }

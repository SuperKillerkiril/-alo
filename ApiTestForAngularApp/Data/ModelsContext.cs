using ApiTestForAngularApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiTestForAngularApp.DataBase;

public class ModelsContext : DbContext
{
    public DbSet<User> Users { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite("Data Source=UrbanMuseModels.db"); 
    }
}
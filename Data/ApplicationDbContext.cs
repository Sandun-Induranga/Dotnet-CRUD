namespace dotnet_crud.DbContexts;
using Microsoft.EntityFrameworkCore;
using dotnet_crud.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    public DbSet<Customer> Customers { get; set; }
}

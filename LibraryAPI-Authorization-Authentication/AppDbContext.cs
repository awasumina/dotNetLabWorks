using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<User>(entity =>
    //    {
    //        entity.ToTable("users");  // map User entity to lowercase "users" table in PostgreSQL
    //    });

    //    base.OnModelCreating(modelBuilder);
    //}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("users"); 

            entity.Property(e => e.Id)
                  .HasColumnName("id");  
            entity.Property(u => u.Username).HasColumnName("username"); 
            entity.Property(u => u.PasswordHash).HasColumnName("passwordhash");
            entity.Property(u => u.Role).HasColumnName("role");

        });

        base.OnModelCreating(modelBuilder);
    }

}
public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
}

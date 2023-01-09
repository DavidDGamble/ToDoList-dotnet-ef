using Microsoft.AspNetCore.Identity.EntityFrameworkCore; // Needed for IdentityDbContext<ApplicationUser>
using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
  // Extend with DBContext for database only and IdentityDbContext<ApplicationUser> for database and identity verification
  public class ToDoListContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Category> Categories { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<ItemTag> ItemTags { get; set; }

    public ToDoListContext(DbContextOptions options) : base(options) { }
  }
}

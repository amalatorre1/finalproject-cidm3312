using Microsoft.EntityFrameworkCore;

namespace finalproject_cidm3312.Models
{
	public class RecipeDbContext : DbContext
	{
		public RecipeDbContext (DbContextOptions<RecipeDbContext> options)
			: base(options)
		{
		}
		
		// protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<UserRecipe>().HasKey(u => new {u.RecipeId, u.UserId});
        // }
		public DbSet<Recipe> Recipes {get; set;}
		public DbSet<User> Users {get; set;}
		public DbSet<UserRecipe> UserRecipes {get; set;}
	}
}

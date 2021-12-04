using Microsoft.EntityFrameworkCore;

namespace finalproject_cidm3312.Models
{
	public class RecipeDbContext : DbContext
	{
		public RecipeDbContext (DbContextOptions<RecipeDbContext> options)
			: base(options)
		{
		}
	
		public DbSet<Recipe> Recipes {get; set;}
		public DbSet<User> Users {get; set;}
	}
}

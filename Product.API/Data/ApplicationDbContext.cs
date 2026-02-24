using Microsoft.EntityFrameworkCore;
using YourProjectName.Domain;

namespace YourProjectName.Domain
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<Product> Products { get; set; }
	}
}
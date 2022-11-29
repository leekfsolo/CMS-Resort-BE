using CMS_Resort.Data;
using Microsoft.EntityFrameworkCore;

namespace CMS_Resort.Providers
{
	public class BaseProvider
	{
		public DataContext db;

		public BaseProvider()
		{
			DbContextOptionsBuilder<DataContext> optionsBuilder = new();
			optionsBuilder.UseNpgsql("Host=localhost;Database=Resort Management;Username=sManager;Password=admin;");
			db = new DataContext(optionsBuilder.Options);
		}
		public async Task<bool> SaveDataAsync()
		{
			await db.SaveChangesAsync();
			return true;

		}
	}
}

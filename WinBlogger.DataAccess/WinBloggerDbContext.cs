using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WinBlogger.Model;

namespace WinBlogger.DataAccess;

public class WinBloggerDbContext : DbContext
{
	IConfigurationRoot? _configuration;

	public DbSet<Blogger> Bloggers { get; set; }

	public WinBloggerDbContext() : base() { }

	// constructor for dependency injection
	public WinBloggerDbContext(DbContextOptions options) : base(options) { }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		if (optionsBuilder.IsConfigured) return;


		var builder = new ConfigurationBuilder()
										.SetBasePath(Directory.GetCurrentDirectory())
										.AddJsonFile("appsettings.json", optional: true,
																		reloadOnChange: true);

		_configuration = builder.Build();

		var cnstr = _configuration.GetConnectionString("WinBlogger");

		optionsBuilder.UseSqlServer(cnstr);
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
	}
}

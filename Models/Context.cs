using Microsoft.EntityFrameworkCore;

namespace Barinak.Odev.Models
{
	public class Context:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server= DESKTOP-07K1L9T\\MSSQLSERVER05;" +
				" database= barınak2;" +
				" integrated security=true;"+
				"TrustServerCertificate = True;");

		}
		public DbSet<Turler>Turlers { get; set; }
		public DbSet<Hayvanlar> Hayvanlars { get; set; }
		public DbSet<Admin> Admins { get; set; }
	}
}

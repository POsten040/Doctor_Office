using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Doctor_Office.Models
{
  public class Doctor_OfficeContextFactory : IDesignTimeDbContextFactory<Doctor_OfficeContext>
  {

    Doctor_OfficeContext IDesignTimeDbContextFactory<Doctor_OfficeContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<Doctor_OfficeContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new Doctor_OfficeContext(builder.Options);
    }
  }
}
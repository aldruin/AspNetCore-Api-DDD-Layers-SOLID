﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CashFlowAPI.Infrastructure.Context;
public sealed class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {

        var config = new ConfigurationBuilder()
            .AddUserSecrets<AppDbContext>()
            .AddEnvironmentVariables()
            .Build();

        var builder = new DbContextOptionsBuilder<AppDbContext>();
        var connectionString = config.GetConnectionString("DefaultConnection");
        builder.UseSqlServer(connectionString);
        Console.WriteLine(connectionString);
        return new AppDbContext(builder.Options);
    }
}

using Microsoft.EntityFrameworkCore;
using Pronia.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronia.DAL.Contexts;

public class ProniaDBContext:DbContext
{
    public readonly string _connectionStr = @"Server=.\SQLEXPRESS;Database=ProniaDB;Trusted_Connection=True;TrustServerCertificate=True";
    public DbSet<SliderItem>SliderItems { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionStr);
        base.OnConfiguring(optionsBuilder);
    }
}


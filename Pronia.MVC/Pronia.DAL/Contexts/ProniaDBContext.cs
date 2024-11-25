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
    public DbSet<SliderItem>SliderItems { get; set; }
    public ProniaDBContext(DbContextOptions<ProniaDBContext> opt) : base(opt)
    {

    }
}


using DockerComposeLab.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DockerComposeLab.Data
{
    public class DataContextClass : DbContext
    {
        public DataContextClass(DbContextOptions<DataContextClass> options) : base(options)
        {
        }

        public DbSet<FavoriteBand> FavoriteBands { get; set; }
    }
}

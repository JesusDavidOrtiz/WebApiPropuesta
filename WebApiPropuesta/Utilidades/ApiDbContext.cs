using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApiPropuesta.DTOs;
using WebApiPropuesta.Models;

namespace WebApiPropuesta.Utilidades
{
    public class ApiDbContext : DbContext
    {

        public ApiDbContext(DbContextOptions<ApiDbContext> dbContextOptions)
            : base(dbContextOptions)
        {

        }

        public DbSet<Productos> Productos { get; set; }
    }
}

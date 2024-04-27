using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ParcialTicona.Models;

namespace ParcialTicona.Data
{
    public class ClienteContext : DbContext
    {
        
        public DbSet<Cliente> TablaCliente { get; set; }
        public ClienteContext(DbContextOptions dco) : base(dco) {

        }
    }
}
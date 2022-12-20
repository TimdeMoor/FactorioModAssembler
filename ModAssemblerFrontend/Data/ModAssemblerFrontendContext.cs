using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModAssemblerFrontend.Models;

namespace ModAssemblerFrontend.Data
{
    public class ModAssemblerFrontendContext : DbContext
    {
        public ModAssemblerFrontendContext (DbContextOptions<ModAssemblerFrontendContext> options)
            : base(options)
        {
        }

        public DbSet<ModAssemblerFrontend.Models.TestViewModel> TestViewModel { get; set; } = default!;
    }
}

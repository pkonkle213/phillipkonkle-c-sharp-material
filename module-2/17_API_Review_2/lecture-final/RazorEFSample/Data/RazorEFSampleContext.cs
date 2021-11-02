using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorEFSample.Models;

namespace RazorEFSample.Data
{
    public class RazorEFSampleContext : DbContext
    {
        public RazorEFSampleContext (DbContextOptions<RazorEFSampleContext> options)
            : base(options)
        {
        }

        public DbSet<RazorEFSample.Models.Bug> Bug { get; set; }
    }
}

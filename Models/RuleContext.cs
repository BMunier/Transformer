using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Transformer.Models
{
    public class RuleContext : DbContext
    {
        public RuleContext(DbContextOptions<RuleContext> options)
            : base(options)
        {
        }

        public DbSet<Rule> Rules { get; set; } = null!;
    }
}
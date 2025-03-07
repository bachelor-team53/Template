using TemplateApplication.Model;
using Microsoft.EntityFrameworkCore;

namespace TemplateApplication.Repo;

public class InitContext : DbContext {
    private readonly IConfiguration _configuration;
    
    public InitContext(DbContextOptions<InitContext> options, IConfiguration configuration) 
        : base(options)
    {
        _configuration = configuration;
    }
    
    public DbSet<Template> Templates { get; set; }
    public DbSet<TemplateTwo> TemplateTwos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);
        
    }
}
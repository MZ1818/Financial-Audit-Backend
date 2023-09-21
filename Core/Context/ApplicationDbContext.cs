using backend.Core.Entities;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace backend.Core.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Workspace> Workspaces { get; set; }
        public DbSet<Entities.Task> Tasks { get; set; }
        public DbSet<Notes> Notess { get; set; }

        public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Entities.Task>()
                .HasOne(task => task.Workspace)
                .WithMany(workspace => workspace.Tasks)
                .HasForeignKey(task => task.WorkspaceId);

            modelBuilder.Entity<Notes>()
                .HasOne(notes => notes.Task)
                .WithMany(task => task.Notess)
                .HasForeignKey(notes => notes.TaskId);


        }
    }
}
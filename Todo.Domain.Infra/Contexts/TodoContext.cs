using System;
using System.Net.Mime;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Todo.Domain.Entities;

namespace Todo.Domain.Infra.Contexts
{
    public class DataContext : DbContext
    {
        public DbSet<TodoItem> Todos { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TodoItem).Assembly);
        }
    }
}
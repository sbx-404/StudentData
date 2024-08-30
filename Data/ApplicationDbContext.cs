namespace StudentTodo.Data;
using Microsoft.EntityFrameworkCore;
using StudentTodo.Models;


public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<StudentTable> StudentTodos { get; set;}
}







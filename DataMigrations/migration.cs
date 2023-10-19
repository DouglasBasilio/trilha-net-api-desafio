using Microsoft.EntityFrameworkCore;
using TrilhaApiDesafio.Models;

public class OrganizadorContext : DbContext
{
    public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options) { }

    public DbSet<Tarefa> Tarefas { get; set; }
}

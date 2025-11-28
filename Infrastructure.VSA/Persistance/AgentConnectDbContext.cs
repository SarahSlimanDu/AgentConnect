using Domain.VSA.Entities;
using Domain.VSA.Entities.Assignments;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.VSA.Persistance
{
    public class AgentConnectDbContext : DbContext
    {
        public DbSet<Agent> Agents { get; set; }    
        public DbSet<SupportTicket> SupportTickets { get; set; }    
        public DbSet<User> Users { get; set; }    
        public DbSet<Assignment> Assignments { get; set; }    

    }
}

using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Persistance;

namespace Infrastructure.Repositories
{
    public class AssignmentRepository(AgentConnectDbContext context) : IAssignmentRepository
    {
        private readonly AgentConnectDbContext _context = context;
        public async Task AddAssignementAsync(Assignment assignment)
        {
           await _context.Assignments.AddAsync(assignment);
        }
    }
}

using Domain.VSA.Entities.Assignments;
using Infrastructure.VSA.Persistance;


namespace Infrastructure.VSA.Repositories
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



namespace Domain.VSA.Entities.Assignments
{
    public interface IAssignmentRepository
    {
        Task AddAssignementAsync(Assignment assignment);
    }
}

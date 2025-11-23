
namespace Domain.Core.Abstractions;

public interface ISoftDeletableEntity
{
    DateTime? DeletedOn { get; }

    bool Deleted { get; }
}

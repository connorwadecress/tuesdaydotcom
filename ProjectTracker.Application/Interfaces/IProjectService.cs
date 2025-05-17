using ProjectTracker.Application.Interfaces.Base;
using ProjectTracker.Domain.Entities;

namespace ProjectTracker.Application.Interfaces;

public interface IProjectService : IService<Project>
{
    Task<IEnumerable<Board>> GetBoardsAsync(int projectId, CancellationToken cancellationToken);
}
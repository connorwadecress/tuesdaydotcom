using Microsoft.EntityFrameworkCore;
using ProjectTracker.Application.Interfaces;
using ProjectTracker.Application.Services.Base;
using ProjectTracker.Domain.Entities;
using ProjectTracker.Infrastructure;

namespace ProjectTracker.Application.Services;

public sealed class ProjectService(ProjectTrackerDbContext dbContext) : Service<Project>(dbContext), IProjectService
{
    public new async Task<Project?> GetByIdAsync(int id, CancellationToken cancellationToken) =>
        await dbContext.Projects
            .Include(x => x.Tags)
            .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

    public new async Task<IEnumerable<Project>> GetAllAsync(CancellationToken cancellationToken) =>
        await dbContext.Projects
            .Include(x => x.Tags)
            .ToListAsync(cancellationToken);

    public async Task<IEnumerable<Board>> GetBoardsAsync(int projectId, CancellationToken cancellationToken) =>
        await dbContext.Boards
            .Where(b => b.ProjectID == projectId)
            .ToListAsync(cancellationToken);
}
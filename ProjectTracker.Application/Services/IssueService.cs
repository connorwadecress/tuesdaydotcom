using Microsoft.EntityFrameworkCore;
using ProjectTracker.Application.Interfaces;
using ProjectTracker.Application.Services.Base;
using ProjectTracker.Domain.Entities;
using ProjectTracker.Infrastructure;

namespace ProjectTracker.Application.Services;

public sealed class IssueService(ProjectTrackerDbContext dbContext) : Service<Issue>(dbContext), IIssueService
{
    public new async Task<Issue?> GetByIdAsync(int id, CancellationToken cancellationToken) =>
        await dbContext.Issues
            .Include(x => x.Tags)
            .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    
    public new async Task<List<Issue>> GetAllAsync(CancellationToken cancellationToken) =>
        await dbContext.Issues
            .Include(x => x.Tags)
            .ToListAsync(cancellationToken);
}
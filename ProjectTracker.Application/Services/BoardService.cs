using Microsoft.EntityFrameworkCore;
using ProjectTracker.Application.Interfaces;
using ProjectTracker.Application.Services.Base;
using ProjectTracker.Domain.Entities;
using ProjectTracker.Domain.Models;
using ProjectTracker.Infrastructure;

namespace ProjectTracker.Application.Services;

public sealed class BoardService(ProjectTrackerDbContext dbContext) : Service<Board>(dbContext), IBoardService
{
    public new async Task<Board?> GetByIdAsync(int id, CancellationToken cancellationToken) =>
        await dbContext.Boards
            .Include(b => b.Tags)
            .FirstOrDefaultAsync(b => b.Id == id, cancellationToken);
    
    public new async Task<IEnumerable<Board>> GetAllAsync(CancellationToken cancellationToken) =>
        await dbContext.Boards
            .Include(b => b.Tags)
            .ToListAsync(cancellationToken);

    public async Task<BoardDetails> GetBoardDetailsAsync(int boardId, CancellationToken cancellationToken) =>
        await dbContext.Boards
            .Where(b => b.Id == boardId)
            .Select(x => new BoardDetails
            {
                Project = x.Project,
                Board = x,
                Groups = x.Groups.Select(x => new GroupDetails
                {
                    Group = x,
                    Issues = x.Issues
                }).ToList()
            })
            .FirstOrDefaultAsync(cancellationToken);
}
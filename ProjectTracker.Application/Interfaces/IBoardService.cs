using ProjectTracker.Application.Interfaces.Base;
using ProjectTracker.Domain.Entities;
using ProjectTracker.Domain.Models;

namespace ProjectTracker.Application.Interfaces;

public interface IBoardService : IService<Board>
{
    Task<BoardDetails> GetBoardDetailsAsync(int boardId, CancellationToken cancellationToken);
}
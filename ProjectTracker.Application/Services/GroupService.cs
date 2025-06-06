using ProjectTracker.Application.Interfaces;
using ProjectTracker.Application.Services.Base;
using ProjectTracker.Domain.Entities;
using ProjectTracker.Infrastructure;

namespace ProjectTracker.Application.Services;

public sealed class GroupService(ProjectTrackerDbContext dbContext) : Service<Group>(dbContext), IGroupService;
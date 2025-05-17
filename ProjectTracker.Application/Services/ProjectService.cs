using ProjectTracker.Application.Interfaces;
using ProjectTracker.Application.Services.Base;
using ProjectTracker.Domain.Entities;
using ProjectTracker.Infrastructure;

namespace ProjectTracker.Application.Services;

public sealed class ProjectService(ProjectTrackerDbContext dbContext) : Service<Project>(dbContext), IProjectService;
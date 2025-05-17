using Microsoft.Extensions.DependencyInjection;
using ProjectTracker.Application.Interfaces;
using ProjectTracker.Application.Services;

namespace ProjectTracker.Application.Extensions;

public static class ServiceExtensions
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IProjectService, ProjectService>();
        services.AddScoped<IBoardService, BoardService>();
        services.AddScoped<IGroupService, GroupService>();
        services.AddScoped<IIssueService, IssueService>();
        services.AddScoped<ITagService, TagService>();
    }
}
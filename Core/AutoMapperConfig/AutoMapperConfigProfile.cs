using AutoMapper;
using backend.Core.Dtos.Task;
using backend.Core.Dtos.Workspace;
using backend.Core.Dtos.Notes;

using backend.Core.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace backend.Core.AutoMapperConfig
{
    public class AutoMapperConfigProfile : Profile
    {
        public AutoMapperConfigProfile()
        {
            // Workspace
            CreateMap<WorkspaceCreateDto, Workspace>();
            CreateMap<Workspace, WorkspaceGetDto>();

            // Task
            CreateMap<TaskCreateDto, Entities.Task>();
            CreateMap<Entities.Task, TaskGetDto>();

            // Notes
            CreateMap<NotesCreateDto, Notes>();
            CreateMap<Notes, NotesGetDto>();


        }
    }
}

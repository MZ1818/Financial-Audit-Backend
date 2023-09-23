using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Core.Dtos.Task
{
    public class TaskCreateDto
    {
        public long WorkspaceId { get; set; }

        public string Title { get; set; }

        public string TitleDescription { get; set; }


    }
}

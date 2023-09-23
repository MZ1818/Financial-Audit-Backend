using backend.Core.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Core.Dtos.Task
{
    public class TaskGetDto
    {
        public long TaskId { get; set; }

        public long WorkspaceId { get; set; }

        public string Title { get; set; }

        public string TitleDescription { get; set; }


    }
}

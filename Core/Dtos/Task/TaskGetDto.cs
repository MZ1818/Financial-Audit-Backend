using backend.Core.Entities;

namespace backend.Core.Dtos.Task
{
    public class TaskGetDto
    {
        public long ID { get; set; }
        public string Title { get; set; }
        public string TitleDescription { get; set; }

        public long WorkspaceId { get; set; }



    }
}

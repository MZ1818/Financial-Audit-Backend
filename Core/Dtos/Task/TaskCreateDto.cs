namespace backend.Core.Dtos.Task
{
    public class TaskCreateDto
    {
        public string Title { get; set; }
        public string TitleDescription { get; set; }
        public long WorkspaceId { get; set; }
    }
}

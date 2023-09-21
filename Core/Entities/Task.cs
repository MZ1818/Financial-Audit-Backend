using Microsoft.Extensions.Logging;

namespace backend.Core.Entities
{
    public class Task:BaseEntity
    {
        public string Title { get; set; }
        public string TitleDescription { get; set; }

        // Relations
        public long WorkspaceId { get; set; }
        public Workspace Workspace { get; set; }

        public ICollection<Notes> Notess { get; set; }
    }
}

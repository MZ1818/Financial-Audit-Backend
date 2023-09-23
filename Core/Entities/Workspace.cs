using System.ComponentModel.DataAnnotations;

namespace backend.Core.Entities
{
    public class Workspace
    {
        [Key]
        public long WorkspaceId { get; set; }
        public string title { get; set; }       
        public string ComapanyId { get; set; }
        public string CompanyName { get; set; }

        // Relations
        public ICollection<Task> Tasks { get; set; }
    }
}

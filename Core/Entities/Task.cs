using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Core.Entities
{
    public class Task
    {
        [Required]
        [Key]
        public long TaskId { get; set; }

        // Relations
        [ForeignKey("Workspace")]
        public long WorkspaceId { get; set; }

        public string Title { get; set; }

        public string TitleDescription { get; set; }

        public Workspace Workspace { get; set; }

        public ICollection<Notes> Notess { get; set; }
    }
}

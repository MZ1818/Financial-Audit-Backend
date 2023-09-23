using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Core.Entities
{
    public class Document
    {
        
        [Key]
        public int DocumentId { get; set; }

        [Required]
        [ForeignKey("Task")]
        public long TaskId { get; set; }

        public string Title { get; set; }

        public string Type { get; set; }
    }
}

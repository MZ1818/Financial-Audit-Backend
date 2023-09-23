using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Core.Entities
{
    public class Notes 
    {
        [Key]
        public long NoteId { get; set; }
        public string sender { get; set; }
        public string receiver { get; set; }
        public string MessagText { get; set; }
        public DateTime DateCreated { get; set; }


        // Relations
        [ForeignKey("Task")]
        public long TaskId { get; set; }
        public bool status { get; set; }
        public Task Task { get; set; }
    }
}

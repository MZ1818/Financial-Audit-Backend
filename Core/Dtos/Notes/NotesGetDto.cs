using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Core.Dtos.Notes
{
    public class NotesGetDto
    {
        public long NoteId { get; set; }
        public string sender { get; set; }
        public string receiver { get; set; }
        public string MessagText { get; set; }
        public DateTime DateCreated { get; set; }
        public long TaskId { get; set; }
        public bool status { get; set; }


    }
}

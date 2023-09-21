namespace backend.Core.Dtos.Notes
{
    public class NotesGetDto
    {
        public long ID { get; set; }
 

        public string NotesTitle { get; set; }
        public string NotesDescription { get; set; }


        // Relations

        public long TaskId { get; set; }


    }
}

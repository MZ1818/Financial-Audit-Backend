namespace backend.Core.Entities
{
    public class Notes : BaseEntity 
    {
        public string NotesTitle { get; set; }
        public string NotesDescription { get; set; }
      

        // Relations

        public long TaskId { get; set; }
        public Task Task { get; set; }
    }
}

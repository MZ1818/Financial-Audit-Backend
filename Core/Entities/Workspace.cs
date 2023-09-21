namespace backend.Core.Entities
{
    public class Workspace:BaseEntity
    {
        public string Name { get; set; }
        public string CompanyName { get; set; }

        // Relations
        public ICollection<Task> Tasks { get; set; }
    }
}

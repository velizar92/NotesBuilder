namespace NotesBuilderLibrary.Models
{
    public class Reminder
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Time { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}

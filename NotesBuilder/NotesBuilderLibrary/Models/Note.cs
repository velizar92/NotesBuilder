namespace NotesBuilderLibrary.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }   
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }  
        public NoteType NoteType { get; set; }

        public int UserId { get; set; }
        public int CategoryId { get; set; }

    
        public User User { get; set; }
        public Category Category { get; set; }
    }
}

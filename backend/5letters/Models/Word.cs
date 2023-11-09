namespace _5letters.Models
{
    public class Word : BaseEntity
    {
        public string word { get; set; } 
        public DateTimeOffset Date { get; set; } = DateTimeOffset.UtcNow;
    }
}

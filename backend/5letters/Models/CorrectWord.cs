namespace _5letters.Models
{
    public class CorrectWord : BaseEntity
    {
        public DateTimeOffset Date { get; set; } = DateTimeOffset.UtcNow;
        public string Word { get; set; }
    }
}

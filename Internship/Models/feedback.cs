namespace Internship.Models
{
    public class feedback
    {
        public long Id { get; set; }
        public string Content { get; set; }
        public long ReportId { get; set; }
        public DateTime UpdateAt { get; set; }

        public report report { get; set; }
    }
}

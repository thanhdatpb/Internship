namespace Internship.Models
{
    public class report
    {
        public long Id { get; set; }
        public string Content { get; set; }
        public long InternProgramId { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public Intern_Programs InternProgram { get; set; }
        public ICollection<feedback> Feedbacks { get; set; }
    }
}

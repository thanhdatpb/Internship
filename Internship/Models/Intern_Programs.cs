namespace Internship.Models
{
    public class Intern_Programs
    {
        public long Id { get; set; }
        public long InternId { get; set; }
        public long ProgramId { get; set; }
        public long MentorId { get; set; }

        public Intern Intern { get; set; }
        public programs programs  { get; set; }
        public mentor Mentor { get; set; }
        public ICollection<report> Reports { get; set; }
    }
}

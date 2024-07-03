namespace Internship.Models
{
    public class mentor
    {
        public long Id { get; set; }
        public string Position { get; set; }
        public string Skill { get; set; }

        public ICollection<Intern_Programs> InternPrograms { get; set; }
    }
}

namespace Internship.Models
{
   public class Intern
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long University { get; set; }
        public long BirthYear { get; set; }

        public users User { get; set; }
        public ICollection<Intern_Programs> InternPrograms { get; set; }
    }
}

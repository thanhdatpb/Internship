namespace Internship.Models
{
    public class programs
    {
        public long Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public long start_date { get; set; }
        public long end_date { get; set; }

        public ICollection<Intern_Programs> Intern_Programs { get; set; }
    }
}

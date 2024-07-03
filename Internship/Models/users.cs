namespace Internship.Models
{
    public class users
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public long RoleCode { get; set; }

        public ICollection<Intern> Interns { get; set; }
    }
}

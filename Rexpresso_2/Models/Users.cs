namespace Rexpresso_2.Models
{
    public class Users: UserActivity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get; set; }

        public int PhoneNumber;

        public string Email { get; set; }

        public string Password { get; set; }



        public string Role { get; set; }

    }
}

namespace Angular_Using_Core_API.Server.DTOs
{
    public class UserDTOs
    {

        public string? FullName { get; set; }

        public string Email { get; set; } = null!;

        public string? PasswordHashed { get; set; }
    }
}

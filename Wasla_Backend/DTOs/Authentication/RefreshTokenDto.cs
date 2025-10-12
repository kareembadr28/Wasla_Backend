namespace Wasla_Backend.DTOs.Authentication
{
    public class RefreshTokenDto
    {
        [Required]
        public string RefreshToken { get; set; }

    }
}

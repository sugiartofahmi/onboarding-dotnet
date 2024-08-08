
using System.ComponentModel.DataAnnotations;

namespace onboarding_backend.Dtos.Auth
{
    public class RegisterDto : LoginDto
    {

        [Required(ErrorMessage = "Avatar tidak boleh kosong")]
        public string Avatar { get; set; } = default!;

        [Required(ErrorMessage = "Nama tidak boleh kosong")]
        public string Name { get; set; } = default!;
    }
}
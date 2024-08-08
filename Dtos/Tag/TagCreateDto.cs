using System.ComponentModel.DataAnnotations;

namespace onboarding_backend.Dtos.Tag
{
    public class TagCreateDto
    {
        [Required(ErrorMessage = "Name tidak boleh kosong")]
        public string Name { get; set; } = string.Empty;
    }
}

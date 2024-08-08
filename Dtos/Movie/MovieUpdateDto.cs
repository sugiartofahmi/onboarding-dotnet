using System.ComponentModel.DataAnnotations;

namespace onboarding_backend.Dtos.Movie
{
    public class MovieUpdateDto : MovieCreateDto
    {
        [Required(ErrorMessage = "Tag Ids tidak boleh kosong")]
        public int[] TagIds { get; set; } = [];
    }
}
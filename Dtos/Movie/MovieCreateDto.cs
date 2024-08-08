using System.ComponentModel.DataAnnotations;

namespace onboarding_backend.Dtos.Movie
{
    public class MovieCreateDto
    {
        [Required(ErrorMessage = "Title tidak boleh kosong")]
        public string Title { get; set; } = default!;

        [Required(ErrorMessage = "Overview tidak boleh kosong")]
        public string Overview { get; set; } = default!;

        [Required(ErrorMessage = "Poster tidak boleh kosong")]
        public string Poster { get; set; } = default!;

        [Required(ErrorMessage = "PlayUntil tidak boleh kosong")]
        public DateTime PlayUntil { get; set; }
    }
}
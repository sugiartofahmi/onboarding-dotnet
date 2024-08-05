using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace onboarding_backend.Dtos.Movie
{
    public class MovieUpdateDto : MovieCreateDto
    {
        [Required(ErrorMessage = "Tag Ids tidak boleh kosong")]
        public int[] TagIds { get; set; } = [];
    }
}
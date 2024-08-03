using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using onboarding_backend.Interfaces;

namespace onboarding_backend.Database.Entities
{
    public class Tag : Base, ITag
    {
        [Required]
        public string Name { get; set; }
        public List<MovieTag>? MovieTags { get; set; }

    }
}
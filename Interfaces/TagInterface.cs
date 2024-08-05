using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using onboarding_backend.Database.Entities;

namespace onboarding_backend.Interfaces
{
    public interface ITag : IBase
    {
        public string Name { get; set; }
    }
}
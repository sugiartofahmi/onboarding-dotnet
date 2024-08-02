using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace onboarding_backend.Interfaces
{
    public interface IStudio : IBase
    {
        public int StudioNumber { get; set; }
        public int SeatCapacity { get; set; }
    }
}
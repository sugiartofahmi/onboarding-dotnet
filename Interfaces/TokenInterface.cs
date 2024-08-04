using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace onboarding_backend.Interfaces
{
    public interface IToken
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
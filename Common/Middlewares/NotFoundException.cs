using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace onboarding_backend.Common.Middlewares
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message)
        {
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetEnv;

namespace onboarding_backend
{
    public class Config
    {
        public static string ConnectionString;
        static Config()
        {
            DotNetEnv.Env.Load();
            ConnectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");
        }
    }
}
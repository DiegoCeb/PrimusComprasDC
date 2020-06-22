using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cache
{
    public interface ICache
    {
        void MemoryCache();

        void RedisCache();
    }
}

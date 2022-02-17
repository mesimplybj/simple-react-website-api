using Microsoft.Extensions.Caching.Memory;
using simplereactapi.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simplereactapi.Helper
{
    public class MockData
    {
        private readonly IMemoryCache _memoryCache;

        public MockData(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        private async Task AddPortFolioData()
        {


            string heroSection = string.Empty;
            _memoryCache.Set(PortFolioSection.HeroSection, heroSection);
        }
    }
}

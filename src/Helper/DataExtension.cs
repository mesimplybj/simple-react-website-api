using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using simplereactapi.Constants;
using simplereactapi.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace simplereactapi.Helper
{
    public static class DataExtension
    {
        public static IApplicationBuilder LoadData(this IApplicationBuilder app, IMemoryCache memoryCache)
        {
            string fileData = System.IO.File.ReadAllText(Path.Combine("Data","data.json"));
            WebsiteData websiteData = JsonSerializer.Deserialize<WebsiteData>(fileData);
            memoryCache.Set(PortFolioSection.WebsiteData, websiteData);
            return app;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using simplereactapi.Constants;
using simplereactapi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace simplereactapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Portfolio : ControllerBase
    {
        private readonly IMemoryCache _memoryCache;
        private WebsiteData _websiteData;

        public Portfolio(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
            _websiteData = _memoryCache.Get<WebsiteData>(PortFolioSection.WebsiteData);
        }

        // GET: api/GetHeroSection
        [HttpGet("[Action]")]
        public Herosection GetHeroSection()
        {
            return _websiteData.HeroSection;
        }
        // GET: api/GetHeroSection
        [HttpGet("[Action]")]
        public About GetAbout()
        {
            return _websiteData.About;
        }
        // GET: api/GetHeroSection
        [HttpGet("[Action]")]
        public ServiceSection GetServiceSection()
        {
            return _websiteData.ServiceSection;
        }
        // GET: api/GetHeroSection
        [HttpGet("[Action]")]
        public Counter GetCounterSection()
        {
            return _websiteData.Counter;
        }
        // GET: api/PortfolioSection
        [HttpGet("[Action]")]
        public PortfolioSection GetPortfolioSection()
        {
            return _websiteData.PortfolioSection;
        }
        // GET: api/GetHeroSection
        [HttpGet("[Action]")]
        public Testimonial GetTestimonial()
        {
            return _websiteData.Testimonial;
        }
        // GET: api/GetHeroSection
        [HttpGet("[Action]")]
        public BlogSection GetBlogSectionn()
        {
            return _websiteData.BlogSection;
        }
    }
}

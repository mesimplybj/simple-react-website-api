using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simplereactapi.Entities
{
    public class WebsiteData
    {
        public Herosection HeroSection { get; set; }
        public About About { get; set; }
        public ServiceSection ServiceSection { get; set; }
        public Counter Counter { get; set; }
        public PortfolioSection PortfolioSection { get; set; }
        public Testimonial Testimonial { get; set; }
        public BlogSection BlogSection { get; set; }
    }

    public class Herosection
    {
        public string Image { get; set; }
        public string Text { get; set; }
    }

    public class About
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public string Profile { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Skills[] Skills { get; set; }
        public string[] AboutMe { get; set; }
    }

    public class Skills
    {
        public string Skill { get; set; }
        public string Percentage { get; set; }
    }

    public class ServiceSection
    {
        public string Subtitle { get; set; }
        public Service[] Services { get; set; }
    }

    public class Service
    {
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class Counter
    {
        public string BG { get; set; }
        public Counterlist[] CounterList { get; set; }
    }

    public class Counterlist
    {
        public string Icon { get; set; }
        public string Value { get; set; }
        public string Text { get; set; }
    }

    public class PortfolioSection
    {
        public string SubTitle { get; set; }
        public Portfoliolist[] PortfolioList { get; set; }
    }

    public class Portfoliolist
    {
        public string ProjectName { get; set; }
        public string Image { get; set; }
        public string Tag { get; set; }
        public string Date { get; set; }
    }

    public class Testimonial
    {
        public string BG { get; set; }
        public Item[] Items { get; set; }
    }

    public class Item
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public string Testimonial { get; set; }
    }

    public class BlogSection
    {
        public string SubTitle { get; set; }
        public Blog[] Blogs { get; set; }
    }

    public class Blog
    {
        public string Image { get; set; }
        public string Tag { get; set; }
        public string Author { get; set; }
        public string ReadTime { get; set; }
        public string Title { get; set; }
        public string Brief { get; set; }
    }

}

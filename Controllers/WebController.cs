using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HtmlAgilityPack;


namespace ScrapeController
{
    [Route("api/[controller]")]
    public class ScrapeController : Controller{
        //GET
        //Ripped Data
        //URL
        [HttpGet]
        public object getData(string url)
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);
            var nodes = doc.DocumentNode.SelectNodes("//a[@class='itemDetail']");
            
            return nodes;
            
        }
    }
}
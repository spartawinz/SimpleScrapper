using Microsoft.AspNetCore.Mvc;


namespace WebController
{
    [route("api/[controller]")]
    public class WebController : WebController{
        //GET
        //Ripped Data
        [HttpGet]
        public List<string> getData(string url)
        {
            List<string> data = new LinkedList();
            return data;
        }
    }
}
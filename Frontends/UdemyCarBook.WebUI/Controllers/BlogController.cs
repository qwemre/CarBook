using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdmyCarBook.Dto.BlogDtos;

namespace UdemyCarBook.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BlogController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.v1 = "Bloglar";
            ViewBag.v2 = "Yazarlarımızın Blogları";


            var client = _httpClientFactory.CreateClient();
            var ResponseMessage = await client.GetAsync("https://localhost:7292/api/Blogs/GetAllBlogWithAuthorList");
            if (ResponseMessage.IsSuccessStatusCode)
            {
                var jsonData = await ResponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAllBlogWithAuthorsDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        public async Task<IActionResult> BlogDetail(int id)
        {
            ViewBag.v1 = "Bloglar";
            ViewBag.v2 = "Blog Detayı Ve Yorumlar";
            ViewBag.blogid = id;
            return View();
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdmyCarBook.Dto.CarPricingDtos;

namespace UdemyCarBook.WebUI.Controllers
{
    public class CarController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CarController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.v1 = "Araçlarımız";
            ViewBag.v2 = "Aracınızı seçiniz";


            var client = _httpClientFactory.CreateClient();
            var ResponseMessage = await client.GetAsync("https://localhost:7292/api/CarPricings");
            if (ResponseMessage.IsSuccessStatusCode)
            {
                var jsonData = await ResponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResulCarPricingWithCarDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}

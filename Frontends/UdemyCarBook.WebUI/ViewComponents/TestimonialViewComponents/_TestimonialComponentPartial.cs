using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdmyCarBook.Dto.TestimonailDtos;

namespace UdemyCarBook.WebUI.ViewComponents.TestimonialViewComponents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _TestimonialComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var ResponseMessage = await client.GetAsync("https://localhost:7292/api/Testimonials");
            if (ResponseMessage.IsSuccessStatusCode)
            {
                var jsonData = await ResponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultTestimonailDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}

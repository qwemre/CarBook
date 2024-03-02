using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdmyCarBook.Dto.CategoryDtos;

namespace UdemyCarBook.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailCategoryComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _BlogDetailCategoryComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var ResponseMessage = await client.GetAsync("https://localhost:7292/api/Categories");
            if (ResponseMessage.IsSuccessStatusCode)
            {
                var jsonData = await ResponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}

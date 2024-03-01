﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdmyCarBook.Dto.BlogDtos;

namespace UdemyCarBook.WebUI.ViewComponents.BlogViewComponents
{
    public class _GetLast3BlogsWithAuthorListComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _GetLast3BlogsWithAuthorListComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7292/api/Blogs/GetLast3BlogWithAuthorList");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLast3BlogWithAuthorsDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
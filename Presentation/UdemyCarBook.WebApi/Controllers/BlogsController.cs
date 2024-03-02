﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands.BlogCommands;
using UdemyCarBook.Application.Features.Mediator.Queries.BlogQueries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {

        private readonly IMediator _mediator;

        public BlogsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> BlogList()
        {
            var values = await _mediator.Send(new GetBlogQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlog(int id)
        {
            var values = await _mediator.Send(new GetBlogByIdQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Blog Başarıyla Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> ReamoveBlog(int id)
        {
            await _mediator.Send(new RemoveBlogCommand(id));
            return Ok("Blog Başarıyla Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBlog(UpdateBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Blog Başarıyla Güncellendi");
        }
        [HttpGet("GetLast3BlogWithAuthorList")]
        public async Task<IActionResult> GetLast3BlogWithAuthorList()
        {
            var values=await _mediator.Send(new GetLast3BlogWithAuthorQuery());
            return Ok(values);
        }

        [HttpGet("GetAllBlogWithAuthorList")]
        public async Task<IActionResult> GetAllBlogWithAuthorList()
        {
            var values = await _mediator.Send(new GetAllBlogsWithAuthorQuery());
            return Ok(values);
        }

    }
}

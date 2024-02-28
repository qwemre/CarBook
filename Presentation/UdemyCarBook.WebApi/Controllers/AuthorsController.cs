using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands.AuthorCommands;
using UdemyCarBook.Application.Features.Mediator.Queries.AuthorQueries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {

        private readonly IMediator _mediator;

        public AuthorsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> AuthorList()
        {
            var values = await _mediator.Send(new GetAuthorQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthor(int id)
        {
            var values = await _mediator.Send(new GetAuthorByIdQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAuthor(CreateAuthorCommands command)
        {
            await _mediator.Send(command);
            return Ok("Yazar Başarıyla Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> ReamoveAuthor(int id)
        {
            await _mediator.Send(new RemoveAuthorCommands(id));
            return Ok("Yazar Başarıyla Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAuthor(UpdateAuthorCommands command)
        {
            await _mediator.Send(command);
            return Ok("Yazar Başarıyla Güncellendi");
        }

    }
}

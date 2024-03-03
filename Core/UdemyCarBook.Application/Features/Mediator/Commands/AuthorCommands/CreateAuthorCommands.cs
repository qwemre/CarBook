using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands.AuthorCommands
{
    public class CreateAuthorCommands : IRequest
    {

        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}

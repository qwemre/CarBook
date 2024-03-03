using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands.AuthorCommands
{
    public class RemoveAuthorCommands : IRequest
    {
        public int Id { get; set; }
        public RemoveAuthorCommands(int id)
        {
            Id = id;
        }

    }
}

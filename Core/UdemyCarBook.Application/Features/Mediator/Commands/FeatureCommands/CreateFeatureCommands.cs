using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands.FeatureCommands
{
    public class CreateFeatureCommands : IRequest
    {
        public string Name { get; set; }
    }
}

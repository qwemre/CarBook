using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands.FeatureCommands
{
    public class RemoveFeatureCommands : IRequest
    {
        public int Id { get; set; }
        public RemoveFeatureCommands(int id)
        {
            Id = id;
        }

    }
}

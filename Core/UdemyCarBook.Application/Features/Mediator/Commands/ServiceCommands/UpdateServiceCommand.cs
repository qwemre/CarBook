using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands.ServiceCommands
{
    public class UpdateServiceCommand : IRequest
    {
        public int ServiceID { get; set; }
        public string Tittle { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
    }
}

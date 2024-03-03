using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results.CarPircingResults;

namespace UdemyCarBook.Application.Features.Mediator.Queries.CarPircingQueries
{
    public class GetCarPricingWithCarQuery : IRequest<List<GetCarPricingWithCarQueryResult>>
    {
    }
}

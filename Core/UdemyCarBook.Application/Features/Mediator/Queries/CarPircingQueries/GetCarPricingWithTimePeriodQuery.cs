using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results.CarPircingResults;

namespace UdemyCarBook.Application.Features.Mediator.Queries.CarPircingQueries
{
    public class GetCarPricingWithTimePeriodQuery : IRequest<List<GetCarPricingWithTimePeriodQueryResult>>
    {
    }
}

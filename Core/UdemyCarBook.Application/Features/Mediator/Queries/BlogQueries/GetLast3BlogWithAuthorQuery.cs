using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results.BlogResults;

namespace UdemyCarBook.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetLast3BlogWithAuthorQuery : IRequest<List<GetLast3BlogWithAuthorQueryResult>>
    {
    }
}

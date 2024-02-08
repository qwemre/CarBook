using UdemyCarBook.Application.Features.CQRS.Results.BennerResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.BennerHandlers
{
    public class GetBannerQueryHandler
    {
        private readonly IRepository<Banner> _repository;

        public GetBannerQueryHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetBennerQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetBennerQueryResult()
            {
                BannerID = x.BannerID,
                Description = x.Description,
                Tittle = x.Tittle,
                VideoDescription = x.VideoDescription,
                VideoUrl = x.VideoUrl,
            }).ToList();

        }
    }
}

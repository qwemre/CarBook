namespace UdemyCarBook.Application.Features.CQRS.Queries.BennerQueries
{
    public class GetBannerByIdQuery
    {
        public GetBannerByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}

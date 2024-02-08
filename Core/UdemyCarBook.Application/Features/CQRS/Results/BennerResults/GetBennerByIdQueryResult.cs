namespace UdemyCarBook.Application.Features.CQRS.Results.BennerResults
{
    public class GetBennerByIdQueryResult
    {
        public int BannerID { get; set; }
        public string Tittle { get; set; }
        public string Description { get; set; }
        public string VideoDescription { get; set; }
        public string VideoUrl { get; set; }
    }
}

namespace UdemyCarBook.Application.Features.CQRS.Commands.BannerCommands
{
    public class CreateBannerCommand
    {

        public string Tittle { get; set; }
        public string Description { get; set; }
        public string VideoDescription { get; set; }
        public string VideoUrl { get; set; }
    }
}

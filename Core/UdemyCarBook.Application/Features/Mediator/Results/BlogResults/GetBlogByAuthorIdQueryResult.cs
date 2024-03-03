﻿namespace UdemyCarBook.Application.Features.Mediator.Results.BlogResults
{
    public class GetBlogByAuthorIdQueryResult
    {
        public int BlogID { get; set; }
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public string AuthorImageUrl { get; set; }
        public string AuthorDescription { get; set; }
    }
}

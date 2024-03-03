﻿namespace UdmyCarBook.Dto.BlogDtos
{
    public class ResultAllBlogWithAuthorsDto
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public string CoverImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string AuthorName { get; set; }
        public string AuthorImageUrl { get; set; }
        public string AuthorDescription { get; set; }
        public string Description { get; set; }

    }
}

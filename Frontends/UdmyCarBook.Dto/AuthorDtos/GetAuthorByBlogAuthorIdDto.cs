﻿namespace UdmyCarBook.Dto.AuthorDtos
{
    public class GetAuthorByBlogAuthorIdDto
    {
        public int BlogID { get; set; }
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public string AuthorImageUrl { get; set; }
        public string AuthorDescription { get; set; }
    }
}

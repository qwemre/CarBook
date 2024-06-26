﻿namespace UdemyCarBook.Domain.Entities
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
        public Blog Blog { get; set; }
        public int BlogID { get; set; }
        public string Email { get; set; }
    }
}

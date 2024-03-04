namespace UdmyCarBook.Dto.Comment
{
    public class ResultCommentDto
    {
        public int CommentId { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
        public int BlogID { get; set; }
    }
}

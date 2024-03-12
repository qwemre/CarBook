namespace UdmyCarBook.Dto.Comment
{
    public class CreateCommentDto
    {
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
        public int BlogID { get; set; }
        public string Email { get; set; }
    }
}

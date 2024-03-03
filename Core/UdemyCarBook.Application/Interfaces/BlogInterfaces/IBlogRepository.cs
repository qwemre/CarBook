using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces.BlogInterfaces
{
    public interface IBlogRepository
    {
        public List<Blog> GetLast3BlogWithAuthors();
        public List<Blog> GetAllBlogWithAuthors();
        public List<Blog> GetBlogByAuthorId(int id);


    }
}

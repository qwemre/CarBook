﻿using UdemyCarBook.Application.Features.RepositoryPattern;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistence.Context;

namespace UdemyCarBook.Persistence.Repositories.CommentRepositories
{
    public class CommentRepository<T> : IGenericRepository<Comment>
    {
        private readonly CarBookContext _context;

        public CommentRepository(CarBookContext context)
        {
            _context = context;
        }

        public void Create(Comment entity)
        {
            _context.Comments.Add(entity);
            _context.SaveChanges();
        }

        public List<Comment> GetAll()
        {
            return _context.Comments.Select(x => new Comment
            {
                CommentId = x.CommentId,
                BlogID = x.BlogID,
                CreateDate = x.CreateDate,
                Description = x.Description,
                Name = x.Name
            }).ToList();

        }

        public Comment GetById(int id)
        {
            return _context.Comments.Find(id);
        }

        public List<Comment> GetCommentByBlogId(int id)
        {
            return _context.Set<Comment>().Where(x => x.BlogID == id).ToList();
        }

        public void Remove(Comment comment)
        {
            var value = _context.Comments.Find(comment.CommentId);
            _context.Comments.Remove(value);
            _context.SaveChanges();
        }

        public void Update(Comment entity)
        {
            _context.Comments.Update(entity);
            _context.SaveChanges();
        }

        public int GetCountCommentByBlog(int id)
        {
            return _context.Comments.Where(x => x.BlogID == id).Count();
        }
    }
}

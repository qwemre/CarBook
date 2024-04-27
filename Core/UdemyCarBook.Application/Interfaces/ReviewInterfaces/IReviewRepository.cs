﻿using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces.ReviewInterfaces
{
    public interface IReviewRepository
    {
        public List<Review> GetReviewsByCarId(int carId);
    }
}
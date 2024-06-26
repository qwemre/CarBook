﻿using Microsoft.EntityFrameworkCore;
using UdemyCarBook.Application.Interfaces.CarDescriptionInterfaces;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistence.Context;

namespace UdemyCarBook.Persistence.Repositories.CarDescriptionRepositories
{
    public class CarDescriptionRepository : ICarDescriptionRepository
    {
        private readonly CarBookContext _context;

        public CarDescriptionRepository(CarBookContext context)
        {
            _context = context;
        }

        async Task<CarDescripotion> ICarDescriptionRepository.GetCarDescription(int carId)
        {
            var values = await _context.CarDescripotions.Where(x => x.CarID == carId).FirstOrDefaultAsync();
            return values;
        }
    }
}
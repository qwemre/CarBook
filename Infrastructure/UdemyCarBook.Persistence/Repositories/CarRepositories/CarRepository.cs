﻿using Microsoft.EntityFrameworkCore;
using UdemyCarBook.Application.Interfaces.CarInterfaces;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistence.Context;

namespace UdemyCarBook.Persistence.Repositories.CarRepositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarBookContext _context;

        public CarRepository(CarBookContext context)
        {
            _context = context;
        }

        public int GetCarCount()
        {
            var values = _context.Cars.Count();
            return values;
        }

        public List<Car> GetCarsListWithBrands()
        {
            var values = _context.Cars.Include(x => x.Brand).ToList();
            return values;
        }
        public List<Car> GetLast5CarsWithBrands()
        {
            var values = _context.Cars.Include(x => x.Brand).OrderByDescending(x => x.BrandID).Take(5).ToList();
            return values;
        }
    }
}

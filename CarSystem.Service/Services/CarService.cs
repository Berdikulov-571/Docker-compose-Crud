using AppartmentSystem.DataAccess.DataContexts;
using CarSystem.Domain.Entities;
using CarSystem.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CarSystem.Service.Services
{
    public class CarService : ICarRepository
    {
        private readonly ApplicationDbContext _context;

        public CarService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async ValueTask CreateAsync(CarModel model)
        {
            await _context.Cars.AddAsync(model);
            await _context.SaveChangesAsync();
        }

        public async ValueTask DeleteAsync(int CarId)
        {
            CarModel? car = await _context.Cars.FirstOrDefaultAsync(x => x.CartId == CarId);

            if (car != null)
            {
                _context.Cars.Remove(car);
                await _context.SaveChangesAsync();
            }
        }

        public async ValueTask<IEnumerable<CarModel>> GetAllAsync()
        {
            IEnumerable<CarModel> cars = await _context.Cars.ToListAsync();

            return cars;
        }
    }
}

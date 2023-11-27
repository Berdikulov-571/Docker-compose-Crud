using AppartmentSystem.DataAccess.DataContexts;
using AppartmentSystem.Domain.Entities;
using AppartmentSystem.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AppartmentSystem.Service.Services
{
    public class AppartmentService : IAppartmentRepository
    {
        private readonly ApplicationDbContext _context;

        public AppartmentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async ValueTask CreateAsync(AppartmentModel model)
        {
            await _context.Appartments.AddAsync(model);
            await _context.SaveChangesAsync();
        }

        public async ValueTask DeleteAsync(int appartmentId)
        {
            AppartmentModel? model = await _context.Appartments.FirstOrDefaultAsync(x => x.Id == appartmentId);

            if (model != null)
            {
                _context.Appartments.Remove(model);
                await _context.SaveChangesAsync();
            }
        }

        public async ValueTask<IEnumerable<AppartmentModel>> GetAllAsync()
        {
            IEnumerable<AppartmentModel> models = await _context.Appartments.ToListAsync();

            return models;
        }
    }
}

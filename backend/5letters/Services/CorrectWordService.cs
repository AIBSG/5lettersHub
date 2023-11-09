using _5letters.Data;
using _5letters.Dtos;
using _5letters.Models;
using Microsoft.EntityFrameworkCore;

namespace _5letters.Services
{
    public class CorrectWordService : ICorrectWordService
    {
        private readonly AppDbContext _context;

        public CorrectWordService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<CorrectWord> AddCorrectWord(CreateCorrectWordRequest request)
        {
            var word = new CorrectWord()
            {
                Word = request.Word,
            };

            var wordEntry = await _context.Set<CorrectWord>().AddAsync(word);
            await _context.SaveChangesAsync();

            return wordEntry.Entity;
        }

        public async Task<CorrectWord> GetCurrentWord()
        {
            var date = DateTimeOffset.UtcNow;
            var words = await _context.Set<CorrectWord>().ToListAsync();
            var date11 = words.FirstOrDefault().Date.Date == date.Date;

            return words.FirstOrDefault();
        }
    }
}

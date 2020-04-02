using System.Collections.Generic;
using System.Linq;
using DigitalLibraryApplication.Models;

namespace DigitalLibraryApplication.Services
{
    public class AudioBookService : IAudioBookService
    {
        private readonly DigitalLibraryContext _context;

        public AudioBookService(DigitalLibraryContext context)
        {
            _context = context;
        }

        public IEnumerable<AudioBook> GetAll()
        {
              return _context.AudioBooks.ToList();
            //throw new System.NotImplementedException();
        }
    }
}

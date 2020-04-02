using DigitalLibraryApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalLibraryApplication.Services
{
    public interface IAudioBookService
    {
        IEnumerable<AudioBook> GetAll();
    }
}

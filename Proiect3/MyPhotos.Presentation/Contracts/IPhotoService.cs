using System.Collections.Generic;
using System.Threading.Tasks;
using MyPhotos.Presentation.Models;

namespace MyPhotos.Presentation.Contracts
{
    public interface IPhotoService
    {
        Task<ICollection<Photo>> GetFilterPhotos(string name, string type, string eventName, string place, string person);
    }
}

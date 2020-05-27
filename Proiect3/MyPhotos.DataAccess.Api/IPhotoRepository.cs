using System.Collections.Generic;
using MyPhotos.DataAccess.Model.Models;

namespace MyPhotos.DataAccess.Api
{
    public interface IPhotoRepository : IRepository<Photos>
    {
        ICollection<Photos> GetFilterPhotos(string name, string type, string eventName, string place, string person);
    }
}

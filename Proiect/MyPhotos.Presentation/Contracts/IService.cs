using System.Collections.Generic;

namespace MyPhotos.Presentation.Contracts
{
    public interface IService<T>
        where T : class
    {
        ICollection<T> GetAll();
    }
}

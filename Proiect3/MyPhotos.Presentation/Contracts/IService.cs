using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPhotos.Presentation.Contracts
{
    public interface IService<T>
        where T : class
    {
        Task<ICollection<string>> GetAllNames();
    }
}

using System;
using System.Collections.Generic;

namespace MyPhotos.DataAccess.Api
{
    public interface IRepository<T>
        where T : class
    {
        void Add(T entity);

        ICollection<T> GetAll();

        T GetById(Guid id);

        void Update(T oldEntity, T newEntity);

        void Delete(Guid id);
    }
}

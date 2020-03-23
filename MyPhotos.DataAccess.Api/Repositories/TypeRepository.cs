using MyPhotos.DataAccess.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;

using Type = MyPhotos.DataAccess.Model.Models.Type;

namespace MyPhotos.DataAccess.Api.Repositories
{
    public sealed class TypeRepository : IRepository<Type>
    {
        private readonly MyPhotosModelContainer _container;

        public TypeRepository(MyPhotosModelContainer container)
        {
            _container = container;
        }

        public void Add(Type entity)
        {
            _container.Types.Add(entity);
            _container.SaveChanges();
        }

        public ICollection<Type> GetAll()
        {
            return _container.Types.ToList();
        }

        public Type GetById(Guid id)
        {
            return _container.Types.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Type oldEntity, Type newEntity)
        {
            var old = _container.Types.FirstOrDefault(x => x.Id == oldEntity.Id);
            if (old != null)
            {
                old.Name = newEntity.Name;
            }

            _container.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var type = _container.Types.FirstOrDefault(x => x.Id == id);
            if(type != null)
            {
                _container.Types.Remove(type);
            }

            _container.SaveChanges();
        }
    }
}

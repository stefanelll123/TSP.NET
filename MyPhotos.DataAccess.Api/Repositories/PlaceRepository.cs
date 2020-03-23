using MyPhotos.DataAccess.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPhotos.DataAccess.Api.Repositories
{
    public sealed class PlaceRepository : IRepository<Places>
    {
        private readonly MyPhotosModelContainer _container;

        public PlaceRepository(MyPhotosModelContainer container)
        {
            _container = container;
        }

        public void Add(Places entity)
        {
            _container.Places.Add(entity);
            _container.SaveChanges();
        }

        public ICollection<Places> GetAll()
        {
            return _container.Places.ToList();
        }

        public Places GetById(Guid id)
        {
            return _container.Places.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Places oldEntity, Places newEntity)
        {
            var old = _container.Places.FirstOrDefault(x => x.Id == oldEntity.Id);
            if (old != null)
            {
                old.Name = newEntity.Name;
            }

            _container.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var entity = _container.Places.FirstOrDefault(x => x.Id == id);
            if(entity != null)
            {
                _container.Places.Remove(entity);
            }

            _container.SaveChanges();
        }
    }
}

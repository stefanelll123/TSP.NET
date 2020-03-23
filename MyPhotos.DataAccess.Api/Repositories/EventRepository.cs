using MyPhotos.DataAccess.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPhotos.DataAccess.Api.Repositories
{
    public sealed class EventRepository : IRepository<Event>
    {
        private readonly MyPhotosModelContainer _container;

        public EventRepository(MyPhotosModelContainer container)
        {
            _container = container;
        }

        public void Add(Event entity)
        {
            _container.Events.Add(entity);
            _container.SaveChanges();
        }

        public ICollection<Event> GetAll()
        {
            return _container.Events.ToList();
        }

        public Event GetById(Guid id)
        {
            return _container.Events.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Event oldEntity, Event newEntity)
        {
            var old = _container.Events.FirstOrDefault(x => x.Id == oldEntity.Id);
            if (old != null)
            {
                old.Name = newEntity.Name;
            }

            _container.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var entity = _container.Events.FirstOrDefault(x => x.Id == id);
            if(entity != null)
            {
                _container.Events.Remove(entity);
            }

            _container.SaveChanges();
        }
    }
}

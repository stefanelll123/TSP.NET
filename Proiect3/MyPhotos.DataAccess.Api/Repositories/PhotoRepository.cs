using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using MyPhotos.DataAccess.Model.Models;

namespace MyPhotos.DataAccess.Api.Repositories
{
    public class PhotoRepository : IPhotoRepository
    {
        private readonly MyPhotosModelContainer _container;

        public PhotoRepository()
        {
            _container = new MyPhotosModelContainer();
        }

        public void Add(Photos entity)
        {
            _container.Photos.Add(entity);
            _container.SaveChanges();
        }

        public ICollection<Photos> GetAll()
        {
            return _container.Photos.ToList();
        }

        public Photos GetById(Guid id)
        {
            return _container.Photos.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Photos oldEntity, Photos newEntity)
        {
            var old = _container.Photos.FirstOrDefault(x => x.Id == oldEntity.Id);
            if (old != null)
            {
                newEntity.Id = old.Id;
                _container.Photos.AddOrUpdate(newEntity);
            }

            _container.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var entity = _container.Photos.FirstOrDefault(x => x.Id == id);
            if (entity != null)
            {
                _container.Photos.Remove(entity);
            }

            _container.SaveChanges();
        }

        public ICollection<Photos> GetFilterPhotos(string name, string type, string eventName, string place, string person)
        {
            return _container.Photos.ToList().Where(x => IsSelected(x, name, type, eventName, place, person)).ToList();
        }

        private bool IsSelected(Photos photo, string name, string type, string eventName, string place, string person)
        {
            return (name == null || photo.Name.ToLower().Contains(name.ToLower())) &&
                   (eventName == null ||
                    photo.Event.Name.ToLower().Contains(eventName.ToLower())) &&
                   (type == null || photo.Types.Select(y => y.Name.ToLower())
                        .FirstOrDefault(y => y.Contains(type.ToLower())) != null) &&
                   (person == null ||
                    photo.People.Select(y => $"{y.FirstName.ToLower()} {y.LastName.ToLower()}")
                        .FirstOrDefault(y => y.Contains(person.ToLower())) != null) &&
                   (place == null || photo.Places.Select(y => y.Name)
                        .FirstOrDefault(y => y.Contains(place.ToLower())) != null);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using MyPhotos.DataAccess.Model.Models;

namespace MyPhotos.WcfServices.Services
{
    public partial class ServiceImplementation
    {
        public void AddPhoto(Photos entity)
        {
            _photoRepository.Add(entity);
        }

        public ICollection<Photos> GetAllPhotos()
        {
            return _photoRepository.GetAll();
        }

        public ICollection<PhotoModel> GetFilterPhotos(string name, string type, string eventName, string place, string person)
        {
            return _photoRepository.GetFilterPhotos(name, type, eventName, place, person)
                .Select(x => new PhotoModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Path = x.Path,
                    IsDeleted = x.IsDeleted,
                    CreationDate = x.CreationDate,
                    Types = x.Types.Select(y => y.Name).ToList(),
                    Event = x.Event.Name,
                    Places = x.Places.Select(y => y.Name).ToList(),
                    People = x.People.Select(y => $"{y.FirstName} {y.LastName}").ToList()
                }).ToList();
        }

        public Photos GetPhotoById(Guid id)
        {
            return _photoRepository.GetById(id);
        }

        public void UpdatePhoto(Photos oldEntity, Photos newEntity)
        {
            _photoRepository.Update(oldEntity, newEntity);
        }

        public void DeletePhoto(Guid id)
        {
            _photoRepository.Delete(id);
        }
    }
}
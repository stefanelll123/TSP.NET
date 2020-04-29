using System;
using System.Collections.Generic;

using MyPhotos.DataAccess.Model.Models;
using MyPhotos.WcfServices.Contracts;

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
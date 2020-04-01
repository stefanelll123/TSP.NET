using System;
using System.Collections.Generic;

using MyPhotos.DataAccess.Model.Models;
using MyPhotos.WcfServices.Contracts;

namespace MyPhotos.WcfServices.Services
{
    public partial class ServiceImplementation : IPhotoService
    {
        void IPhotoService.Add(Photos entity)
        {
            _photoRepository.Add(entity);
        }

        ICollection<Photos> IPhotoService.GetAll()
        {
            return _photoRepository.GetAll();
        }

        Photos IPhotoService.GetById(Guid id)
        {
            return _photoRepository.GetById(id);
        }

        void IPhotoService.Update(Photos oldEntity, Photos newEntity)
        {
            _photoRepository.Update(oldEntity, newEntity);
        }

        void IPhotoService.Delete(Guid id)
        {
            _photoRepository.Delete(id);
        }
    }
}
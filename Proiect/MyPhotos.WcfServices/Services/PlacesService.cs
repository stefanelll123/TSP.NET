using System;
using System.Collections.Generic;

using MyPhotos.DataAccess.Model.Models;
using MyPhotos.WcfServices.Contracts;

namespace MyPhotos.WcfServices.Services
{
    public partial class ServiceImplementation : IPlaceService
    {
        void IPlaceService.Add(Places entity)
        {
            _placeRepository.Add(entity);
        }

        ICollection<Places> IPlaceService.GetAll()
        {
            return _placeRepository.GetAll();
        }
        
        Places IPlaceService.GetById(Guid id)
        {
            return _placeRepository.GetById(id);
        }

        void IPlaceService.Update(Places oldEntity, Places newEntity)
        {
            _placeRepository.Update(oldEntity, newEntity);
        }

        void IPlaceService.Delete(Guid id)
        {
            _placeRepository.Delete(id);
        }
    }
}
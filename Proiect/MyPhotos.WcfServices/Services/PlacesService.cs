using System;
using System.Collections.Generic;

using MyPhotos.DataAccess.Model.Models;
using MyPhotos.WcfServices.Contracts;

namespace MyPhotos.WcfServices.Services
{
    public partial class ServiceImplementation
    {
        public void AddPlace(Places entity)
        {
            _placeRepository.Add(entity);
        }

        public ICollection<Places> GetAllPlaces()
        {
            return _placeRepository.GetAll();
        }

        public Places GetPlaceById(Guid id)
        {
            return _placeRepository.GetById(id);
        }

        public void UpdatePlace(Places oldEntity, Places newEntity)
        {
            _placeRepository.Update(oldEntity, newEntity);
        }

        public void DeletePlace(Guid id)
        {
            _placeRepository.Delete(id);
        }
    }
}
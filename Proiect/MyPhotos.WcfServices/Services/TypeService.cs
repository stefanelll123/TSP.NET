using System;
using System.Collections.Generic;

using MyPhotos.WcfServices.Contracts;

using Type = MyPhotos.DataAccess.Model.Models.Type;

namespace MyPhotos.WcfServices.Services
{
    public partial class ServiceImplementation
    {
        public void AddType(Type entity)
        {
            _typeRepository.Add(entity);
        }

        public ICollection<Type> GetAllTypes()
        {
            return _typeRepository.GetAll();
        }

        public Type GetTypeById(Guid id)
        {
            return _typeRepository.GetById(id);
        }

        public void UpdateType(Type oldEntity, Type newEntity)
        {
            _typeRepository.Update(oldEntity, newEntity);
        }

        public void DeleteType(Guid id)
        {
            _typeRepository.Delete(id);
        }
    }
}
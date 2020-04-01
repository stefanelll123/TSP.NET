using System;
using System.Collections.Generic;

using MyPhotos.WcfServices.Contracts;

using Type = MyPhotos.DataAccess.Model.Models.Type;

namespace MyPhotos.WcfServices.Services
{
    public partial class ServiceImplementation : ITypeService
    {
        public void Add(Type entity)
        {
            _typeRepository.Add(entity);
        }

        ICollection<Type> ITypeService.GetAll()
        {
            return _typeRepository.GetAll();
        }

        Type ITypeService.GetById(Guid id)
        {
            return _typeRepository.GetById(id);
        }

        void ITypeService.Update(Type oldEntity, Type newEntity)
        {
            _typeRepository.Update(oldEntity, newEntity);
        }

        void ITypeService.Delete(Guid id)
        {
            _typeRepository.Delete(id);
        }
    }
}
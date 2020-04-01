using System;
using System.Collections.Generic;

using MyPhotos.DataAccess.Model.Models;
using MyPhotos.WcfServices.Contracts;

namespace MyPhotos.WcfServices.Services
{
    public partial class ServiceImplementation : IPersonService
    {
        void IPersonService.Add(Person entity)
        {
            _personRepository.Add(entity);
        }

        ICollection<Person> IPersonService.GetAll()
        {
            return _personRepository.GetAll();
        }

        Person IPersonService.GetById(Guid id)
        {
            return _personRepository.GetById(id);
        }

        void IPersonService.Update(Person oldEntity, Person newEntity)
        {
            _personRepository.Update(oldEntity, newEntity);
        }

        void IPersonService.Delete(Guid id)
        {
            _personRepository.Delete(id);
        }
    }
}
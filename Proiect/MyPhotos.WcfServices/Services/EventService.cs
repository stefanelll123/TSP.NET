using System;
using System.Collections.Generic;

using MyPhotos.DataAccess.Model.Models;
using MyPhotos.WcfServices.Contracts;

namespace MyPhotos.WcfServices.Services
{
    public partial class ServiceImplementation : IEventService
    {
        void IEventService.Add(Event entity)
        {
            _eventRepository.Add(entity);
        }

        ICollection<Event> IEventService.GetAll()
        {
            return _eventRepository.GetAll();
        }

        Event IEventService.GetById(Guid id)
        {
            return _eventRepository.GetById(id);
        }

        void IEventService.Update(Event oldEntity, Event newEntity)
        {
            _eventRepository.Update(oldEntity, newEntity);
        }

        void IEventService.Delete(Guid id)
        {
            _eventRepository.Delete(id);
        }
    }
}
﻿using System;
using System.Collections.Generic;

using MyPhotos.DataAccess.Model.Models;

namespace MyPhotos.WcfServices.Services
{
    public partial class ServiceImplementation
    {
        public void AddEvent(Event entity)
        {
            _eventRepository.Add(entity);
        }

        public ICollection<Event> GetAllEvents()
        {
            return _eventRepository.GetAll();
        }

        public Event GetEventById(Guid id)
        {
            return _eventRepository.GetById(id);
        }

        public void UpdateEvent(Event oldEntity, Event newEntity)
        {
            _eventRepository.Update(oldEntity, newEntity);
        }

        public void DeleteEvent(Guid id)
        {
            _eventRepository.Delete(id);
        }
    }
}
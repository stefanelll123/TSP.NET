using System;
using System.Collections.Generic;
using System.ServiceModel;
using MyPhotos.DataAccess.Model.Models;

namespace MyPhotos.WcfServices.Contracts
{
    public partial interface IServiceImplementation
    {
        [OperationContract]
        void AddEvent(Event entity);

        [OperationContract]
        ICollection<Event> GetAllEvents();

        [OperationContract]
        ICollection<string> GetAllEventsName();

        [OperationContract]
        Event GetEventById(Guid id);

        [OperationContract]
        void UpdateEvent(Event oldEntity, Event newEntity);

        [OperationContract]
        void DeleteEvent(Guid id);
    }
}
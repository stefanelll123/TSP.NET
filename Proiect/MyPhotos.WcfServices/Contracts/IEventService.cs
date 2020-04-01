using System;
using System.Collections.Generic;
using System.ServiceModel;
using MyPhotos.DataAccess.Model.Models;

namespace MyPhotos.WcfServices.Contracts
{
    [ServiceContract]
    public interface IEventService
    {
        [OperationContract]
        void Add(Event entity);

        [OperationContract]
        ICollection<Event> GetAll();

        [OperationContract]
        Event GetById(Guid id);

        [OperationContract]
        void Update(Event oldEntity, Event newEntity);

        [OperationContract]
        void Delete(Guid id);
    }
}
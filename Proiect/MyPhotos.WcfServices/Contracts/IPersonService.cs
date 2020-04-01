using System;
using System.Collections.Generic;
using System.ServiceModel;
using MyPhotos.DataAccess.Model.Models;

namespace MyPhotos.WcfServices.Contracts
{
    [ServiceContract]
    public interface IPersonService
    {
        [OperationContract]
        void Add(Person entity);

        [OperationContract]
        ICollection<Person> GetAll();

        [OperationContract]
        Person GetById(Guid id);

        [OperationContract]
        void Update(Person oldEntity, Person newEntity);

        [OperationContract]
        void Delete(Guid id);
    }
}
using System;
using System.Collections.Generic;
using System.ServiceModel;
using MyPhotos.DataAccess.Model.Models;

namespace MyPhotos.WcfServices.Contracts
{
    public partial interface IServiceImplementation
    {
        [OperationContract]
        void AddPerson(Person entity);

        [OperationContract]
        ICollection<Person> GetAllPersons();

        [OperationContract]
        ICollection<string> GetAllPersonsNames();

        [OperationContract]
        Person GetPersonById(Guid id);

        [OperationContract]
        void UpdatePerson(Person oldEntity, Person newEntity);

        [OperationContract]
        void DeletePerson(Guid id);
    }
}
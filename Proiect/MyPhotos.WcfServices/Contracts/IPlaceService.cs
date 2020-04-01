using System;
using System.Collections.Generic;
using System.ServiceModel;
using MyPhotos.DataAccess.Model.Models;

namespace MyPhotos.WcfServices.Contracts
{
    [ServiceContract]
    public interface IPlaceService
    {
        [OperationContract]
        void Add(Places entity);

        [OperationContract]
        ICollection<Places> GetAll();

        [OperationContract]
        Places GetById(Guid id);

        [OperationContract]
        void Update(Places oldEntity, Places newEntity);

        [OperationContract]
        void Delete(Guid id);
    }
}
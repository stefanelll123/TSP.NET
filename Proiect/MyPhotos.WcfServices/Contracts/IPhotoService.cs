using System;
using System.Collections.Generic;
using System.ServiceModel;
using MyPhotos.DataAccess.Model.Models;

namespace MyPhotos.WcfServices.Contracts
{
    [ServiceContract]
    public interface IPhotoService
    {
        [OperationContract]
        void Add(Photos entity);

        [OperationContract]
        ICollection<Photos> GetAll();

        [OperationContract]
        Photos GetById(Guid id);

        [OperationContract]
        void Update(Photos oldEntity, Photos newEntity);

        [OperationContract]
        void Delete(Guid id);
    }
}
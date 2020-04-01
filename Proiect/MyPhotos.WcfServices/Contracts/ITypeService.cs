using System;
using System.Collections.Generic;
using System.ServiceModel;
using Type = MyPhotos.DataAccess.Model.Models.Type;

namespace MyPhotos.WcfServices.Contracts
{
    [ServiceContract]
    public interface ITypeService
    {
        [OperationContract]
        void Add(Type entity);

        [OperationContract]
        ICollection<Type> GetAll();

        [OperationContract]
        Type GetById(Guid id);

        [OperationContract]
        void Update(Type oldEntity, Type newEntity);

        [OperationContract]
        void Delete(Guid id);
    }
}
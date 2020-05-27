using System;
using System.Collections.Generic;
using System.ServiceModel;
using Type = MyPhotos.DataAccess.Model.Models.Type;

namespace MyPhotos.WcfServices.Contracts
{
    public partial interface IServiceImplementation
    {
        [OperationContract]
        void AddType(Type entity);

        [OperationContract]
        ICollection<Type> GetAllTypes();

        [OperationContract]
        ICollection<string> GetAllTypesNames();

        [OperationContract]
        Type GetTypeById(Guid id);

        [OperationContract]
        void UpdateType(Type oldEntity, Type newEntity);

        [OperationContract]
        void DeleteType(Guid id);
    }
}
using System;
using System.Collections.Generic;
using System.ServiceModel;
using MyPhotos.DataAccess.Model.Models;

namespace MyPhotos.WcfServices.Contracts
{
    public partial interface IServiceImplementation
    {
        [OperationContract]
        void AddPlace(Places entity);

        [OperationContract]
        ICollection<Places> GetAllPlaces();

        [OperationContract]
        Places GetPlaceById(Guid id);

        [OperationContract]
        void UpdatePlace(Places oldEntity, Places newEntity);

        [OperationContract]
        void DeletePlace(Guid id);
    }
}
using System;
using System.Collections.Generic;
using System.ServiceModel;
using MyPhotos.DataAccess.Model.Models;

namespace MyPhotos.WcfServices.Contracts
{
    public partial interface IServiceImplementation
    {
        [OperationContract]
        void AddPhoto(Photos entity);

        [OperationContract]
        ICollection<Photos> GetAllPhotos();

        [OperationContract]
        ICollection<PhotoModel> GetFilterPhotos(string name, string type, string eventName, string place, string person);

        [OperationContract]
        Photos GetPhotoById(Guid id);

        [OperationContract]
        void UpdatePhoto(Photos oldEntity, Photos newEntity);

        [OperationContract]
        void DeletePhoto(Guid id);
    }
}
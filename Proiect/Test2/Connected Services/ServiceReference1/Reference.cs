﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Event", Namespace="http://schemas.datacontract.org/2004/07/MyPhotos.DataAccess.Model.Models", IsReference=true)]
    public partial class Event : object
    {
        
        private System.Guid IdField;
        
        private string NameField;
        
        private ServiceReference1.Photos[] PhotosField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Photos[] Photos
        {
            get
            {
                return this.PhotosField;
            }
            set
            {
                this.PhotosField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Photos", Namespace="http://schemas.datacontract.org/2004/07/MyPhotos.DataAccess.Model.Models", IsReference=true)]
    public partial class Photos : object
    {
        
        private System.DateTime CreationDateField;
        
        private ServiceReference1.Event EventField;
        
        private System.Guid IdField;
        
        private bool IsDeletedField;
        
        private string NameField;
        
        private string PathField;
        
        private ServiceReference1.Person[] PeopleField;
        
        private ServiceReference1.Places[] PlacesField;
        
        private ServiceReference1.Type[] TypesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreationDate
        {
            get
            {
                return this.CreationDateField;
            }
            set
            {
                this.CreationDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Event Event
        {
            get
            {
                return this.EventField;
            }
            set
            {
                this.EventField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsDeleted
        {
            get
            {
                return this.IsDeletedField;
            }
            set
            {
                this.IsDeletedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Path
        {
            get
            {
                return this.PathField;
            }
            set
            {
                this.PathField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Person[] People
        {
            get
            {
                return this.PeopleField;
            }
            set
            {
                this.PeopleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Places[] Places
        {
            get
            {
                return this.PlacesField;
            }
            set
            {
                this.PlacesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Type[] Types
        {
            get
            {
                return this.TypesField;
            }
            set
            {
                this.TypesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/MyPhotos.DataAccess.Model.Models")]
    public partial class Person : object
    {
        
        private string FirstNameField;
        
        private System.Guid IdField;
        
        private string LastNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName
        {
            get
            {
                return this.FirstNameField;
            }
            set
            {
                this.FirstNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName
        {
            get
            {
                return this.LastNameField;
            }
            set
            {
                this.LastNameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Places", Namespace="http://schemas.datacontract.org/2004/07/MyPhotos.DataAccess.Model.Models", IsReference=true)]
    public partial class Places : object
    {
        
        private System.Guid IdField;
        
        private string NameField;
        
        private ServiceReference1.Photos[] PhotosField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Photos[] Photos
        {
            get
            {
                return this.PhotosField;
            }
            set
            {
                this.PhotosField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Type", Namespace="http://schemas.datacontract.org/2004/07/MyPhotos.DataAccess.Model.Models", IsReference=true)]
    public partial class Type : object
    {
        
        private System.Guid IdField;
        
        private string NameField;
        
        private ServiceReference1.Photos[] PhotosField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Photos[] Photos
        {
            get
            {
                return this.PhotosField;
            }
            set
            {
                this.PhotosField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IServiceImplementation")]
    public interface IServiceImplementation
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImplementation/AddEvent", ReplyAction="http://tempuri.org/IServiceImplementation/AddEventResponse")]
        System.Threading.Tasks.Task AddEventAsync(ServiceReference1.Event entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImplementation/GetAllEvents", ReplyAction="http://tempuri.org/IServiceImplementation/GetAllEventsResponse")]
        System.Threading.Tasks.Task<ServiceReference1.Event[]> GetAllEventsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImplementation/GetEventById", ReplyAction="http://tempuri.org/IServiceImplementation/GetEventByIdResponse")]
        System.Threading.Tasks.Task<ServiceReference1.Event> GetEventByIdAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImplementation/UpdateEvent", ReplyAction="http://tempuri.org/IServiceImplementation/UpdateEventResponse")]
        System.Threading.Tasks.Task UpdateEventAsync(ServiceReference1.Event oldEntity, ServiceReference1.Event newEntity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImplementation/DeleteEvent", ReplyAction="http://tempuri.org/IServiceImplementation/DeleteEventResponse")]
        System.Threading.Tasks.Task DeleteEventAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImplementation/AddPerson", ReplyAction="http://tempuri.org/IServiceImplementation/AddPersonResponse")]
        System.Threading.Tasks.Task AddPersonAsync(ServiceReference1.Person entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImplementation/GetAllPersons", ReplyAction="http://tempuri.org/IServiceImplementation/GetAllPersonsResponse")]
        System.Threading.Tasks.Task<ServiceReference1.Person[]> GetAllPersonsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImplementation/GetPersonById", ReplyAction="http://tempuri.org/IServiceImplementation/GetPersonByIdResponse")]
        System.Threading.Tasks.Task<ServiceReference1.Person> GetPersonByIdAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImplementation/UpdatePerson", ReplyAction="http://tempuri.org/IServiceImplementation/UpdatePersonResponse")]
        System.Threading.Tasks.Task UpdatePersonAsync(ServiceReference1.Person oldEntity, ServiceReference1.Person newEntity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImplementation/DeletePerson", ReplyAction="http://tempuri.org/IServiceImplementation/DeletePersonResponse")]
        System.Threading.Tasks.Task DeletePersonAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImplementation/AddPhoto", ReplyAction="http://tempuri.org/IServiceImplementation/AddPhotoResponse")]
        System.Threading.Tasks.Task AddPhotoAsync(ServiceReference1.Photos entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImplementation/GetAllPhotos", ReplyAction="http://tempuri.org/IServiceImplementation/GetAllPhotosResponse")]
        System.Threading.Tasks.Task<ServiceReference1.Photos[]> GetAllPhotosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImplementation/GetPhotoById", ReplyAction="http://tempuri.org/IServiceImplementation/GetPhotoByIdResponse")]
        System.Threading.Tasks.Task<ServiceReference1.Photos> GetPhotoByIdAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImplementation/UpdatePhoto", ReplyAction="http://tempuri.org/IServiceImplementation/UpdatePhotoResponse")]
        System.Threading.Tasks.Task UpdatePhotoAsync(ServiceReference1.Photos oldEntity, ServiceReference1.Photos newEntity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImplementation/DeletePhoto", ReplyAction="http://tempuri.org/IServiceImplementation/DeletePhotoResponse")]
        System.Threading.Tasks.Task DeletePhotoAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImplementation/AddPlace", ReplyAction="http://tempuri.org/IServiceImplementation/AddPlaceResponse")]
        System.Threading.Tasks.Task AddPlaceAsync(ServiceReference1.Places entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImplementation/GetAllPlaces", ReplyAction="http://tempuri.org/IServiceImplementation/GetAllPlacesResponse")]
        System.Threading.Tasks.Task<ServiceReference1.Places[]> GetAllPlacesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImplementation/GetPlaceById", ReplyAction="http://tempuri.org/IServiceImplementation/GetPlaceByIdResponse")]
        System.Threading.Tasks.Task<ServiceReference1.Places> GetPlaceByIdAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImplementation/UpdatePlace", ReplyAction="http://tempuri.org/IServiceImplementation/UpdatePlaceResponse")]
        System.Threading.Tasks.Task UpdatePlaceAsync(ServiceReference1.Places oldEntity, ServiceReference1.Places newEntity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImplementation/DeletePlace", ReplyAction="http://tempuri.org/IServiceImplementation/DeletePlaceResponse")]
        System.Threading.Tasks.Task DeletePlaceAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImplementation/AddType", ReplyAction="http://tempuri.org/IServiceImplementation/AddTypeResponse")]
        System.Threading.Tasks.Task AddTypeAsync(ServiceReference1.Type entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImplementation/GetAllTypes", ReplyAction="http://tempuri.org/IServiceImplementation/GetAllTypesResponse")]
        System.Threading.Tasks.Task<ServiceReference1.Type[]> GetAllTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImplementation/GetTypeById", ReplyAction="http://tempuri.org/IServiceImplementation/GetTypeByIdResponse")]
        System.Threading.Tasks.Task<ServiceReference1.Type> GetTypeByIdAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImplementation/UpdateType", ReplyAction="http://tempuri.org/IServiceImplementation/UpdateTypeResponse")]
        System.Threading.Tasks.Task UpdateTypeAsync(ServiceReference1.Type oldEntity, ServiceReference1.Type newEntity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImplementation/DeleteType", ReplyAction="http://tempuri.org/IServiceImplementation/DeleteTypeResponse")]
        System.Threading.Tasks.Task DeleteTypeAsync(System.Guid id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IServiceImplementationChannel : ServiceReference1.IServiceImplementation, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class ServiceImplementationClient : System.ServiceModel.ClientBase<ServiceReference1.IServiceImplementation>, ServiceReference1.IServiceImplementation
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ServiceImplementationClient() : 
                base(ServiceImplementationClient.GetDefaultBinding(), ServiceImplementationClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IServiceImplementation.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceImplementationClient(EndpointConfiguration endpointConfiguration) : 
                base(ServiceImplementationClient.GetBindingForEndpoint(endpointConfiguration), ServiceImplementationClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceImplementationClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ServiceImplementationClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceImplementationClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ServiceImplementationClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceImplementationClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task AddEventAsync(ServiceReference1.Event entity)
        {
            return base.Channel.AddEventAsync(entity);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.Event[]> GetAllEventsAsync()
        {
            return base.Channel.GetAllEventsAsync();
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.Event> GetEventByIdAsync(System.Guid id)
        {
            return base.Channel.GetEventByIdAsync(id);
        }
        
        public System.Threading.Tasks.Task UpdateEventAsync(ServiceReference1.Event oldEntity, ServiceReference1.Event newEntity)
        {
            return base.Channel.UpdateEventAsync(oldEntity, newEntity);
        }
        
        public System.Threading.Tasks.Task DeleteEventAsync(System.Guid id)
        {
            return base.Channel.DeleteEventAsync(id);
        }
        
        public System.Threading.Tasks.Task AddPersonAsync(ServiceReference1.Person entity)
        {
            return base.Channel.AddPersonAsync(entity);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.Person[]> GetAllPersonsAsync()
        {
            return base.Channel.GetAllPersonsAsync();
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.Person> GetPersonByIdAsync(System.Guid id)
        {
            return base.Channel.GetPersonByIdAsync(id);
        }
        
        public System.Threading.Tasks.Task UpdatePersonAsync(ServiceReference1.Person oldEntity, ServiceReference1.Person newEntity)
        {
            return base.Channel.UpdatePersonAsync(oldEntity, newEntity);
        }
        
        public System.Threading.Tasks.Task DeletePersonAsync(System.Guid id)
        {
            return base.Channel.DeletePersonAsync(id);
        }
        
        public System.Threading.Tasks.Task AddPhotoAsync(ServiceReference1.Photos entity)
        {
            return base.Channel.AddPhotoAsync(entity);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.Photos[]> GetAllPhotosAsync()
        {
            return base.Channel.GetAllPhotosAsync();
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.Photos> GetPhotoByIdAsync(System.Guid id)
        {
            return base.Channel.GetPhotoByIdAsync(id);
        }
        
        public System.Threading.Tasks.Task UpdatePhotoAsync(ServiceReference1.Photos oldEntity, ServiceReference1.Photos newEntity)
        {
            return base.Channel.UpdatePhotoAsync(oldEntity, newEntity);
        }
        
        public System.Threading.Tasks.Task DeletePhotoAsync(System.Guid id)
        {
            return base.Channel.DeletePhotoAsync(id);
        }
        
        public System.Threading.Tasks.Task AddPlaceAsync(ServiceReference1.Places entity)
        {
            return base.Channel.AddPlaceAsync(entity);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.Places[]> GetAllPlacesAsync()
        {
            return base.Channel.GetAllPlacesAsync();
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.Places> GetPlaceByIdAsync(System.Guid id)
        {
            return base.Channel.GetPlaceByIdAsync(id);
        }
        
        public System.Threading.Tasks.Task UpdatePlaceAsync(ServiceReference1.Places oldEntity, ServiceReference1.Places newEntity)
        {
            return base.Channel.UpdatePlaceAsync(oldEntity, newEntity);
        }
        
        public System.Threading.Tasks.Task DeletePlaceAsync(System.Guid id)
        {
            return base.Channel.DeletePlaceAsync(id);
        }
        
        public System.Threading.Tasks.Task AddTypeAsync(ServiceReference1.Type entity)
        {
            return base.Channel.AddTypeAsync(entity);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.Type[]> GetAllTypesAsync()
        {
            return base.Channel.GetAllTypesAsync();
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.Type> GetTypeByIdAsync(System.Guid id)
        {
            return base.Channel.GetTypeByIdAsync(id);
        }
        
        public System.Threading.Tasks.Task UpdateTypeAsync(ServiceReference1.Type oldEntity, ServiceReference1.Type newEntity)
        {
            return base.Channel.UpdateTypeAsync(oldEntity, newEntity);
        }
        
        public System.Threading.Tasks.Task DeleteTypeAsync(System.Guid id)
        {
            return base.Channel.DeleteTypeAsync(id);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IServiceImplementation))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IServiceImplementation))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8000/PC");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ServiceImplementationClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IServiceImplementation);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ServiceImplementationClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IServiceImplementation);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IServiceImplementation,
        }
    }
}

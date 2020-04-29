using MyPhotos.DataAccess.Api;
using MyPhotos.DataAccess.Api.Repositories;
using MyPhotos.DataAccess.Model.Models;
using MyPhotos.WcfServices.Contracts;

namespace MyPhotos.WcfServices.Services
{
    public partial class ServiceImplementation : IServiceImplementation
    {
        private readonly IRepository<Type> _typeRepository;
        private readonly IRepository<Places> _placeRepository;
        private readonly IRepository<Photos> _photoRepository;
        private readonly IRepository<Person> _personRepository;
        private readonly IRepository<Event> _eventRepository;

        public ServiceImplementation()
        {
            _typeRepository = new TypeRepository();
            _placeRepository = new PlaceRepository();
            _photoRepository = new PhotoRepository();
            _personRepository = new PersonRepository();
            _eventRepository = new EventRepository();
        }
    }
}
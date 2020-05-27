using Microsoft.Extensions.DependencyInjection;
using MyPhotos.Presentation.Contracts;
using MyPhotos.Presentation.Models;

namespace MyPhotos.Presentation.Data
{
    internal static class ServiceRegister
    {
        public static void RegisterServices(this IServiceCollection service)
        {
            service.AddTransient<IService<Person>, PersonsService>();
            service.AddTransient<IService<Type>, TypesService>();
            service.AddTransient<IService<Event>, EventsService>();
            service.AddTransient<IService<Place>, PlacesService>();
            service.AddTransient<IPhotoService, PhotosService>();
        }
    }
}

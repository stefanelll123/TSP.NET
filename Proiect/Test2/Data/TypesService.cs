using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyPhotos.Presentation.Contracts;

using Type = MyPhotos.Presentation.Models.Type;

namespace MyPhotos.Presentation.Data
{
    public class TypesService : IService<Type>
    {
        public Task<ICollection<Type>> GetAll()
        {
            //return new List<Type>
            //{
            //    new Type
            //    {
            //        Id = Guid.NewGuid(),
            //        Name = "Test"
            //    }
            //};

            return Task.FromResult((ICollection<Type>)null);
        }
    }
}

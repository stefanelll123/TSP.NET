using System;
using System.Collections.Generic;
using MyPhotos.Presentation.Contracts;

using Type = MyPhotos.Presentation.Models.Type;

namespace MyPhotos.Presentation.Data
{
    public class TypesService : IService<Type>
    {
        public ICollection<Type> GetAll()
        {
            return new List<Type>
            {
                new Type
                {
                    Id = Guid.NewGuid(),
                    Name = "Test"
                }
            };
        }
    }
}

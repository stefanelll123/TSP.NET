using System;
using System.Collections.Generic;
using MyPhotos.Presentation.Contracts;
using MyPhotos.Presentation.Models;

namespace MyPhotos.Presentation.Data
{
    public class PhotosService : IService<Photo>
    {
        public ICollection<Photo> GetAll()
        {
            return new List<Photo>
            {
                new Photo
                {
                    Id = Guid.NewGuid(),
                    Name = "Photo1",
                    Path = "C:/Users/sturcu/Desktop/facultate/licenta/protein-classification/project/data/chart.PNG"
                }
            };
        }
    }
}

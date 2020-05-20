using System;

namespace MyPhotos.Presentation.Models
{
    public sealed class Photo
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Path { get; set; }

        public bool IsDeleted { get; set; }
    }
}

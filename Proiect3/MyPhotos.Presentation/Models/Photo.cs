using System;
using System.Collections.Generic;

namespace MyPhotos.Presentation.Models
{
    public sealed class Photo
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Path { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreationDate { get; set; }

        public ICollection<string> Types { get; set; }

        public string Event { get; set; }

        public ICollection<string> Places { get; set; }

        public ICollection<string> People { get; set; }
    }
}

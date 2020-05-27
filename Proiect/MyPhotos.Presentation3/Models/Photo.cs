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

        public string EventName { get; set; }

        public List<string> Places { get; set; }

        public List<string> Persons { get; set; }

        public List<string> Types { get; set; }
    }
}

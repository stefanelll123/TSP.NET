using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MyPhotos.WcfServices
{
    [DataContract]
    public class PhotoModel
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Path { get; set; }

        [DataMember]
        public bool IsDeleted { get; set; }

        [DataMember]
        public DateTime CreationDate { get; set; }

        [DataMember]
        public ICollection<string> Types { get; set; }

        [DataMember]
        public string Event { get; set; }

        [DataMember]
        public ICollection<string> Places { get; set; }

        [DataMember]
        public ICollection<string> People { get; set; }
    }
}

using System.Collections.Generic;

namespace EfCore2020.Entities
{
    public sealed class Artist
    {
        public int ArtistId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int? AlbumId { get; set; }

        public ICollection<Album> Albums { get; set; }
    }
}

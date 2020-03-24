using System.Collections.Generic;

namespace EfCore2020.Entities
{
    public sealed class Album
    {
        public int AlbumId { get; set; }

        public string AlbumName { get; set; }

        public int? ArtistId { get; set; }

        public ICollection<Artist> Artists { get; set; }
    }
}

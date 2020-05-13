using System.Collections.Generic;

namespace RazorPagesMovie.Models
{
    public class PostDTO
    {
        public PostDTO() { }
        public string PostId { get; set; }
        public string Description { get; set; }
        public string Domain { get; set; }
        public string Date { get; set; }

        public List<CommentDTO> Comments;
    }
}
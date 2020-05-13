using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Connected_Services.ServiceReferencePostComment;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Posts
{
    public class IndexModel : PageModel
    {
        PostCommentClient pcc = new PostCommentClient();
        public List<PostDTO> Posts { get; set; }

        public IndexModel()
        {
            Posts = new List<PostDTO>();
        }

        public async Task OnGetAsync()
        {
            var posts = await pcc.GetPostsAsync();
            foreach (var item in posts)
            {
                // Trebuia folosit AutoMapper. Transform Post in PostDTO
                var pd = new PostDTO
                {
                    Description = item.Description,
                    PostId = item.PostId.ToString(),
                    Domain = item.Domain,
                    Date = item.Date
                };

                foreach (var cc in item.Comments)
                {
                    var cdto = new CommentDTO();
                    cdto.PostPostId = cc.PostPostId.ToString();
                    cdto.Text = cc.Text;
                    pd.Comments.Add(cdto);
                }

                Posts.Add(pd);
            }
        }
    }
}
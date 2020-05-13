using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Connected_Services.ServiceReferencePostComment;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Comments
{
    public class ListModel : PageModel
    {
        PostCommentClient pcc = new PostCommentClient();
        public List<CommentDTO> Comments { get; set; }

        public ListModel()
        {
            Comments = new List<CommentDTO>();
        }

        public async Task OnGetAsync(Guid? id)
        {
            if (!id.HasValue)
                return;
            var item = await pcc.GetPostByIdAsync(id.Value);
            ViewData["Post"] = item.PostId.ToString() + " : " + item.Description.Trim();

            foreach (var cc in item.Comments)
            {
                var cdto = new CommentDTO();
                cdto.PostPostId = cc.PostPostId.ToString();
                cdto.Text = cc.Text;
                cdto.CommentId = cc.CommentId.ToString();
                Comments.Add(cdto);
            }
        }
    }
}
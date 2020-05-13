using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Connected_Services.ServiceReferencePostComment;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Comments
{
    public class CreateModel : PageModel
    {
        PostCommentClient pcc = new PostCommentClient();
        public CreateModel()
        {
            CommentDTO = new CommentDTO();
        }

        [BindProperty]
        public CommentDTO CommentDTO { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id.HasValue)
            {
                var itemPost = await pcc.GetPostByIdAsync(id.Value);
                ViewData["id"] = id.Value.ToString() + " : " + itemPost.Description;
                CommentDTO.PostPostId = id.Value.ToString();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var comment = new Comment
            {
                PostPostId = id.Value,
                Text = CommentDTO.Text
            };

            var result = await pcc.AddCommentAsync(comment);
            if (!result)
            {
                return RedirectToAction("Error");
            }

            return RedirectToPage("/Posts/Index");
        }
    }
}

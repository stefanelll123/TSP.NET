﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Connected_Services.ServiceReferencePostComment;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Posts
{
    public class DeleteModel : PageModel
    {
        PostCommentClient pcc = new PostCommentClient();
        [BindProperty] public PostDTO PostDTO { get; set; }

        public DeleteModel()
        {
        }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
                return NotFound();
            var post = await pcc.GetPostByIdAsync(id.Value);
            if (post != null)
            {
                PostDTO = new PostDTO();
                PostDTO.PostId = post.PostId.ToString();
                PostDTO.Domain = post.Domain;
                PostDTO.Description = post.Description;
                PostDTO.Date = post.Date;

                return Page();
            }
            else
            {
                return NotFound();
            }
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            int result = 0;
            try
            {
                result = await pcc.DeletePostAsync(id.Value);
                // result ar trebui valorificat mai departe in cod...
            }
            catch (Exception ex)
            {
                return RedirectToPage("/Error");
            }

            return RedirectToPage("./Index");
        }
    }
}
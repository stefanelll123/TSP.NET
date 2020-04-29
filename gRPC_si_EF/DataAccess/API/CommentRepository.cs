using System;
using System.Data.Entity;
using System.Linq;
using DataAccess.Entities;

namespace DataAccess.API
{
    public class CommentRepository
    {
        public bool AddComment(Comment comment)
        {
            using (ModelSelfReference ctx = new ModelSelfReference())
            {
                bool bResult = false;
                if (comment == null || comment.PostPostId == Guid.Empty)
                    return bResult;
                if (comment.CommentId == Guid.Empty)
                {
                    ctx.Entry<Comment>(comment).State = EntityState.Added;
                    Post p = ctx.Posts.Find(comment.PostPostId);
                    ctx.Entry<Post>(p).State = EntityState.Unchanged;
                    ctx.SaveChanges();
                    bResult = true;
                }
                return bResult;
            }
        }

        public Comment UpdateComment(Comment newComment)
        {
            using (ModelSelfReference ctx = new ModelSelfReference())
            {
                Comment oldComment = ctx.Comments.Find(newComment.CommentId);
                // Deoarece parametrul este un Comment ar trebui verificata fiecare
                // proprietate din newComment daca are valoare atribuita si
                // daca valoarea este diferita de cea din bd.
                // Acest lucru il fac numai la modificarea asocierii.
                if (newComment.Text != null)
                    oldComment.Text = newComment.Text;
                if ((oldComment.PostPostId != newComment.PostPostId)
                    && (newComment.PostPostId != Guid.Empty))
                {
                    oldComment.PostPostId = newComment.PostPostId;
                }

                ctx.SaveChanges();
                return oldComment;
            }
        }

        public Comment GetCommentById(Guid id)
        {
            using (ModelSelfReference ctx = new ModelSelfReference())
            {
                var items = from c in ctx.Comments where (c.CommentId == id) select c;
                return items.Include(p => p.Post).SingleOrDefault();
            }
        }
    }
}
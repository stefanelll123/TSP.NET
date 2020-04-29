using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DataAccess.Entities;

namespace DataAccess.API
{
    public class PostRepository
    {
        public bool AddPost(Post post)
        {
            using (ModelSelfReference ctx = new ModelSelfReference())
            {
                bool bResult = false;
                if (post.PostId == Guid.Empty)
                {
                    var it = ctx.Entry<Post>(post).State = EntityState.Added;
                    ctx.SaveChanges();
                    bResult = true;
                }
                return bResult;
            }
        }

        public Post UpdatePost(Post newPost)
        {
            using (ModelSelfReference ctx = new ModelSelfReference())
            {
                Post oldPost = ctx.Posts.Find(newPost.PostId);
                if (oldPost == null) // nu exista in bd
                {
                    return null;
                }
                oldPost.Description = newPost.Description;
                oldPost.Domain = newPost.Domain;
                oldPost.Date = newPost.Date;
                ctx.SaveChanges();
                return oldPost;
            }
        }
        public int DeletePost(Guid id)
        {
            using (ModelSelfReference ctx = new ModelSelfReference())
            {
                return ctx.Database.ExecuteSqlCommand("Delete From Post where postid = @p0", id);
            }
        }
        public Post GetPostById(Guid id)
        {
            using (ModelSelfReference ctx = new ModelSelfReference())
            {
                var items = from p in ctx.Posts where (p.PostId == id) select p;
                if (items != null)
                    return items.Include(c => c.Comments).SingleOrDefault();
                return null; // trebuie verificat in apelant
            }
        }
        public List<Post> GetAllPosts()
        {
            using (ModelSelfReference ctx = new ModelSelfReference())
            {
                return ctx.Posts.Include("Comments").ToList<Post>();
            }
        }
    }
}
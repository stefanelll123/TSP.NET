using System;
using System.Collections.Generic;
using PostComment;

namespace ObjectWCF
{
    interface InterfacePost
    {
        bool AddPost(Post post);
        Post UpdatePost(Post post);
        int DeletePost(Guid id);
        Post GetPostById(Guid id);
        List<Post> GetPosts();
    }

    interface InterfaceComment
    {
        bool AddComment(Comment comment);
        Comment UpdateComment(Comment newComment);
        Comment GetCommentById(Guid id);
    }

    interface IPostComment : InterfacePost, InterfaceComment
    {
    }
}
using Lesson_9.Models;
namespace Lesson_9.Services;

public class PostService
{
    private List<Post> posts;
    public PostService()
    {
        posts = new List<Post>();
    }
    public Post AddPost(Post post)
    {
        post.Id = Guid.NewGuid();
        posts.Add(post);
        return post;
    }

    public bool DeletePost(Guid postId)
    {
        var exists = false;
        foreach (var post in posts)
        {
            if (postId == postId)
            {
                posts.Remove(post);
                exists = true;
                break;
            }
        }

        return exists;
    }

    public bool UpdatePost(Post updatedPost)
    {
        for (var i = 0; i < posts.Count; i++)
        {
            if (posts[i].Id == updatedPost.Id)
            {
                posts[i] = updatedPost;
                return true;
            }
        }

        return false;
    }

    public Post GetById(Guid postId)
    {
        foreach (var post in posts)
        {
            if (post.Id == postId)
            {
                return post;
            }
        }

        return null;
    }

    public List<Post> GetAllPosts()
    {
        return posts;
    }

    public Post GetMostViewedPost()
    {
        Post mostViwedPost = new Post();
        var mostViwed = 0;
        foreach (var post in posts)
        {
            if (post.ViewerNames.Count > mostViwed)
            {
                mostViwed = post.Comments.Count;
                mostViwedPost = post;
            }
        }
        return mostViwedPost;

    }
    public Post GetMostLikedPost()
    {
        Post mostLikedPost = new Post();
        var mostLiked = 0;
        foreach (var post in posts)
        {
            if (post.QuantityLikes > mostLiked)
            {
                mostLiked = post.QuantityLikes;
                mostLikedPost = post;
            }
        }
        return mostLikedPost;
    }
    public Post GetMostCommentedPost()
    {
        Post mostCommentedPost = new Post();
        var mostCommented = 0;
        foreach (var post in posts)
        {
            if (post.Comments.Count > mostCommented)
            {
                mostCommented = mostCommentedPost.Comments.Count;
                mostCommentedPost = post;
            }
        }
        return mostCommentedPost;
    }
    public List<Post> GetPostsByComment(string comment)
    {
        var resultComments = new List<Post>();

        foreach (var post in posts)
        {
            if (post.Comments.Contains(comment) is true)
            {
                resultComments.Add(post);
            }
        }
        return resultComments;
    }
}

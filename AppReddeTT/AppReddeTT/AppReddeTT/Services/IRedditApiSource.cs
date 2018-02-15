using System.Collections.Generic;
using System.Threading.Tasks;
using AppReddeTT.Models;

namespace AppReddeTT.Services
{
public interface IRedditApiSource
{
    Task<IList<Subreddit>> GetSubredditsAsync();
    Task<IList<Post>> GetPostsAsync(Subreddit subreddit);
    Task<IList<Comment>> GetCommentsAsync(Post post);
}
}
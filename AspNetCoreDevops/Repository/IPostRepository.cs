using AspNetCoreDevops.Models;

namespace AspNetCoreDevops.Repository
{
    public interface IPostRepository
    {
        List<PostViewModel> GetPosts();
    }
}

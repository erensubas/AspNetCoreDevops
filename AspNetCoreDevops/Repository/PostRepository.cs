using AspNetCoreDevops.Models;

namespace AspNetCoreDevops.Repository
{
    public class PostRepository : IPostRepository
    {
        public List<PostViewModel> GetPosts()
        {
            var posts = new List<PostViewModel> {
                 new PostViewModel(){ PostId =101, Title = "DevOps Demo Title 1", Description ="DevOps Demo Description 1", Author="Ali"},
                 new PostViewModel(){ PostId =102, Title = "DevOps Demo Title 2", Description ="DevOps Demo Description 2", Author="Veli"},
                 new PostViewModel(){ PostId =103, Title = "DevOps Demo Title 3", Description ="DevOps Demo Description 3", Author="Mehmet"}
                 };

            return posts;
        }
    }
}

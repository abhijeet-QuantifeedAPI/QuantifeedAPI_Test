using QuantifeedWebAPI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuantifeedWebAPI.Repository
{
    public interface IManagerRepository
    {
        Task<List<ManagerViewModel>> GetManagers();

        //Task<List<PostViewModel>> GetPosts();

        Task<List<ManagerViewModel>> GetManager(string UserName);

        //Task<int> AddPost(Post post);

        //Task<int> DeletePost(int? postId);

        //Task UpdatePost(Post post);
    }
}

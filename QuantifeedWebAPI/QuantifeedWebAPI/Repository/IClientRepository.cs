using QuantifeedWebAPI.Models;
using QuantifeedWebAPI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuantifeedWebAPI.Repository
{
    public interface IClientRepository
    {
        Task<List<ClientViewModel>> GetClients();

        //Task<List<PostViewModel>> GetPosts();

        //Task<PostViewModel> GetPost(int? postId);

        //Task<int> AddPost(Post post);

        //Task<int> DeletePost(int? postId);

        //Task UpdatePost(Post post);
    }
}

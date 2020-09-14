using _13Dublins.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13Dublins.ViewModel
{
    public class MainPageModel
    {
        IDublinsRepository repository;
        public MainPageModel(IDublinsRepository rep)
        {
            repository = rep;
        }
        public List<Video> Videos => repository.Videos.ToList();
    }
}

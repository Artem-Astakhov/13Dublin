using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13Dublins.Models
{
    public class VideoCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Video> Videos { get; set; }
    }
}

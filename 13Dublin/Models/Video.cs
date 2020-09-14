using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13Dublins.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public DateTime Date { get; set; }
        

        public int VideoCategoryId { get; set; }
        public VideoCategory VideoCategory { get; set; }
    }
}

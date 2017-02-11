using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    public class VideoResource : Resource, ILectureResouce
    {
        public VideoResource(string type, string name, string url) 
            : base(type, name, url)
        {
        }
    }
}

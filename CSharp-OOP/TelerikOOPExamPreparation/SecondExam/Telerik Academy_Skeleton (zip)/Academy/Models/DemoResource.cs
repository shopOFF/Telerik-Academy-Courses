﻿using Academy.Models.Common;
using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    public class DemoResource : Resource, ILectureResouce
    {
        public DemoResource(string type, string name, string url) 
            : base(type, name, url)
        {
        }
    }
}

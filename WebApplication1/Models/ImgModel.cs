﻿using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ImgModel
    {
        public ObjectId Id { get; set; }
        public int ImgId { get; set; }
        public string ImgName { get; set; }
    }
}
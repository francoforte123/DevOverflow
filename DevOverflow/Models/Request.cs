﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevOverflow.Models
{
    public class Request
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}

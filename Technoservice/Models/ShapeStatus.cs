﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Technoservice.Models
{
    public partial class ShapeStatus
    {
        public ShapeStatus()
        {
            Shape = new HashSet<Shape>();
        }

        public int IdShapeStatus { get; set; }
        public string TitleShapeStatus { get; set; }

        public virtual ICollection<Shape> Shape { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Technoservice.Models
{
    public partial class Equipment
    {
        public Equipment()
        {
            Shape = new HashSet<Shape>();
        }

        public int IdEquipment { get; set; }
        public string EquipmentTitle { get; set; }
        public int IdSpecification { get; set; }

        public virtual Specifications IdSpecificationNavigation { get; set; }
        public virtual ICollection<Shape> Shape { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace eShop.DatabaseRepository.DbModels
{
    public partial class ProductsInCategories
    {
        public Guid CategoryId { get; set; }
        public Guid ProductId { get; set; }

        public virtual Categories Category { get; set; }
        public virtual Products Product { get; set; }
    }
}
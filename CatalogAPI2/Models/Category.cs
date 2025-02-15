﻿using System.Text.Json.Serialization;

namespace CatalogAPI2.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        [JsonIgnore]
        public ICollection<Product>? Products { get; set; }
    }
}

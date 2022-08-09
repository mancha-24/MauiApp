using System;
using System.Text.Json.Serialization;

namespace MauiApp1.Models
{
    public class Product
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string image_title { get; set; }
        public string image { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public CategoryType category { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SubCategoryType subcategory { get; set; }
    }
}


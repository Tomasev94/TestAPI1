using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TestAPI1.Models
{
    public class NewArticleForResponse
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        [JsonPropertyName("body")]
        public string Body { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("tagList")]
        public List<string> TagList { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("author")]
        public NewAuthorForResponse Author { get; set; }

        [JsonPropertyName("favorited")]
        public bool Favorited { get; set; }

        [JsonPropertyName("favoritesCount")]
        public int FavoritesCount { get; set; }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class UrlViewModel
    {
        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class AllProjectsModel
    {
        [JsonProperty("projects")]
        public List<ProjectViewModel> Projects { get; set; }
    }

    public class ProjectViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("role")]
        public string Role { get; set; }
        [JsonProperty("tech")]
        public string Tech { get; set; }
        [JsonProperty("image")]
        public string Image { get; set; }
        [JsonProperty("url")]
        public List<UrlViewModel> Url { get; set; }
        [JsonProperty("projid")]
        public string Projid { get; set; }
        [JsonProperty("type")]
        public List<string> Type { get; set; }
    }
}
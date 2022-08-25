using System.ComponentModel.DataAnnotations;

namespace Galaxy_fc.UI.Models
{
    public class Application
    {
        [Required()]
        public string? CharacterName { get; set; }
        [Required()]
        public string? DiscordName { get; set; }
        [Required()]
        public string? Age { get; set; }
        [Required()]
        public string? Time { get; set; }
        [Required()]
        public string? Expectations { get; set; }
        [Required()]
        public string? Acceptance { get; set; }
        [Required()]
        public string? Opinion { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Galaxy_fc.UI.Pages
{
    public class Application
    {
        [Required(ErrorMessage = "Your character name is required.")]
        public string? CharacterName { get; set; }
        [Required(ErrorMessage = "Your discord name is required.")]
        public string? DiscordName { get; set; }
        [Required(ErrorMessage = "Your current age is required.")]
        public string? Age { get; set; }
        [Required(ErrorMessage = "The typical time you play is required.")]
        public string? Time { get; set; }
        [Required(ErrorMessage = "An explaination of what your expectations are is required.")]
        public string? Expectations { get; set; }
        [Required(ErrorMessage = "An answer to this is required.")]
        public string? Acceptance { get; set; }
        [Required(ErrorMessage = "Your opinion of the above statement is required.")]
        public string? Opinion { get; set; }
    }
}

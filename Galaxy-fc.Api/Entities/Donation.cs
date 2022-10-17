using System.ComponentModel.DataAnnotations;

namespace Galaxy_fc.Api.Entities
{
	public class Donation
	{
		public int Id { get; set; }
		public int DonationId { get; set; }
        [Required]
        public string UserName { get; set; } = null!;
        public int Gil { get; set; }
        public DateTime Date { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Modified_At { get; set; }
    }
}

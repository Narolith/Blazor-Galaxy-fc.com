using Galaxy_fc.Api.Entities;
using System.ComponentModel.DataAnnotations;

namespace Galaxy_fc.Api
{
	public class DonationDto
	{
        public int Id { get; set; }
        public int DonationId { get; set; }
        [Required]
        public string UserName { get; set; } = null!;
        public int Gil { get; set; }
        public DateTime Date { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Modified_At { get; set; }

        public DonationDto(Donation donation)
        {
            Id = donation.Id;
            DonationId = donation.DonationId;
            UserName = donation.UserName;
            Gil = donation.Gil;
            Date = donation.Date;
            Created_At = donation.Created_At;
            Modified_At = donation.Modified_At;

        }
    }
    

}
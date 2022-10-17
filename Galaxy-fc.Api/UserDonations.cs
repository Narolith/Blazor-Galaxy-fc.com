using System.ComponentModel.DataAnnotations;

namespace Galaxy_fc.Api
{
    public class UserDonations
    {
        public int Id { get; set; }
        
        public List<DonationDto> Donations { get; set; } = new List<DonationDto>();
        
        [Required]
        public string UserName { get; set; } = null!;
        
        public long AllTimeTotalGil { get; set; }
        
        public long MonthTotalGil { get; set; }
        
        public UserDonations(string userName, GalaxyDbContext context)
        {
            UserName = userName;
            
            // Convert donation to DTO and add to list
            foreach (var donation in context.Donations.Where(don => don.UserName == userName))
            {
                Donations.Add(new DonationDto(donation));
            }

            // Add up all donations
            foreach (var donation in Donations)
            {
                AllTimeTotalGil += donation.Gil;
            }
            
            // Add up donations from this month
            foreach (var donation in Donations.Where(don => don.Date.Month == DateTime.Now.Month))
            {
                MonthTotalGil += donation.Gil;
            }
        }
    }
}

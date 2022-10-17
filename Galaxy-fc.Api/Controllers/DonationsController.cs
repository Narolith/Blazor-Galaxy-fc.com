using Microsoft.AspNetCore.Mvc;

namespace Galaxy_fc.Api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class DonationsController : ControllerBase
	{
		private readonly ILogger<DonationsController> _logger;
        private readonly GalaxyDbContext _context;

        public DonationsController(ILogger<DonationsController> logger, GalaxyDbContext context)
		{
			_logger = logger;
            _context = context;
		}

		[HttpGet(Name = "GetAllDonations")]
		public IEnumerable<UserDonations> GetAllDonations()
		{
            HashSet<string> users = _context.Donations.Select(don => don.UserName).ToHashSet();
            List<UserDonations> donations = new();

            foreach (var user in users)
            {
                donations.Add(new UserDonations(user, _context));
            }
            
            return donations;
		}

        [HttpGet(Name = "GetUserDonations")]
        public UserDonations GetUserDonations(string userName)
        {
            return new UserDonations(userName, _context);
        }
    }
}
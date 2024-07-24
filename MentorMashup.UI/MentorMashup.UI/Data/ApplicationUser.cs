using Microsoft.AspNetCore.Identity;

namespace MentorMashup.UI.Data
{
	// Add profile data for application users by adding properties to the ApplicationUser class
	public class ApplicationUser : IdentityUser
	{
        public DateOnly? DateOfBirth { get; set; }
    }

}

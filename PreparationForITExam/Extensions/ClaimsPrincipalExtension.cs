using Microsoft.SharePoint.Portal.Analytics.UI;
using PreparationForITExam.Core.Constants;
using System.Security.Claims;

namespace PreparationForITExam.Extensions
{
    public static class ClaimsPrincipalExtension
    {
        public static string Id(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public static bool IsAdministrator(this ClaimsPrincipal user)
        {
            return user.IsInRole(RoleConstants.Administrator);
        }
    }
}

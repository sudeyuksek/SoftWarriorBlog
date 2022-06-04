using Microsoft.AspNetCore.Mvc;

namespace YoutubeDersleri.WebUI.Management.Authorize
{
    public class AuthorizeAttribute : TypeFilterAttribute
    {
        public AuthorizeAttribute() : base(typeof(ClaimRequirementFilter))
        {
            Arguments = new object[] { };
        }
    }
}

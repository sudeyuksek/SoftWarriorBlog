using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Data;
using Blog.WebUI.Infrastructure.Cache;
using Blog.WebUI.Management.Singleton;

namespace Blog.WebUI.Management.Authorize
{
    public class ClaimRequirementFilter : IAuthorizationFilter
    {
        CacheHelper cacheHelper;
        RolePageData _rolePageData;

        public ClaimRequirementFilter(CacheHelper cacheHelper, RolePageData _rolePageData)
        {
            this.cacheHelper = cacheHelper;
            this._rolePageData = _rolePageData;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var role = context.HttpContext.User.Claims.FirstOrDefault(x => x.Type == System.Security.Claims.ClaimTypes.Role);
            var id = context.HttpContext.User.Claims.FirstOrDefault(x => x.Type == System.Security.Claims.ClaimTypes.NameIdentifier);
            var name = context.HttpContext.User.Claims.FirstOrDefault(x => x.Type == System.Security.Claims.ClaimTypes.Name);

            if (role == null || role.Value == "")
            {
                context.Result = new RedirectResult("/Home/Login");
                return;
            }
            if (id != null)
                LoginUser.Instance.AuthorId = int.Parse(id.Value.ToString());

            if (name != null)
                LoginUser.Instance.FullName = name.Value.ToString();

            //Bu role idli kullanıcı adminse devam et sorgulama
            LoginUser.Instance.IsAdmin = false;
            if (role.Value == "1")
            {
                LoginUser.Instance.IsAdmin = true;
                return;
            }
                

            var role_id = int.Parse(role.Value);
            var rolePages = cacheHelper.RolePages(role_id);

            //admin değilse kontrol edelim
            var route = (context.RouteData.Values["controller"] + "/" + context.RouteData.Values["action"]).ToLowerInvariant();
            if (!rolePages.Any(x => x.Route == route))
            {
                //belki yetkiyi yeni vermişimdir.
                var role_page = _rolePageData.GetBy(x => x.Route == route && x.RoleId == role_id).FirstOrDefault();

                if (role_page == null)
                {
                    if (context.HttpContext.Request.Headers.ContainsKey("x-requested-with"))
                    {
                        var xRequestedWithCheck = context.HttpContext.Request.Headers.FirstOrDefault(x => x.Key == "x-requested-with");
                        var value = xRequestedWithCheck.Value;
                        if (value == "XMLHttpRequest")
                        {
                            context.Result = new JsonResult("özel mesaj") { StatusCode = 403 };
                            return;
                        }
                    }
                    if (route.EndsWith("category/index") || route.EndsWith("author/index"))
                    {
                        context.Result = new RedirectResult("/Home/_403?url=" + route);
                    }
                    else { return; }


                }
            }
        }
    }
}
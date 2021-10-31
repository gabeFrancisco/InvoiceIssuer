using System;
using InvoiceIssuer.Domain.Entities;
using InvoiceIssuer.Web.Sessions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace InvoiceIssuer.Web.Filters
{
    public class UserAuthorizationAttribute : Attribute, IAuthorizationFilter
    {
        LoginStorage _loginStorage;
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            _loginStorage = (LoginStorage)context.HttpContext.RequestServices.GetService(typeof(LoginStorage));
            Provider provider = _loginStorage.GetProvider();

            if (provider == null)
            {
                context.Result = new ViewResult() { ViewName = "SessionError"};
            }
        }
    }
}
using System;
using System.Web;
using System.Web.Mvc;
namespace OnlyOnlyAjaxAtt
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class OnlyAjaxAttribute:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if(filterContext.HttpContext.Request.IsAjaxRequest())
              base.OnActionExecuting(filterContext);
            else
            {
                throw new InvalidOperationException("This operation can only be accessed via Ajax requests");
            }
        }
    }
}

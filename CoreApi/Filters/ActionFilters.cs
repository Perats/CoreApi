using Microsoft.AspNetCore.Mvc.Filters;
using NLog;
using System;

namespace CoreApi.Filters
{
    public class ActionFilters : ActionFilterAttribute
    {
        private static Logger logger = NLog.Web.NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            logger.SetProperty("controller", context.ActionDescriptor.DisplayName);
            logger.Info(Environment.NewLine + DateTime.Now);
        }
    }
}

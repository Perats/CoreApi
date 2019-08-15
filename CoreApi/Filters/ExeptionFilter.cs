using Microsoft.AspNetCore.Mvc.Filters;
using NLog;
using NLog.Web;
using System;

namespace CoreApi.Filters
{
    public class ExeptionFilter : ExceptionFilterAttribute
    {
        private static Logger logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
        public override void OnException(ExceptionContext actionExecutedContext)
        {
            logger.SetProperty("controller", actionExecutedContext.ActionDescriptor.DisplayName);
            logger.Error(actionExecutedContext.Exception, "Error" + Environment.NewLine + DateTime.Now);
        }
    }
}

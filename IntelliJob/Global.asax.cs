using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace IntelliJob
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            if (Request == null)
                return;

            string requestPath = Request.AppRelativeCurrentExecutionFilePath;
            if (string.Equals(requestPath, "~/", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(requestPath, "~/Default.aspx", StringComparison.OrdinalIgnoreCase))
            {
                Response.Redirect("~/User/Home.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }
        }
    }
}
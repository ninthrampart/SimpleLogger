using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLogger
{
    public class Class1
    {
    }



    //// 
    //// This is  demo of the XrmLogger class.
    //// How to use it:
    //// Create a C:\LOG on the Server and give your CRM Users RW rights
    //// Compile this class (don't forget to sign it with a strong key!)
    //// Use the pluginregistrationtool from the CRM.SDK to register the assembly (don't specify sandbox isolation mode! 
    //// => this plugin works only in onpremise or hosting environments
    //// deploy it for any message and entity you like
    //// 

    //namespace xrmLog
    //{
    //    public class XrmLoggerDemo : IPlugin
    //    {

    //        public void Execute(System.IServiceProvider serviceProvider)
    //        {
    //            IPluginExecutionContext context = (Microsoft.Xrm.Sdk.IPluginExecutionContext)serviceProvider.GetService(typeof(Microsoft.Xrm.Sdk.IPluginExecutionContext));

    //            XrmLoggerConfig config = new XrmLoggerConfig()
    //            {
    //                LogDirectoryName = @"C:\LOG",
    //                LogFileGroup = "XrmLoggerDemo",
    //                logLevel = LogLevel.VERBOSE
    //            };

    //            XrmLogger xLog = new XrmLogger(config);

    //            xLog.ialert(String.Format("Entity: {0} => Message: {1} => Stage: {2}", context.PrimaryEntityName, context.MessageName, context.Stage));
    //        }
    //    }
    //}
}

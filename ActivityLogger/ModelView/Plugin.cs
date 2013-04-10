using System;
using System.Collections.Generic;
using System.Text;
using CK.Plugin;
using CK.Plugin.Config;
using System.Windows;
using ModelView;

namespace ActivityLogger
{
    /// <summary>
    /// Class that represent a CiviKey plugin
    /// </summary>
    [Plugin(PluginGuidString, PublicName = PluginPublicName, Version = PluginIdVersion)]
    public class ActivityLogger : IPlugin
    {
        //This GUID has been generated when you created the project, you may use it as is
        const string PluginGuidString = "{d11e6ad8-4e43-46c2-9f32-db015e1a29d3}";
        const string PluginIdVersion = "1.0.0";
        const string PluginPublicName = "ActivityLogger";

        //Reference to the storage object that enables one to save data.
        //This object is injected after all plugins' Setup method has been called
        public IPluginConfigAccessor Config { get; set; }

        /// <summary>
        /// Constructor of the class, all services are null
        /// </summary>
        public ActivityLogger()
        {
            w = new MainWindowActivityLogger();
            w.Content = "This is a new plugin";
        }

        MainWindowActivityLogger w;

        /// <summary>
        /// First called method on the class, at this point, all services are null.
        /// Used to set up the service exposed by this plugin (if any).
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public bool Setup(IPluginSetupInfo info)
        {
            return true;
        }

        /// <summary>
        /// Called after the Setup method.
        /// All launched services are now set, you may now set up the link to the service used by this class
        /// </summary>
        public void Start()
        {
            w.Show();
        }

        /// <summary>
        /// First method called when the plugin is stopping
        /// You should remove all references to any service here.
        /// </summary>
        public void Stop()
        {
            w.Close();
        }

        /// <summary>
        /// Called after Stop()
        /// All services are null
        /// </summary>
        public void Teardown()
        {
        }
    }
}

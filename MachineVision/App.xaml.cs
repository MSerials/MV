using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Framework.Common.Dialog;



namespace MachineVision
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            this.DispatcherUnhandledException += App_DispatcherUnhandledException;
        }

        private void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            //throw new NotImplementedException();
            MessageBox.Show(e.Exception.Message);
            e.Handled = true;
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            // base.OnStartup(e);
            System.Windows.Media.RenderOptions.ProcessRenderMode = System.Windows.Interop.RenderMode.SoftwareOnly;
            base.OnStartup(e);
            var bootstrapper = new Bootstrapper();
            bootstrapper.Run();

        }
    }

}



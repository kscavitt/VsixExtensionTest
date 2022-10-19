using Community.VisualStudio.Toolkit.DependencyInjection;
using Community.VisualStudio.Toolkit.DependencyInjection.Core;

namespace TestVSIXProject1
{
    [Command(PackageIds.MyCommand)]
    internal sealed class MyToolWindowCommand : BaseDICommand
    {
        public MyToolWindowCommand(DIToolkitPackage package) : base(package)
        {

        }

        protected override Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            return MyToolWindow.ShowAsync();
        }
    }
}

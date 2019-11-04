using DevExpress.Diagram.Core.Themes;
using DevExpress.Xpf.Core;
using System.Windows;

namespace WPFRibbon
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            //DevExpress.Xpf.Core.ApplicationThemeHelper.ApplicationThemeName =
            //    DevExpress.Xpf.Core.Theme.Office2016ColorfulFullName;
            /// DevExpress.Xpf.Core.ThemeManager.ApplicationThemeName = DevExpress.Xpf.Core.Theme.Office2016ColorfulFullName;
            ///   protected override void OnStartup(StartupEventArgs e) {
            ApplicationThemeHelper.ApplicationThemeName = DevExpress.Xpf.Core.Theme.NoneName;
            ApplicationThemeHelper.SaveApplicationThemeName();
            base.OnStartup(e);
        
          
        }
    }
}

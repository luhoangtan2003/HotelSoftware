using DevExpress.XtraSplashScreen;
using System;

namespace GUILAYER
{
    public partial class SplashScreenProject : SplashScreen
    {
        public SplashScreenProject()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
    }
}
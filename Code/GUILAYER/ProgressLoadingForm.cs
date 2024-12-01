using DevExpress.XtraWaitForm;
using System;

namespace GUILAYER
{
    public partial class ProgressLoadingForm : WaitForm
    {
        public ProgressLoadingForm()
        {
            InitializeComponent();
            this.ProgressPanel1.AutoHeight = true;
        }

        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            this.ProgressPanel1.Caption = caption;
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            this.ProgressPanel1.Description = description;
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum WaitFormCommand
        {
        }
    }
}
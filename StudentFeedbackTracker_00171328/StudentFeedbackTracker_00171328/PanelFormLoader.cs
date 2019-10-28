using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentFeedbackTracker_00171328
{
    public class PanelFormLoader
    {
        public static void ServingForm(Form formInstance, Panel panel)
        {
            panel.Controls.Clear();
            formInstance.TopLevel = false;
            formInstance.Height = panel.Height;
            formInstance.Width = panel.Width;
            panel.Controls.Add(formInstance);
            formInstance.Show();
        }
    }
}

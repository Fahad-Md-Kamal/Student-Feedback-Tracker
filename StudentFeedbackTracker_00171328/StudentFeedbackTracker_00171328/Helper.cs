using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentFeedbackTracker_00171328
{
    public class Helper
    {
        public static void PanelLoader(Form formInstance, Panel panel)
        {
            panel.Controls.Clear();
            formInstance.FormBorderStyle = FormBorderStyle.None;
            formInstance.TopLevel = false;
            formInstance.Height = panel.Height;
            formInstance.Width = panel.Width;
            panel.Controls.Add(formInstance);
            formInstance.Show();
        }


        public static bool CheckNull(GroupBox groupBox)
        {
            if (groupBox.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
            {
                return false;
            }
            return true;
        }

        public static void SetNullTxtBx(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = null;
                }
            }
            
        }

        public static bool TxTNullCheck(TextBox text)
        {
            if (string.IsNullOrEmpty(text.Text))
            {
                return false;
            }
            return true;
        }

        public static bool CheckInt(string text)
        {
            return int.TryParse(text, out int result);
        }
    }
}

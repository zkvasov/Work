using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading;
using System.Globalization;

namespace FiguresRunning
{
    public static class LocalizationHelper
    {
        public static void ApplyCulture(string cultureName = "en-US")
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(cultureName);
            //Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(cultureName);
            foreach (Form form in Application.OpenForms)
            {
                var res = new ComponentResourceManager(form.GetType());
                res.ApplyResources(form, "$this");
                foreach (Control ctrl in form.Controls)
                    ApplyCulture(res, ctrl);
            }
        }

        private static void ApplyCulture(ComponentResourceManager res, Control ctrl)
        {
            res.ApplyResources(ctrl, ctrl.Name);
            foreach (Control child in ctrl.Controls)
                ApplyCulture(res, child);
        }
    }
}

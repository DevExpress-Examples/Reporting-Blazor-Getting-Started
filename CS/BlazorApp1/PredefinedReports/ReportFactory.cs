using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.XtraReports.UI;

namespace BlazorApp1.PredefinedReports {
    public static class ReportFactory {
        public static Dictionary<string, Func<XtraReport>> Reports = new Dictionary<string, Func<XtraReport>>() {
            ["HelloWorld"] = () => new HelloWorld()
        };
    }
}

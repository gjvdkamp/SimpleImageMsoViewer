using ExcelDna.Integration;
using ExcelDna.Integration.CustomUI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleImageMsoViewer
{
    [ComVisible(true)]
    public class AddIn : ExcelRibbon, IExcelAddIn
    {
        public void AutoClose() { }

        public static dynamic Application { get; private set; }
        private IList<ImageMso> ImageMsos;

        public void AutoOpen()
        {
            Application = ExcelDnaUtil.Application;

            // load ImageMso list 
            // file with ImageMso found here: https://www.microsoft.com/en-us/download/details.aspx?id=727
            var p = Path.Combine(Path.GetDirectoryName(ExcelDnaUtil.XllPath), "ImageMso.txt");
            ImageMsos =
                File.ReadAllLines(p)
                .Skip(1) // skip headers
                .Select(l => new ImageMso(l)) // project into ImageMso
                .ToList();

            btnShow_OnAction(null);
        }

        public void btnShow_OnAction(IRibbonControl sender) => new ImageViewer(ImageMsos).Show();
    }
}

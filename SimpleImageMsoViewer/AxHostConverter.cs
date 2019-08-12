using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleImageMsoViewer
{
    // wrapper to make internal method public 
    // from article found here: 
    // https://blogs.msdn.microsoft.com/andreww/2007/07/30/converting-between-ipicturedisp-and-system-drawing-image/

    public class AxHostWrapper : AxHost
    {
        public AxHostWrapper() : base("") { throw new NotImplementedException("Please use static mehtod directly"); }

        public static Image IDispToImage(object pictureDisp) { return GetPictureFromIPicture(pictureDisp); }
    }
}
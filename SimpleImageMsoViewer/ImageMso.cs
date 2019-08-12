using System;

namespace SimpleImageMsoViewer
{
    public class ImageMso
    {
        public string Name { get; private set; }
        public bool Exists2010 { get; private set; }
        public bool Exists2013 { get; private set; }
        
        public System.Drawing.Image Icon16
        {
            get
            {
                try
                {                   
                    object i = AddIn.Application.CommandBars.GetImageMso(Name, 16, 16);
                    return AxHostWrapper.IDispToImage(i);
                }
                // turns out ImageMso.txt is not very accurate, may pictures in that list are not found. 
                catch (Exception e)
                {
                    return null;
                }
            }
        }

        public System.Drawing.Image Icon32
        {
            get
            {
                try
                {
                    // get IDisp image from Excel and convert to System.Drawing.Image
                    object i = AddIn.Application.CommandBars.GetImageMso(Name, 32, 32);
                    return AxHostWrapper.IDispToImage(i);
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }

        public ImageMso(string line)
        {
            var words = line.Split('\t');
            Name = words[0];
            Exists2010 = words[1] == "1";
            Exists2013 = words[2] == "1";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleImageMsoViewer
{
    public partial class ImageViewer : Form
    {
        private IList<ImageMso> _Images;

        public ImageViewer(IList<ImageMso> ImageMsos)
        {
            InitializeComponent();
            _Images = ImageMsos;
            dgImages.DataSource = _Images;
            dgImages.Columns[0].Width = 300;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (txtFilter.Text.Length > 0)
            {
                var f = _Images.Where(i => i.Name.IndexOf(txtFilter.Text, StringComparison.InvariantCultureIgnoreCase) >= 0).ToList();
                dgImages.DataSource = f;
            }
            else dgImages.DataSource = _Images;           
        }
    }
}

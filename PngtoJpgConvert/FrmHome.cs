using System.Configuration;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace PngtoJpgConvert
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        public void btnConvert_Click(object sender, EventArgs e)
        {
            ImageConverter.ConvertPngToJpgInNestedFolders(ConfigurationManager.AppSettings["DirectoryPath"]);
        }
    }
}

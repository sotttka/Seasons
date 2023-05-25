using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;

namespace Seasons
{
    public partial class Seasons : Form
    {
        public Seasons()
        {
            InitializeComponent();
        }

        private void _btnSummer_Click(object sender, EventArgs e)
        {
            Image image = new Bitmap("img/summer.jpg");
            BackgroundImage = image;
        }

        private void _btnAutumn_Click(object sender, EventArgs e)
        {
            Image image = new Bitmap("img/autumn.jpg");
            BackgroundImage = image;
        }

        private void _btnWinter_Click(object sender, EventArgs e)
        {
            Image image = new Bitmap("img/winter.jpg");
            BackgroundImage = image;
        }

        private void _btnSpring_Click(object sender, EventArgs e)
        {
            Image image = new Bitmap("img/spring.jpg");
            BackgroundImage = image;
        }
    }
}
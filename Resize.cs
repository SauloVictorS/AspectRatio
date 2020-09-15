using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resize_and_Aspect_Ratio
{
    public partial class Resize : Form
    {
        //The anchor panel must be docked as a Fill
        //The ProportionalPanel is anchored as Top Left
        public Resize()
        {
            InitializeComponent();
        }

        private void AnchorPanel_SizeChanged(object sender, EventArgs e)
        {
            //Calculates the new size of the panel
            //You can use any proportion here
            int Height = (int)(AnchorPanel.Width * 0.71);
            int Width = (int)(AnchorPanel.Height / 0.71);

            //one of the two sides needs to be matched to the proportions
            if (AnchorPanel.Width <= AnchorPanel.Height / 0.71)
            {
                //Here you can setup some margins (i'm using 25px for each side)
                //If you don't wnat any margins just remove the number
                ProportionalPanel.Height = Height - 25;
                ProportionalPanel.Width = AnchorPanel.Width - 25;

            }
            else
            {
                ProportionalPanel.Width = Width - 25;
                ProportionalPanel.Height = AnchorPanel.Height - 25;
            }
        }
    }
}

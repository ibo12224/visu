using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spinup {
    public partial class frmAnimaion : Form {
        int pictureNumber;
        public frmAnimaion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timAnimation.Enabled = !timAnimation.Enabled;
        }

        private void timAnimation_Tick(object sender, EventArgs e)
        {
            switch (pictureNumber)
            {
                case 0:
                    picDisplay.Image = picChoice0.Image;
                    break;
                case 1:
                    picDisplay.Image = picChoice1.Image;
                    break;
                case 2:
                    picDisplay.Image = picChoice2.Image;
                    break;
                case 3:
                    picDisplay.Image = picChoice3.Image;
                    break;
                case 4:
                    picDisplay.Image = picChoice4.Image;
                    break;
                case 5:
                    picDisplay.Image = picChoice5.Image;
                    break;
                case 6:
                    picDisplay.Image = picChoice6.Image;
                    break;
                case 7:
                    picDisplay.Image = picChoice7.Image;
                    break;
            }
            pictureNumber++;
             picDisplay.Left +=10;
            if (pictureNumber == 8)
            {
                
                pictureNumber = 0;
            }
        }
    }
}

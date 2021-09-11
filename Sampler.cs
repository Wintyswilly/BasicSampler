using System.Linq;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
namespace RadioSampler
{
    public partial class Sampler : Form
    {
        public Sampler()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"D:\OneDrive\RadioSampler\RadioSampler\Jingle1.wav");
            splayer.Play();
        }
    }
}

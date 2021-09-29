using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace RadioSampler
{
    public partial class IncapableSampler : Form
    {


        public IncapableSampler()
        {
            InitializeComponent();

        }

        public void button1_Click(object sender, EventArgs e)
        {


            if (listBox1.Items.Count is 0) 
            { System.Windows.Forms.MessageBox.Show("No File Clown Shoes!"); }
            else
            {
                if (listBox1.SelectedItems.Count is 0)
                { System.Windows.Forms.MessageBox.Show("Stop being mean to me! select a file"); }
                else
                {
                if(listBox1.SelectedItem.ToString().EndsWith(".mp3"))
                    {
                        string curItem = listBox1.SelectedItem.ToString();
                        int index = listBox1.FindString(curItem);
                        listBox1.SetSelected(index, true);
                        object fileLocationobj = curItem;
                        string fileLocation = fileLocationobj.ToString();
                        // play mp3
                        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                        
                        wplayer.URL = fileLocation;
            
                        wplayer.controls.play();
                    }
                    else {


                        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                        wplayer.controls.stop();
                        string curItem = listBox1.SelectedItem.ToString();
                        int index = listBox1.FindString(curItem);
                        listBox1.SetSelected(index, true);
                        object fileLocationobj = curItem;
                        string fileLocation = fileLocationobj.ToString();
                       // play wav
                        SoundPlayer splayer = new SoundPlayer(soundLocation: fileLocation);
                        splayer.Play();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count is 0)
            { System.Windows.Forms.MessageBox.Show("No File Clown Shoes!"); }
            else
            {
                if (listBox2.SelectedItems.Count is 0)
                { System.Windows.Forms.MessageBox.Show("Stop being mean to me! select a file"); }
                else
                {

                    if (listBox2.SelectedItem.ToString().EndsWith(".mp3"))
                    {
                        string curItem = listBox2.SelectedItem.ToString();
                        int index = listBox2.FindString(curItem);
                        listBox2.SetSelected(index, true);
                        object fileLocationobj = curItem;
                        string fileLocation = fileLocationobj.ToString();
                        // play mp3
                        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

                        wplayer.URL = fileLocation;

                        wplayer.controls.play();
                    }
                    else
                    {


                        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                        wplayer.controls.stop();
                        string curItem = listBox2.SelectedItem.ToString();
                        int index = listBox2.FindString(curItem);
                        listBox2.SetSelected(index, true);
                        object fileLocationobj = curItem;
                        string fileLocation = fileLocationobj.ToString();
                        // play wav
                        SoundPlayer splayer = new SoundPlayer(soundLocation: fileLocation);
                        splayer.Play();
                    }
                }

        }
    }
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox3.Items.Count is 0)
            { System.Windows.Forms.MessageBox.Show("No File Clown Shoes!"); }
            else
            {
                if (listBox3.SelectedItems.Count is 0)
                { System.Windows.Forms.MessageBox.Show("Stop being mean to me! select a file"); }
                else
                {

                    if (listBox3.SelectedItem.ToString().EndsWith(".mp3"))
                    {
                        string curItem = listBox3.SelectedItem.ToString();
                        int index = listBox3.FindString(curItem);
                        listBox1.SetSelected(index, true);
                        object fileLocationobj = curItem;
                        string fileLocation = fileLocationobj.ToString();
                        // play mp3
                        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

                        wplayer.URL = fileLocation;

                        wplayer.controls.play();
                    }
                    else
                    {


                        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                        wplayer.controls.stop();
                        string curItem = listBox3.SelectedItem.ToString();
                        int index = listBox3.FindString(curItem);
                        listBox3.SetSelected(index, true);
                        object fileLocationobj = curItem;
                        string fileLocation = fileLocationobj.ToString();
                        // play wav
                        SoundPlayer splayer = new SoundPlayer(soundLocation: fileLocation);
                        splayer.Play();
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox4.Items.Count is 0)
            { System.Windows.Forms.MessageBox.Show("No File Clown Shoes!"); }
            else
            {
                if (listBox4.SelectedItems.Count is 0)
                { System.Windows.Forms.MessageBox.Show("Stop being mean to me! select a file"); }
                else
                {

                    if (listBox4.SelectedItem.ToString().EndsWith(".mp3"))
                    {
                        string curItem = listBox4.SelectedItem.ToString();
                        int index = listBox4.FindString(curItem);
                        listBox4.SetSelected(index, true);
                        object fileLocationobj = curItem;
                        string fileLocation = fileLocationobj.ToString();
                        // play mp3
                        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

                        wplayer.URL = fileLocation;

                        wplayer.controls.play();
                    }
                    else
                    {


                        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                        wplayer.controls.stop();
                        string curItem = listBox4.SelectedItem.ToString();
                        int index = listBox4.FindString(curItem);
                        listBox4.SetSelected(index, true);
                        object fileLocationobj = curItem;
                        string fileLocation = fileLocationobj.ToString();
                        // play wav
                        SoundPlayer splayer = new SoundPlayer(soundLocation: fileLocation);
                        splayer.Play();
                    }
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox5.Items.Count is 0)
            { System.Windows.Forms.MessageBox.Show("No File Clown Shoes!"); }
            else
            {
                if (listBox5.SelectedItems.Count is 0)
                { System.Windows.Forms.MessageBox.Show("Stop being mean to me! select a file"); }
                else
                {

                    if (listBox5.SelectedItem.ToString().EndsWith(".mp3"))
                    {
                        string curItem = listBox5.SelectedItem.ToString();
                        int index = listBox5.FindString(curItem);
                        listBox5.SetSelected(index, true);
                        object fileLocationobj = curItem;
                        string fileLocation = fileLocationobj.ToString();
                        // play mp3
                        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

                        wplayer.URL = fileLocation;

                        wplayer.controls.play();
                    }
                    else
                    {


                        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                        wplayer.controls.stop();
                        string curItem = listBox5.SelectedItem.ToString();
                        int index = listBox5.FindString(curItem);
                        listBox5.SetSelected(index, true);
                        object fileLocationobj = curItem;
                        string fileLocation = fileLocationobj.ToString();
                        // play wav
                        SoundPlayer splayer = new SoundPlayer(soundLocation: fileLocation);
                        splayer.Play();
                    }
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox6.Items.Count is 0)
            { System.Windows.Forms.MessageBox.Show("No File Clown Shoes!"); }
            else
            {
                if (listBox6.SelectedItems.Count is 0)
                { System.Windows.Forms.MessageBox.Show("Stop being mean to me! select a file"); }
                else
                {
                    if (listBox6.SelectedItem.ToString().EndsWith(".mp3"))
                    {
                        string curItem = listBox6.SelectedItem.ToString();
                        int index = listBox6.FindString(curItem);
                        listBox6.SetSelected(index, true);
                        object fileLocationobj = curItem;
                        string fileLocation = fileLocationobj.ToString();
                        // play mp3
                        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

                        wplayer.URL = fileLocation;

                        wplayer.controls.play();
                    }
                    else
                    {

                        
                        string curItem = listBox6.SelectedItem.ToString();
                        int index = listBox6.FindString(curItem);
                        listBox6.SetSelected(index, true);
                        object fileLocationobj = curItem;
                        string fileLocation = fileLocationobj.ToString();
                        // play wav
                        SoundPlayer splayer = new SoundPlayer(soundLocation: fileLocation);
                        splayer.Play();
                    }
                }

            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
 

        }
        private void listBox1_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
        public void listBox1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length;  i++)
                listBox1.Items.Add(s[i]);
    



        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox2_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
        public void listBox2_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
                listBox2.Items.Add(s[i]);
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox3_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
        public void listBox3_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
                listBox3.Items.Add(s[i]);
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox4_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
        public void listBox4_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
                listBox4.Items.Add(s[i]);
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox5_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
        public void listBox5_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
                listBox5.Items.Add(s[i]);
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox6_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
        public void listBox6_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
                listBox6.Items.Add(s[i]);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox5.Items.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox6.Items.Clear();
        }
    }
}

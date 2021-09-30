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

        public void Button1_Click(object sender, EventArgs e)
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
                        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer
                        {
                            URL = fileLocation
                        };
                        wplayer.controls.play();

                    }
                    else {
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

        private void Button2_Click(object sender, EventArgs e)
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
                        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer
                        {
                            URL = fileLocation
                        };

                        wplayer.controls.play();
                    }
                    else
                    {   string curItem = listBox2.SelectedItem.ToString();
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
        private void Button3_Click(object sender, EventArgs e)
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
                        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer
                        {
                            URL = fileLocation
                        };

                        wplayer.controls.play();
                    }
                    else
                    {   string curItem = listBox3.SelectedItem.ToString();
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

        private void Button4_Click(object sender, EventArgs e)
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
                        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer
                        {
                            URL = fileLocation
                        };

                        wplayer.controls.play();
                    }
                    else
                    {   string curItem = listBox4.SelectedItem.ToString();
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

        private void Button5_Click(object sender, EventArgs e)
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
                        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer
                        {
                            URL = fileLocation
                        };

                        wplayer.controls.play();
                    }
                    else
                    {
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

        private void Button6_Click(object sender, EventArgs e)
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
                        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer
                        {
                            URL = fileLocation
                        };

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
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
 

        }
        private void ListBox1_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
        public void ListBox1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length;  i++)
                listBox1.Items.Add(s[i]);
    



        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ListBox2_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
        public void ListBox2_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
                listBox2.Items.Add(s[i]);
        }

        private void ListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ListBox3_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
        public void ListBox3_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
                listBox3.Items.Add(s[i]);
        }

        private void ListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ListBox4_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
        public void ListBox4_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
                listBox4.Items.Add(s[i]);
        }

        private void ListBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ListBox5_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
        public void ListBox5_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
                listBox5.Items.Add(s[i]);
        }

        private void ListBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ListBox6_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
        public void ListBox6_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
                listBox6.Items.Add(s[i]);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            listBox5.Items.Clear();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            listBox6.Items.Clear();
        }
    }
}

﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

       //     string sample = listBox1.ToString();
            SoundPlayer splayer = new SoundPlayer(@"C:\Temp\Jingle2.wav");
                splayer.Play();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Temp\Jingle2.wav");
            splayer.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Temp\Jingle3.wav");
            splayer.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Temp\Jingle4.wav");
            splayer.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Temp\Jingle5.wav");
            splayer.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Temp\Jingle6.wav");
            splayer.Play();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void richTextBox1_DragEnter(object sender,System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
    }
}

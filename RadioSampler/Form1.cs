namespace RadioSampler
{
    using ApplicationServices.Sampler;
    using Autofac;
    using System;
    using System.Windows.Forms;

    public partial class IncapableSampler : Form
    {

        private static IContainer Container { get; set; }

        public IncapableSampler()
        {
            InitializeComponent();
            var builder = new ContainerBuilder();
            builder.RegisterInstance(new SamplerControls()).As<ISamplerControls>();
            Container = builder.Build();
        }
      
        private void ProcessButtonClick(ListBox listBox)
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                var player = scope.Resolve<ISamplerControls>();
                player.StopAnySoundPlaying();


                if (listBox.Items.Count is 0)
                {
                    MessageBox.Show("No File Clown Shoes!");
                }
                else
                {
                    if (listBox.SelectedItems.Count is 0)
                    {
                        MessageBox.Show("Stop being mean to me! select a file");
                    }
                    else
                    {
                        string curItem = listBox.SelectedItem.ToString();
                        int index = listBox.FindString(curItem);
                        listBox.SetSelected(index, true);
                        object fileLocationobj = curItem;
                        string fileLocation = fileLocationobj.ToString();

                        if (listBox.SelectedItem.ToString().EndsWith(".mp3"))
                        {
                            player.PlayWindowsMedia(fileLocation);
                        }
                        else
                        {
                            player.PlaySoundPlayer(fileLocation);
                        }
                    }
                }
            }
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            ProcessButtonClick(listBox1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ProcessButtonClick(listBox2);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ProcessButtonClick(listBox3);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ProcessButtonClick(listBox4);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ProcessButtonClick(listBox5);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            ProcessButtonClick(listBox6);
        }

        private void DragDropEvent(DragEventArgs e, ListBox listBox)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
                listBox.Items.Add(s[i]);
        }

        private void DragEnterEvent(DragEventArgs e, ListBox listBox)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ListBox1_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            DragEnterEvent(e, listBox1);
        }

        public void ListBox1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            DragDropEvent(e, listBox1);
        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ListBox2_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            DragEnterEvent(e, listBox2);
        }

        public void ListBox2_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            DragDropEvent(e, listBox2);
        }

        private void ListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ListBox3_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            DragEnterEvent(e, listBox3);
        }

        public void ListBox3_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            DragDropEvent(e, listBox3);
        }

        private void ListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ListBox4_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            DragEnterEvent(e, listBox4);
        }

        public void ListBox4_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            DragDropEvent(e, listBox4);
        }

        private void ListBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ListBox5_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            DragEnterEvent(e, listBox5);
        }

        public void ListBox5_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            DragDropEvent(e, listBox5);
        }

        private void ListBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ListBox6_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            DragEnterEvent(e, listBox6);
        }

        public void ListBox6_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            DragDropEvent(e, listBox6);
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

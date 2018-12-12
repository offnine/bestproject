using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;
using System.IO;

namespace FKK_Player
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            pictureBox2.MouseEnter += new EventHandler(pictureBox2_MouseEnter);
            pictureBox2.MouseLeave += new EventHandler(pictureBox2_MouseLeave);

            pictureBox3.MouseEnter += new EventHandler(pictureBox3_MouseEnter);
            pictureBox3.MouseLeave += new EventHandler(pictureBox3_MouseLeave);
        
            pictureBox4.MouseEnter += new EventHandler(pictureBox4_MouseEnter);
            pictureBox4.MouseLeave += new EventHandler(pictureBox4_MouseLeave);

            pictureBox1.MouseEnter += new EventHandler(pictureBox1_MouseEnter);
            pictureBox1.MouseLeave += new EventHandler(pictureBox1_MouseLeave);



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            TrackBar trackBar = new TrackBar();

            axWindowsMediaPlayer1.settings.volume = trackBar.Value;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }



    void pictureBox2_MouseEnter(object sender, EventArgs e)
    {
        this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.play));
    }


    void pictureBox2_MouseLeave(object sender, EventArgs e)
    {
        this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.play2));
    }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.pause));
        }


        void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.pause2));
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.stop));
        }


        void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.stop2));
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog.FileName;
                axWindowsMediaPlayer1.Ctlcontrols.play();

            }

        }

        void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.open1));
        }


        void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.open2));
        }

    }
}

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

namespace RussianRoulette
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kac, cephane, vur;
        Random random = new Random();
        int hak = 6;
        SoundPlayer ses = new SoundPlayer();
        SoundPlayer ses2 = new SoundPlayer();
        SoundPlayer ses3 = new SoundPlayer();
        private void Form1_Load(object sender, EventArgs e)
        {
            kac = random.Next(1,6);
            cephane = random.Next(1,6);
            vur = 6;
            label1.Text = kac.ToString();
            ses.SoundLocation = "Gunsound.wav";
            ses2.SoundLocation = "Emptygunsound.wav";
            ses3.SoundLocation = "Victory Sound Effect.wav";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            hak--;
            kac--;
            vur--;
            label3.Text = hak.ToString();
            label1.Text = kac.ToString();
            if (vur == cephane)
            {
                ses.Play();
                DialogResult dialogResult = MessageBox.Show("Do you want to try again?", "You Died!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Environment.Exit(0);
                }
            }
            ses2.Play();
            if (kac == 0)
            {
                ses3.Play();
                DialogResult dialogResult = MessageBox.Show("Do you want to try again?", "You Survived!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Environment.Exit(0);
                }
            }
           
        }
    }
}

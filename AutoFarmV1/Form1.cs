using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;


namespace RobotFarmer
{
    public partial class Form1 : Form
    {
        //class
        ImageDetection ImageDetection = new ImageDetection();
        MouseEvents MouseEvents = new MouseEvents();
        Bitmap[] bitmap_array = new Bitmap[9999];

        int[] Delay = new int[9999];

        int current_image = 1;
        int max_image = 0;
        int last_found = 0;
        bool started = false;
        bool bw_finished = true;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MouseEvents.INIT();
            ImageDetection.INIT();
            LoadAllImages();

        }

        private void LoadAllImages()
        {
            for (int x = 1; x < 999; x++)
            {
                if (File.Exists(Application.StartupPath + "//Steps//" + x.ToString() + ".png"))
                {
                    bitmap_array[x] = (Bitmap)Image.FromFile(Application.StartupPath + "//Steps//" + x.ToString() + ".png");
                    max_image = x;
                }
                else
                {
                    break;
                }
            }

            current_image = 1;
            stepsLB.Text = "Steps: " + (current_image).ToString() + " / " + max_image.ToString();


        }


        private void reloadB_Click(object sender, EventArgs e)
        {
            LoadAllImages();
            MessageBox.Show("Successfully reloaded.", "");
        }


        private bool FindNow(int img_num)
        {

            //Get Nox Screenshot
            Bitmap ScreenShot = ImageDetection.PrintWindow(MouseEvents.hWndC_Final);

            //Get Image
            Bitmap ImageToFind = bitmap_array[img_num];

            //Find
            bool found = ImageDetection.FindImageOnScreen(ImageToFind, ScreenShot);

            if (found == true)
            {
                MouseEvents.CLICKIT(ImageDetection.CurrentX, ImageDetection.CurrentY);
            }

            return found;

        }

        private void findBW_DoWork(object sender, DoWorkEventArgs e)
        {
            bw_finished = false;

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();


            bool found = FindNow(current_image);

            if (found == true)
            {

                last_found = current_image;
                current_image++;

                if (current_image > max_image)
                {
                    current_image = 1;
                }

                stepsLB.Invoke(new Action(() => stepsLB.Text = "Steps: " + current_image.ToString() + " / " + max_image.ToString()));
            }
            else
            {

                int temp = current_image + 1;

                if (temp > max_image)
                {
                    temp = 1;
                }


                bool found2 = FindNow(temp);

                if (found2 == true)
                {

                    last_found = temp;
                    current_image = temp + 1;

                    if (current_image > max_image)
                    {
                        current_image = 1;
                    }

                    stepsLB.Invoke(new Action(() => stepsLB.Text = "Steps: " + current_image.ToString() + " / " + max_image.ToString()));
                }
                else
                {
                    if (last_found != 0)
                    {
                        FindNow(last_found);

                    }
                }





            }
        }

        private void findBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bw_finished = true;
        }




        private void AutoFarmTimer_Tick(object sender, EventArgs e)
        {


            if (Delay[current_image] > 0)
            {
                AutoFarmTimer.Interval = Delay[current_image];
            }
            else
            {
                AutoFarmTimer.Interval = 1000;
            }


            if (bw_finished == true)
            {
                delayLB.Text = AutoFarmTimer.Interval.ToString() + " ms";
                findBW.RunWorkerAsync();

            }


        }



        private void startB_Click(object sender, EventArgs e)
        {
            started = !started;
            bool ok = true;

            if (started == true && ok == true)
            {
                ok = false;
                startB.Text = "Stop";
                startB.BackColor = Color.Red;
                AutoFarmTimer.Start();


            }
            if (started == false && ok == true)
            {
                ok = false;
                startB.Text = "Start";
                startB.BackColor = Color.Green;
                current_image = 1;
                stepsLB.Invoke(new Action(() => stepsLB.Text = "Steps: " + current_image.ToString() + " / " + max_image.ToString()));
                AutoFarmTimer.Stop();
            }


        }




        private void backB_Click(object sender, EventArgs e)
        {
            if (current_image != 1)
            {
                current_image--;
                stepsLB.Invoke(new Action(() => stepsLB.Text = "Steps: " + current_image.ToString() + " / " + max_image.ToString()));
            }
        }

        private void forwardB_Click(object sender, EventArgs e)
        {
            if (current_image != max_image)
            {
                current_image++;
                stepsLB.Invoke(new Action(() => stepsLB.Text = "Steps: " + current_image.ToString() + " / " + max_image.ToString()));
            }
        }

        private void addB_Click(object sender, EventArgs e)
        {
            Delay[Int32.Parse(stepNUD.Value.ToString())] = Int32.Parse(delayNUD.Value.ToString());

            MessageBox.Show("Delay added.", "");
        }

        private void resetB_Click(object sender, EventArgs e)
        {

            for (int x = 0; x < 9999; x++)
            {
                Delay[x] = 0;
            }

            MessageBox.Show("All delay has been removed.", "");

        }



    }
}

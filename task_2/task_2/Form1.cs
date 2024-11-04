using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_2
{
    public partial class Form1 : Form
    {
        private List<string> imagePaths;
        private int currentIndex;
        public Form1()
        {
            InitializeComponent();
            InitializeImageList();
            DisplayCurrentImage();
        }
        private void InitializeImageList()
        {
            // Add image paths here
            imagePaths = new List<string>
            {
                "C:\\Users\\zyadr\\source\\repos\\task_2\\task_2\\Resources\\batman-dc-superheroes-dc-comics-cosplay-3840x2160-954.jpg",
                "C:\\Users\\zyadr\\source\\repos\\task_2\\task_2\\Resources\\batman-blade-runner-2049-3840x2160-221.jpg",
                "C:\\Users\\zyadr\\source\\repos\\task_2\\task_2\\Resources\\batman-arkham-3840x2160-16093.jpg"
            };
            currentIndex = 0;
        }

        private void DisplayCurrentImage()
        {
            if (imagePaths.Count > 0)
            {
                pictureBox1.ImageLocation = imagePaths[currentIndex];
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                DisplayCurrentImage();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < imagePaths.Count - 1)
            {
                currentIndex++;
                DisplayCurrentImage();
            }
        }
    }
}

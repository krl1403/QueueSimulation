using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace QueueSimulation
{
    public partial class Form1 : Form
    {
        PictureBox[] pictureBoxes;
        Queue<PictureBox> queue;

        // Set position of the picture boxes to stop
        int maxX = 372;
        int time;

        bool processed = false;

        public Form1()
        {
            InitializeComponent();
            queue = new Queue<PictureBox>();
            pictureBoxes = new PictureBox[]{ Customer1, Customer2, Customer3, Customer4, Customer5 };
        }
        private void SetRandomX(PictureBox[] img)
        {
            // Randomly generate X coordinates for each PictureBox
            Random rnd = new Random();

            foreach (PictureBox pictureBox in img)
            {
                // Temporarily hide the picture boxes if they don't currently passed the queue gate
                pictureBox.Hide();

                // Generate a random even X coordinate between 0 and 92 
                // since 184 is close to the queue gate's X
                int randomX = rnd.Next(20, 92) * 2;

                // Set the X coordinate of the PictureBox's Location
                pictureBox.Location = new Point(randomX, pictureBox.Location.Y);
            }

            // Check for collisions and adjust X coordinates if detected
            bool collisionDetected;
            do
            {
                collisionDetected = false;

                // Check for collisions between each pair of PictureBoxes
                for (int i = 0; i < pictureBoxes.Length - 1; i++)
                {
                    for (int j = i + 1; j < pictureBoxes.Length; j++)
                    {
                        if (pictureBoxes[i].Bounds.IntersectsWith(pictureBoxes[j].Bounds))
                        {
                            collisionDetected = true;
                            // Adjust X coordinates to prevent overlap
                            pictureBoxes[i].Left += 10;
                            pictureBoxes[j].Left -= 10;
                        }
                    }
                }
            } while (collisionDetected);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label7.Text = "1. If a customer passes the \"Queue Gate\", it will be added to the Queue data structure using Enqueue() method." + Environment.NewLine + Environment.NewLine
                + "2. The queue data structure will then be added to the Queue list and then display the current queue." + Environment.NewLine + Environment.NewLine
                + "3. If one of the customers reached the designated X coordinate, the movement will stop and then process the current customer. " +
                "it will be concatenated to the processing text using the Peek() method from the queue data structure." + Environment.NewLine + Environment.NewLine 
                + "5. If the customer is done check out, it will dequeue be dequeued from the Queue using Dequeue() method." +
                " It will then be added to the processed list while updating the queue list.";
                
            // Add the image to each picture box
            Customer1.Image = Image.FromFile("D:\\C#\\C#\\Coding Challenges\\Data Structures\\QueueSimulation\\img\\kenet.jpg");
            Customer2.Image = Image.FromFile("D:\\C#\\C#\\Coding Challenges\\Data Structures\\QueueSimulation\\img\\jp.jpg");
            Customer3.Image = Image.FromFile("D:\\C#\\C#\\Coding Challenges\\Data Structures\\QueueSimulation\\img\\war.jpg");
            Customer4.Image = Image.FromFile("D:\\C#\\C#\\Coding Challenges\\Data Structures\\QueueSimulation\\img\\jus.jpg");
            Customer5.Image = Image.FromFile("D:\\C#\\C#\\Coding Challenges\\Data Structures\\QueueSimulation\\img\\ange.jpg");

            SetRandomX(pictureBoxes);
        }

        private void MoveColor(PictureBox pic)
        {
            // Move the imgs to the right
            pic.Left += 2;

            // Check if the x coordinate of pic is within the range of x coordinate of queue gate
            int cmp = 1;
            if (Math.Abs(pic.Location.X - QueueGate.Location.X) <= cmp)
            {
                // if true, show the image passing the queue gate
                pic.Show();

                // Add the pic to queue
                queue.Enqueue(pic);
                
                // Update the queue list box based on the current items on the queue
                UpdateQueueList();
            }

            if (pic.Location.X == maxX)
            {
                // If the x coordinate of the img is equal to the max x coordinate, stop the timer
                timer1.Stop();
            }
        }

        private void Validation(PictureBox pic)
        {
            // If the picture box's x coordinate is the same as max X variable
            // create a new variable with the value of the current top of 
            // queue using Peek() method and add it's name to the processing text.
            if (pic.Location.X == maxX)
            {
                var current = queue.Peek();
                label2.Text += $" {current.Name}";

                // Generate a random time and start the timer
                time = GenerateTime();
                progressBar1.Maximum = time - 1;
                timer2.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PictureBox[] pictureBoxesToValidate = { Customer1, Customer2, Customer3, Customer4, Customer5 };

            // Move the picture boxes. If not processed, use the Validate method
            foreach (PictureBox pictureBox in pictureBoxesToValidate)
            {
                MoveColor(pictureBox);

                if (!processed)
                    Validation(pictureBox);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // Decrement the random time generated
            progressBar1.Increment(1);
            time--;

            // If time reaches 0, stop the timer
            if (time == 0)
            {
                timer2.Stop();

                // Set the label to processing text
                label2.Text = "Processing: ";

                // Create a new variable and assign the value from the dequeued item in the queue.
                var processedItem = queue.Dequeue();

                // Add the variable to the processed list
                lstProcessed.Items.Add(processedItem.Name);

                // Update the queue list since one item is dequeued
                UpdateQueueList();

                // Hide the picture box if processing is done
                HideImage(processedItem);
                progressBar1.Value = 0;

                // Start the timer to begin again the moving of images
                timer1.Start();
            }
        }

        private void UpdateQueueList()
        {
            // Clear the list
            lstQueue.Items.Clear();

            // If queue count is greater than 0, add them to the list
            // otherwise, display prompt
            if (queue.Count > 0)
            {
                foreach (PictureBox p in queue)
                {
                    lstQueue.Items.Add(p.Name);
                }
            }
            else
            {
                MessageBox.Show("No customers in Queue.", "End of Queue", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int GenerateTime()
        {
            // Generate random time from 5-10 used in processing
            Random rnd = new Random();

            return rnd.Next(5, 11); ;
        }

        private void HideImage(PictureBox pic)
        {
            pic.Hide();
        }
    }
}

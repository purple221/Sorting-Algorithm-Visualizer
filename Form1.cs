using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sort2
{
    public partial class Form1 : Form
    {
        //initialize the array to be sorted
        int[] TheArray;
        //initialize the graphic for visualization
        Graphics g;


        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //closes the program
            this.Close(); 
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //creates the graphic
            g = panel1.CreateGraphics();
            //assign and initialize the number of entries (width)
            int NumEntries = panel1.Width;
            //assign and initialize the maximum height (height)
            int MaxVal = panel1.Height;
            //assigns the array with numbers of entries based on the width of the panel
            TheArray = new int[NumEntries];
            //fills the entire panel with black paint
            g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), 0, 0, NumEntries, MaxVal);
            //initializes and assigns a new random
            Random rand = new Random();
            //using a for loop to assign NumEntries of stripes to be sorted
            for(int i = 0; i < NumEntries; i++)
            {
                //assigns the array's value at index i to a random integer between 0 and MaxVal
                TheArray[i] = rand.Next(0, MaxVal);
            }
            //using the same for loop as above to draw NumEntries of stripes
            for(int i = 0; i < NumEntries; i++)
            {
                //draws a rectangular stripe using the random values as height that were assigned to the array using the for loop above
                //specifically, creating a stripe with (x,y) as the top left corner, the width, and the height
                g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.White), i, MaxVal - TheArray[i], 1, MaxVal);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ISortEngine se = new SortEngineBubblecs();

            //ISortEngine se = new SortEngineSelectionSort();

            ISortEngine se = new SortEngineInsertionSort();
            se.DoWork(TheArray, g, panel1.Height);
        }
    }
}

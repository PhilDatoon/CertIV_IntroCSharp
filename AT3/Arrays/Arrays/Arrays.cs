// Datoon, Philip Bryan B.
// 131311399
// 28 August 2013
// Using arrays and multi-dimensional arrays in Windows form (pp 209-224)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Arrays : Form
    {
        public Arrays()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // clears listBox contents
            listBox1.Items.Clear();

            // declaration of array
            int[] lottery_numbers;
            lottery_numbers = new int[1000];
            
            for (int i = 0; i != (lottery_numbers.Length); i++)
            {
                lottery_numbers[i] = i + 1;
                // displaying elements in listBox
                listBox1.Items.Add(lottery_numbers[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {   // clears listbox contents
            listBox1.Items.Clear();

            // parses string to integers
            int aNumber = int.Parse(textBox1.Text);

            // declares array
            int[] arraySize;
            arraySize = new int[aNumber];

            for (int i = 0; i != (arraySize.Length); i++)
            {
                arraySize[i] = i + 1;
                // displaying elements in listBox
                listBox1.Items.Add(arraySize[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {   // clears listbox items
            listBox1.Items.Clear();

            // declaration of array
            int[] aryTimes;
            aryTimes = new int[10];

            // parses textbox text to int
            int times = int.Parse(textBox1.Text);

            for (int i = 0; i != (aryTimes.Length); i++)
            {
                aryTimes[i] = (i + 1) * times;
                // displaying elements in listBox
                listBox1.Items.Add(times + " times " + (i + 1) + " = " + aryTimes[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {   // clears listbox contents
            listBox1.Items.Clear();

            int arrayRows = 5;  // holds value for number of rows
            int arrayCols = 3;  // holds value for number of columns

            // declaration of multidimensional array
            int[,] arrayTimes;
            arrayTimes = new int[arrayRows, arrayCols];

            int mult = 0;

            for (int i = 0; i != arrayRows; i++)
            {
                mult = mult + 10;

                for (int j = 0; j != arrayCols; j++)
                {
                    arrayTimes[i, j] = mult;
                    mult = mult * 10;
                    // displaying elements in listBox
                    listBox1.Items.Add("arrayPos = " + i + ", " + j + " val = " + arrayTimes[i,j]);
                }

                mult = mult / 1000;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {   // clears listbox contents
            listBox1.Items.Clear();

            // declaration of array
            String[] arrayStrings;
            arrayStrings = new String[5];

            // assigning values to each array element
            arrayStrings[0] = "This";
            arrayStrings[1] = "is";
            arrayStrings[2] = "a";
            arrayStrings[3] = "string";
            arrayStrings[4] = "array";

            // displaying elements in listBox using foreach loop
            foreach (String arrayElement in arrayStrings)
            {
                listBox1.Items.Add(arrayElement);
            }
        }
    }
}

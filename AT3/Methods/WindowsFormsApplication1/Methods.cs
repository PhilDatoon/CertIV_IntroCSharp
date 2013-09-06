// Datoon, Philip Bryan B.
// 131311399
// 28 August 2013
// Using and calling methods in Windows form (pp 199-209)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Methods : Form
    {
        public Methods()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;

            // parses string to integer
            number1 = int.Parse(textBox1.Text);
            number2 = int.Parse(textBox2.Text);

            // calling AddUp() method and passing integer values to it
            AddUp(number1, number2);
        }

        void AddUp(int firstNumber, int secondNumber)
        {   // performs addition of two integers
            int answer;

            answer = firstNumber + secondNumber;

            // displays result on message box
            MessageBox.Show(answer.ToString());

            return;
        }

        private int Subtract(int firstNumber, int secondNumber)
        {   // performs subtraction of two integers
            int answer;

            answer = firstNumber - secondNumber;

            // return subtraction result
            return answer;
        }

        void Multiply(int firstNumber, int secondNumber)
        {   // performs multiplication of two integers
            int answer;
            
            answer = firstNumber * secondNumber;

            // displays result in message box
            MessageBox.Show(answer.ToString());

            return;
        }

        private int Divide(int firstNumber, int secondNumber)
        {   // performs division of two integers
            int answer;

            answer = firstNumber / secondNumber;
            
            // returns results
            return answer;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            int returnValue = 0;

            // parses string to int
            number1 = int.Parse(textBox1.Text);
            number2 = int.Parse(textBox2.Text);

            /* calling Subtract() method, passing integer values to it
             * then gets the value returned from the method and store it
             * to returnValue variable
             */
            returnValue = Subtract(number1, number2);

            // displays result in message box
            MessageBox.Show(returnValue.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;

            // parses string to int
            number1 = int.Parse(textBox1.Text);
            number2 = int.Parse(textBox2.Text);
            
            // calling Multiply() method and passing integer values to it
            Multiply(number1, number2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            int returnValue = 0;

            // parses string to int
            number1 = int.Parse(textBox1.Text);
            number2 = int.Parse(textBox2.Text);

            /* calling Divide() method, passing integer values to it
             * then gets the value returned from the method and store it
             * to returnValue variable
             */
            returnValue = Divide(number1, number2);

            // displays result in message box
            MessageBox.Show(returnValue.ToString());
        }
    }
}

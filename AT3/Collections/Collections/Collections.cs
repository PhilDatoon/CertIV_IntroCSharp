// Datoon, Philip Bryan B.
// 131311399
// 30 August 2013
// Using Lists and Enumerations in Windows forms (pp 224-235)

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collections
{
    public partial class Collections : Form
    {
        public Collections()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // creates list
            List<string> students = new List<string>();

            // adds items on list
            students.Add("Jenny");
            students.Add("Peter");
            students.Add("Mary Jane");

            // sorts list alphabetically
            students.Sort();

            // sorts list in descending order
            students.Reverse();

            // removes items on the list based on item range
            //students.RemoveRange(0, 2);

            listBox1.Items.Add("===================");

            foreach (string child in students)
            {   // accesses and displays items in students list in listbox
                listBox1.Items.Add(child);
            }

            students.Add("Azhar");
            listBox1.Items.Add("New item = " + students[3]);
        }

        private void button2_Click(object sender, EventArgs e)
        {   // uses hashtable that creates new object
            Hashtable students = new Hashtable();

            // adds data to the hashtable
            students["Jenny"] = 87;
            students["Peter"] = "No score";
            students["Mary Jane"] = 64;
            students["Azhar"] = 79;

            // removing specific item using key name "Peter"
            students.Remove("Peter");
            
            foreach (DictionaryEntry child in students)
            {   // DictionaryEntry returns key and value
                listBox1.Items.Add("Student : " + child.Key +
                    ", Score: " + child.Value);
            }
        }

        // declares enumeration
        enum Subjects { English, IT, Science, Design, Math };

        private void button3_Click(object sender, EventArgs e)
        {   // uses the enumerated list "Science"
            Subjects newSubject = Subjects.Science;

            // gets the underlying number of the enumerated item
            int enumNumber = (int)newSubject;

            for (int i = 0; i < 4; i++)
            {
                if (i == 2)
                {   // displays MessageBox
                    MessageBox.Show("You're taking Science.");
                }
            }

            // displays MessageBox
            MessageBox.Show(newSubject.ToString());
        }
    }
}

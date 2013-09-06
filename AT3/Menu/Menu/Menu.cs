// Datoon, Philip Bryan B.
// 131311399
// 14 August 2013
// Adding menus in Windows form (pp 143-178)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {   // confirms if user really wants to quit program
            if (MessageBox.Show("Really quit?", "Exit",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {   // exits program
                Application.Exit();
            }
        }

        private void mnuCut_Click(object sender, EventArgs e)
        {   // performs cutting texts function
            if (textBox1.SelectedText != "")
            {
                textBox1.Cut();
            }
        }

        private void mnuUndo_Click(object sender, EventArgs e)
        {   // performs Undo function
            if (textBox1.CanUndo == true)
            {
                textBox1.Undo();
                textBox1.ClearUndo();
            }
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {   // performs copying texts function
            if (textBox1.SelectionLength > 0)
            {
                textBox1.Copy();
            }
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {   // performs pasting texts function
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                textBox2.Paste();
                Clipboard.Clear();
            }
        }

        private void mnuViewTextBoxes_Click(object sender, EventArgs e)
        {   // adds check mark next to View Text Boxes menu item
            mnuViewTextBoxes.Checked = !mnuViewTextBoxes.Checked;

            if (mnuViewTextBoxes.Checked == true)
            {   // displays textboxes
                textBox1.Visible = true;
                textBox2.Visible = true;
            }
            else
            {   // hides textboxes
                textBox1.Visible = false;
                textBox2.Visible = false;
            }
        }

        private void mnuViewImages_Click(object sender, EventArgs e)
        {   // opens a dialogs allowing user to browse or to open files
            string Chosen_File = "";

            // title of the dialog box
            openFD.Title = "Insert an Image.";

            // displays initial directory
            openFD.InitialDirectory = "C:";
            // openFD.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal); // folder path to My Documents

            // sets initial file name to appear in dialog box
            openFD.FileName = "";

            // sets file extension allowed to open
            openFD.Filter = "JPEG Images|*.jpg|All files|*.*";

            openFD.ShowDialog();                // shows dialog box

            if (openFD.ShowDialog() == DialogResult.Cancel)
            {   // "bugs out" - displays when cancel button is clicked on dialog box
                MessageBox.Show("Operation Cancelled.");
            }
            else
            {   // gets the file name selected to open
                Chosen_File = openFD.FileName;

                // displays selected image on the picturebox element
                pictureBox1.Image = Image.FromFile(Chosen_File);
            }
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {   
            string Chosen_File = "";
            openFD.InitialDirectory = "C:";
            openFD.Title = "Open a text file";

            // sets initial file name to appear in dialog box
            openFD.FileName = "";

            // sets file extension allowed to open
            openFD.Filter = "Text files|*.txt|Word documents|*.doc";

            if (openFD.ShowDialog() != DialogResult.Cancel)
            {   // loads contents of the file to richTextBox when "Open" button is clicked
                Chosen_File = openFD.FileName;
                richTextBox1.LoadFile(Chosen_File, RichTextBoxStreamType.PlainText);
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {   // Save works like Open menu item
            String Saved_File = "";

            saveFD.InitialDirectory = "C:";
            saveFD.Title = "Save a text file";
            saveFD.FileName = "";

            saveFD.Filter = "Text files|*.txt|All files|*.*";

            if (saveFD.ShowDialog() != DialogResult.Cancel)
            {   // saves the contents of the richTextBox
                Saved_File = saveFD.FileName;
                richTextBox1.SaveFile(Saved_File, RichTextBoxStreamType.PlainText);
            }

        }
    }
}

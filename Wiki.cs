using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Wiki_Prototype_Application
{
    public partial class Wiki : Form
    {
        public Wiki()
        {
            InitializeComponent();
        }
        //6.2 Create a global List<T> of type Information called Wiki.
        List<Information> wiki = new List<Information> ();

        #region Add, Edit, Delete
        //6.5 Create a custom ValidName method which will take a parameter string value from the Textbox Name 
        private bool ValidName(string Name)
        {
            return (wiki.Exists(duplicate => duplicate.getName() == Name));

        }
        //6.3 Create a button method to ADD a new item to the list.Use a TextBox for the Name input,
        //ComboBox for the Category, Radio group for the Structure and Multiline TextBox for the Definition.
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool Linear = rbLinear.Checked;
            Add(textBoxName.Text, comboBoxCategory.Text, Linear, textBoxDefinition.Text);
            clearTextBox();
        }
        private void Add(string Name, string Category, bool Linear, string Definition)
        {
            Console.WriteLine(ValidName(Name));
            if ((!ValidName(Name) && (Category != "") && (Definition != "")))
            {
                Information info = new Information(Name, Category, Linear, Definition);
                wiki.Add(info);
                clearTextBox();
            }
            else
            {
                MessageBox.Show("Please Enter information into all fields");
            }
            displayDataStructures();
            Bubble_Sort();
        }
        //6.8 Create a button method that will save the edited record of the currently selected item in the ListView
        private void buttonEdit_Click(object sender, EventArgs e)
        {
           
            try 
            {
                int rec = listViewDisplay.SelectedIndices[0];
                if (rec != -1)
                {
                   var result = MessageBox.Show("Proceed with update?", "Edit Record",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                   if (result == DialogResult.OK)
                   {
                        bool Linear = rbLinear.Checked;
                        Edit(textBoxName.Text, comboBoxCategory.Text, Linear, textBoxDefinition.Text, rec);
                        Display(rec);
                   }
                }
                else
                {
                    MessageBox.Show("you need to select an item from the box before you can edit it.");
                }
                displayDataStructures();
            }
            catch
            {
                MessageBox.Show("index was out of bounds");
            }
            
             
        }
        
        private void Edit(string Name, string Category, bool Linear, string Definition, int rec)
        {
            if ((Name != "") && (Category != "") && (Definition != ""))
            {
                wiki[rec] = new Information(Name, Category, Linear, Definition);
                clearTextBox();
                Bubble_Sort();
            }
            else
            {
                MessageBox.Show("you need to fill all of the input boxes with information, they cannot be empty");
            }
        }

        //6.7 Create a button method that will delete the currently selected record in the ListView. 
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
            int rec = listViewDisplay.SelectedIndices[0];
            Delete(rec);
            
        }
        private void Delete(int rec)
        {
            try
            {
                DialogResult DeleteDefinition = MessageBox.Show("are you sure you want to delete this Record? " + wiki[rec].getName(), "confirmation",
                                                                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (DeleteDefinition == DialogResult.Yes)
                {
                    wiki.RemoveAt(rec);

                    displayDataStructures();
                    clearTextBox();
                    Bubble_Sort();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Display, Clear
        //8.6	Create a display method that will show the following information in a List View: Name and Category,
        private void displayDataStructures()
        {
    
            listViewDisplay.Items.Clear();
            foreach (Information rec in wiki)
            {
                ListViewItem rec1 = new ListViewItem(rec.getName());
                rec1.SubItems.Add(rec.getCategory());
                listViewDisplay.Items.AddRange(new ListViewItem[] { rec1 });
                if (rec.getStructure() == "Linear")
                {
                    rbLinear.Checked = true;
                    rbNonLinear.Checked = false;               
                }
                else
                {
                    rbLinear.Checked = false;
                    rbNonLinear.Checked = true;
                }
                comboBoxCategory.Text = rec.getCategory();
            }
            
        }
        //8.7	Create a method so the user can select a definition (Name) from the Listbox and all the information
        //is displayed in the appropriate Textboxes,
        
        private void Display(int rec)
        {
            clearTextBox();
           
            try
            {
                textBoxName.Text = wiki[rec].getName();
                comboBoxCategory.Text = wiki[rec].getCategory();
                textBoxDefinition.Text = wiki[rec].getDefinition();
                if (wiki[rec].getbStructure())
                {
                    rbLinear.Checked = true;
                }
                else
                {
                    rbNonLinear.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("file not loaded " + ex.Message);
            }

        }
         
        //6.11 Create a ListView event so a user can select a Data Structure Name from the list of Names
        //and the associated information will be displayed in the related text boxes combo box and radio button.
        private void listViewDisplay_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int item = listViewDisplay.SelectedIndices[0];
            Display(item);
        }
        //6.13 Create a double click event on the Name TextBox to clear the TextBboxes,
        //ComboBox and Radio button.
        private void clearTextBox()
        {
            textBoxName.Clear();
            comboBoxCategory.ResetText();
            rbLinear.Checked = false;
            rbNonLinear.Checked = false;
            textBoxStructure.Clear();
            textBoxDefinition.Clear();
            textBoxSearch.Clear();
        }
        #endregion

        #region Sort, Search
        private void buttonSort_Click(object sender, EventArgs e)
        {
            Bubble_Sort();
        }
        //6.9 Create a single custom method that will sort and then display the Name and Category from the wiki information in the list.
        private void Bubble_Sort()
        {
            wiki.Sort();
            displayDataStructures();
        }
        //6.10 Create a button method that will use the builtin binary search to find a Data Structure name
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
            if (Search(textBoxSearch.Text))
            {
                MessageBox.Show("Found");
                Information info = new Information(textBoxSearch.Text, "0", false, "0");
            }
            else
            {
                MessageBox.Show("Not found");
            }
            textBoxSearch.Clear();
        }
        private bool Search(string Name)
        {
            Bubble_Sort();
            Information info = new Information(Name, "0", true, "0");
            int rec = wiki.BinarySearch(info);
            if (wiki.BinarySearch(info) < 0)
            {
                return false;
            }
            else
            {
                listViewDisplay.Items[rec].Selected = true;
            }
            Display(rec);
            return true;
        }
        #endregion

        #region Open, Save, Initialise, Reset
        //6.14 Create two buttons for the manual open and save option; this must use a dialog box
        //to select a file or rename a saved file. All Wiki data is stored/retrieved using a
        //binary file format.
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            Reset();
            Open();
        }
        private void Open()
        {
            using (OpenFileDialog OpenFile = new OpenFileDialog())
            {
                if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    string fileName = OpenFile.FileName;

                    try
                    {
                        OpenLoad(fileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            
        }
        private void OpenLoad(string fileName)
        {
            
            listViewDisplay.Items.Clear();
            FileStream fs = new FileStream(fileName, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            
            try
            {
                while (fs.Position < fs.Length)
                {
                    string Name = br.ReadString();
                    string Category = br.ReadString();
                    bool Structure = br.ReadBoolean();
                    string Definition = br.ReadString();
                    Information read = new Information(Name, Category, Structure, Definition);
                    wiki.Add(read);
                   
                }
                fs.Close();
             
            }
            catch (Exception fe)
            {
                MessageBox.Show("Cannot read data from file or EOF " + fe);
                
            }
            displayDataStructures();

           
        }
        //8.8	Create a SAVE button so the information from the 2D array can be written into
        //a binary file called definitions.dat which is sorted by Name,
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Bubble_Sort();
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;
                SaveFile(fileName);
            }
             
        }
        private void SaveFile(string fileName)
        {
            Bubble_Sort();
            BinaryWriter bw;
            bw = new BinaryWriter(new FileStream(fileName, FileMode.Create));
            try
            {
                foreach (Information rec in wiki)
                {
                    bw.Write(rec.getName());
                    bw.Write(rec.getCategory());
                    bw.Write(rec.getbStructure());
                    bw.Write(rec.getDefinition());
                    Console.WriteLine("Saved");
                }
            }
            catch (Exception fe)
            {
                MessageBox.Show(fe.Message + "\n Cannot write data to file.");
                return;
            }
            bw.Close();

        }
        private void Save_Close()
        {
            try
            {
                SaveFile("definitions101.dat");
            }
            catch (Exception ex)
            {
                MessageBox.Show("file Failed to save on close " + ex.Message);
            }
        }
        //Populates the array with the saved definitions.dat file
        private void buttonInitialise_Click(object sender, EventArgs e)
        {
            Reset();
            OpenLoad("definitions.dat");
        }
        //Reset button to clear textboxes and the listview of Data Structure information.
        private void Reset()
        {
            listViewDisplay.Items.Clear();
            clearTextBox();
            wiki = new List<Information>();
            displayDataStructures();
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        #endregion
        
        #region Double Click
        private void textBoxName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            clearTextBox();

        }

        private void textBoxCategory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            clearTextBox();

        }

        private void textBoxStructure_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            clearTextBox();

        }

        private void textBoxDefinition_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            clearTextBox();
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            clearTextBox();
        }

        #endregion
        
        private void Wiki_Load(object sender, EventArgs e)
        {
            OpenLoad("definitions.dat");
        }
        private void Wiki_Close(object sender, EventArgs e)
        {
            Save_Close();
        }
        
    }
}


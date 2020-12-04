/*
Karter Ence
Your To-do List
12/3/2020
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoListKE
{
    public partial class Form1 : Form
    {
        LinkedList<string> todoList = new LinkedList<string>();

        public Form1()
        {
            InitializeComponent();
        }

        public void DisplayList()
        {
            //Reset text
            ItemTextBox.Clear();
            ToDoListBox.Items.Clear();

            //Go through each item in todoList and add it to ToDoListBox
            foreach (string x in todoList)
            {
                ToDoListBox.Items.Add(x);
            }
        }

        private void ToDoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddFrontButton_Click(object sender, EventArgs e)
        {
            //If there is text in the text box, add it to the front of todoList
            if (ItemTextBox.Text != "")
            {
                todoList.AddFirst(ItemTextBox.Text);
                DisplayList();
            }
        }

        private void AddBackButton_Click(object sender, EventArgs e)
        {
            //If there is text in the text box, add it to the back of todoList
            if (ItemTextBox.Text != "")
            {
                todoList.AddLast(ItemTextBox.Text);
                DisplayList();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Reset the list
            todoList.Clear();
            DisplayList();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            //Remove the currently selected item in the list box from todoList
            String removeItem = ToDoListBox.Text;
            todoList.Remove(removeItem);
            DisplayList();
        }
    }
}

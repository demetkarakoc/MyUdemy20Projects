using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project10_ToDoList
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }

        DataTable todoList = new DataTable();
        bool isEditing = false;

        private void ToDoList_Load(object sender, EventArgs e)
        {
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");

            toDoListView.DataSource = todoList;

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            titleTextbox.Text = "";
            descriptionTextbox.Text = "";
           
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            isEditing = true;

            titleTextbox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            descriptionTextbox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                todoList.Rows[toDoListView.CurrentCell.RowIndex].Delete();
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Error:" + ex);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(isEditing)
            {
                todoList.Rows[toDoListView.CurrentCell.RowIndex]["Title"]=titleTextbox.Text;
                todoList.Rows[toDoListView.CurrentCell.RowIndex]["Description"] = descriptionTextbox.Text;
            }
            else
            {
               todoList.Rows.Add(titleTextbox.Text, descriptionTextbox.Text);
            }

            titleTextbox.Text = "";
            descriptionTextbox.Text = "";
            isEditing = false;
        }
    }
}

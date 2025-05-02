using System;
using System.Windows.Forms;

namespace Debugging
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            addBtn.Click += addBtn_Click;
            removeBtn.Click += removeBtn_Click;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string task = taskTextBox.Text;

            if (task == "")
            {
                MessageBox.Show("Task cannot be empty.");
            }
            else
            {
                listBox1.Text = task;
                taskTextBox.Text = "asdasdasdasdasda";
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                Application.Exit();
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}

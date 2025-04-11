namespace Debugging
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addBtn = new Button();
            label1 = new Label();
            taskTextBox = new TextBox();
            listBox1 = new ListBox();
            removeBtn = new Button();
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.Location = new Point(184, 142);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(80, 32);
            addBtn.TabIndex = 3;
            addBtn.Text = "Add New";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(162, 45);
            label1.Name = "label1";
            label1.Size = new Size(130, 32);
            label1.TabIndex = 4;
            label1.Text = "To-Do List";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // taskTextBox
            // 
            taskTextBox.Location = new Point(162, 98);
            taskTextBox.Name = "taskTextBox";
            taskTextBox.PlaceholderText = "Text";
            taskTextBox.Size = new Size(130, 25);
            taskTextBox.TabIndex = 5;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(12, 221);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(434, 276);
            listBox1.TabIndex = 6;
            // 
            // removeBtn
            // 
            removeBtn.Location = new Point(12, 183);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(80, 32);
            removeBtn.TabIndex = 7;
            removeBtn.Text = "Remove Task";
            removeBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(458, 513);
            Controls.Add(removeBtn);
            Controls.Add(listBox1);
            Controls.Add(taskTextBox);
            Controls.Add(label1);
            Controls.Add(addBtn);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button addBtn;
        private Label label1;
        private TextBox taskTextBox;
        private ListBox listBox1;
        private Button removeBtn;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Form f1 = new Form(); // Create a new form
            Button b = new Button(); // Create a button
            b.Text = "OK"; // That button has a word in it which is OK
            b.Click += new EventHandler(b_Click); // Add an event when that button is Click on
            b.Location = new Point(10, 10); // Put the location of the button
            Button b1 = new Button(); // Create another button
            b1.Text = "Exit"; // Name it Exit
            b1.Click += new EventHandler(b1_Click); // Add an event for it
            b1.Location = new Point(b.Left, b.Height + b.Top + 10); // Point out its location using the other button
            f1.Controls.Add(b); // Add the 1st button to the form
            f1.Controls.Add(b1); // 2nd one
            f1.Text = "2 Paint Event"; // Name the form
            f1.BackColor = Color.White; // Decide the background color of the form
            f1.AcceptButton = b; // 
            f1.CancelButton = b1;
            Application.Run(f1);
        }
        static void b_Click(Object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }
        static void b1_Click(Object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

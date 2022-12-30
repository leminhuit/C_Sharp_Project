using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pBoxHabit_Click(object sender, EventArgs e)
        {
            HabitForm habit = new HabitForm();
            habit.Show();
        }

        private void pBoxExpense_Click(object sender, EventArgs e)
        {
            YourExpense expense = new YourExpense();
            expense.Show();
        }

        private void pBoxMusic_Click(object sender, EventArgs e)
        {
            YourMusic music = new YourMusic();
            music.Show();
        }

        private void pBoxDeadline_Click(object sender, EventArgs e)
        {
            PlansAndDeadlines plan = new PlansAndDeadlines();
            plan.Show();
        }

        private void guna2CirclePictureBox5_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
        }
    }
}

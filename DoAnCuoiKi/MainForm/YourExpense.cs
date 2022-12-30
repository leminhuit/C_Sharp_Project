using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class YourExpense : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        public SqlDataReader dr2;
        public int holder = 0;

        public YourExpense()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadData();
            LoadMaxExpenseForFood();
        }

        private void BuildMMS_Click(object sender, EventArgs e)
        {
            changingTextbox.Text = "1. Evaluate your spending before building a budget"
                + Environment.NewLine +
                "2. Set a monthly budget"
                + Environment.NewLine +
                "3. Track your spending on an ongoing basis"
                + Environment.NewLine +
                "4. Pay for day-to-day expenses with cash ";
        }

        private void changeMindset_Click(object sender, EventArgs e)
        {
            changingTextbox.Text = "1. Don't play the comparison game"
           + Environment.NewLine +
           "2. Try to curb emotional spending"
           + Environment.NewLine +
           "3. Delay gratification"
           + Environment.NewLine +
           "4. Don't buy according to trends";
        }

        private void insourceEverydaySpending_Click(object sender, EventArgs e)
        {
            changingTextbox.Text = "1. Reduce or eliminate dining out"
            + Environment.NewLine +
            "2. Prepare coffee at home"
            + Environment.NewLine +
            "3. Do your own personal grooming"
            + Environment.NewLine +
            "4. Clean your car at home"
            + Environment.NewLine +
            "5. Avoid professional dry cleaners";
        }

        private void adjustShoppingHabits_Click(object sender, EventArgs e)
        {
            changingTextbox.Text = "1. Buy in bulk"
            + Environment.NewLine +
            "2. Shop secondhand"
            + Environment.NewLine +
            "3. Buy less"
            + Environment.NewLine +
            "4. Compare prices"
            + Environment.NewLine +
            "5. Borrow instead of buying";
        }

        private void saveMoneyInTheFuture_Click(object sender, EventArgs e)
        {
            changingTextbox.Text = "1. Go online to spend less on vacation"
           + Environment.NewLine +
           "2. Buy a more fuel-efficient vehicle"
           + Environment.NewLine +
           "3. Keep appliance documentation"
           + Environment.NewLine +
           "4. Choose a high-interest bank account";
        }

        private void ClearAllFields()
        {
            txtExpenseName.Clear();
            txtExpenseAmount.Clear();
            cboCategory.SelectedIndex = 0;
            txtExpenseDescription.Clear();
        }

        private void LoadData()
        {
            cn.Open();
            cm = new SqlCommand("SELECT DISTINCT YEAR(ExpenseDate) FROM tbExpense", cn);
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cboYear.Items.Add(dr[0]);
            }
            dr.Close();
            cn.Close();
            LoadMaxExpenseForFood();
            LoadMaxExpenseForGoingOut();
            LoadMaxExpenseForMedical();
            LoadMaxExpenseForOthers();
            LoadMaxExpenseForShopping();
        }

        private void LoadDataGridView()
        {
            dgvExpenseReport.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT ExpenseName, ExpenseAmount, ExpenseCategory, ExpenseDate, ExpenseDescription FROM tbExpense WHERE MONTH(ExpenseDate) = @MONTH AND YEAR(ExpenseDate) = @YEAR", cn);
            cm.Parameters.AddWithValue("@MONTH", cboMonth.Text);
            cm.Parameters.AddWithValue("@YEAR", cboYear.Text);
            dr2 = cm.ExecuteReader();
            while (dr2.Read())
            {
                dgvExpenseReport.Rows.Add(dr2["ExpenseName"].ToString(),
                    dr2["ExpenseAmount"].ToString(),
                    dr2["ExpenseCategory"].ToString(),
                    dr2["ExpenseDate"].ToString(),
                    dr2["ExpenseDescription"].ToString());
            }
            dr2.Close();
            cn.Close();
        }

        private void btnSaveDetails_Click(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("INSERT INTO tbExpense(ExpenseName, ExpenseAmount, ExpenseCategory, ExpenseDate, ExpenseDescription)VALUES(@ExpenseName, @ExpenseAmount, @ExpenseCategory, @ExpenseDate, @ExpenseDescription)", cn);
            cm.Parameters.AddWithValue("@ExpenseName", txtExpenseName.Text);
            cm.Parameters.AddWithValue("@ExpenseAmount", txtExpenseAmount.Text);
            cm.Parameters.AddWithValue("@ExpenseCategory", cboCategory.Text); ;
            cm.Parameters.AddWithValue("@ExpenseDate", datetimeValue.Value.ToShortDateString());
            cm.Parameters.AddWithValue("@ExpenseDescription", txtExpenseDescription.Text);
            cm.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Expense Details Saved", "Your Expense");
            ClearAllFields();
        }

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboYear.SelectedIndex == -1) return;
            else LoadDataGridView();
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMonth.SelectedIndex == -1) return;
            else LoadDataGridView();
        }

        private void YourExpense_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadMaxExpenseForFood()
        {
            cn.Open();
            cm = new SqlCommand("SELECT SUM(ExpenseAmount) as Total FROM tbExpense WHERE ExpenseCategory = 'Food'AND MONTH(ExpenseDate) = @MONTH AND YEAR(ExpenseDate) = @YEAR", cn);
            cm.Parameters.AddWithValue("@MONTH", DateTime.Now.Month);
            cm.Parameters.AddWithValue("@YEAR", DateTime.Now.Year);
            dr2 = cm.ExecuteReader();
            while (dr2.Read())
            {
                FoodMaxValue.Text = dr2["Total"].ToString();
            }
            dr2.Close();
            cn.Close();
        }

        private void LoadMaxExpenseForGoingOut()
        {
            cn.Open();
            cm = new SqlCommand("SELECT SUM(ExpenseAmount) as Total FROM tbExpense WHERE ExpenseCategory = 'Going Out'AND MONTH(ExpenseDate) = @MONTH AND YEAR(ExpenseDate) = @YEAR", cn);
            cm.Parameters.AddWithValue("@MONTH", DateTime.Now.Month);
            cm.Parameters.AddWithValue("@YEAR", DateTime.Now.Year);
            dr2 = cm.ExecuteReader();
            while (dr2.Read())
            {
               GoingOutMaxValue.Text = dr2["Total"].ToString();
            }
            dr2.Close();
            cn.Close();
        }

        private void LoadMaxExpenseForMedical()
        {
            cn.Open();
            cm = new SqlCommand("SELECT SUM(ExpenseAmount) as Total FROM tbExpense WHERE ExpenseCategory = 'Medical'AND MONTH(ExpenseDate) = @MONTH AND YEAR(ExpenseDate) = @YEAR", cn);
            cm.Parameters.AddWithValue("@MONTH", DateTime.Now.Month);
            cm.Parameters.AddWithValue("@YEAR", DateTime.Now.Year);
            dr2 = cm.ExecuteReader();
            while (dr2.Read())
            {
                MedicalMaxValue.Text = dr2["Total"].ToString();
            }
            dr2.Close();
            cn.Close();
        }

        private void LoadMaxExpenseForShopping()
        {
            cn.Open();
            cm = new SqlCommand("SELECT SUM(ExpenseAmount) as Total FROM tbExpense WHERE ExpenseCategory = 'Shopping'AND MONTH(ExpenseDate) = @MONTH AND YEAR(ExpenseDate) = @YEAR", cn);
            cm.Parameters.AddWithValue("@MONTH", DateTime.Now.Month);
            cm.Parameters.AddWithValue("@YEAR", DateTime.Now.Year);
            dr2 = cm.ExecuteReader();
            while (dr2.Read())
            {
                ShoppingMaxValue.Text = dr2["Total"].ToString();
            }
            dr2.Close();
            cn.Close();
        }

        private void LoadMaxExpenseForOthers()
        {
            cn.Open();
            cm = new SqlCommand("SELECT SUM(ExpenseAmount) as Total FROM tbExpense WHERE ExpenseCategory = 'Others'AND MONTH(ExpenseDate) = @MONTH AND YEAR(ExpenseDate) = @YEAR", cn);
            cm.Parameters.AddWithValue("@MONTH", DateTime.Now.Month);
            cm.Parameters.AddWithValue("@YEAR", DateTime.Now.Year);
            dr2 = cm.ExecuteReader();
            while (dr2.Read())
            {
                OthersMaxValue.Text = dr2["Total"].ToString();
            }
            dr2.Close();
            cn.Close();
        }
    }
}

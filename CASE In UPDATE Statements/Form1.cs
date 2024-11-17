using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace CASE_In_UPDATE_Statements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpdateUsingCS_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            DataTable dt = EmployeeData.GetAllEmployees();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int PerformanceRating = (int)row["PerformanceRating"];
                    int ID = (int)row["ID"];

                    if (PerformanceRating > 90)
                        EmployeeData.IncreaseSalaryUsingCS(ID, 1.15f);
                    else if (PerformanceRating >= 75 && PerformanceRating <= 90)
                        EmployeeData.IncreaseSalaryUsingCS(ID, 1.10f);
                    else if (PerformanceRating >= 50 && PerformanceRating <= 74)
                        EmployeeData.IncreaseSalaryUsingCS(ID, 1.05f);
                }
            }
            stopwatch.Stop();
            MessageBox.Show("Salary increased successfully.\n" +
                    $"It took : {stopwatch.ElapsedMilliseconds} ms.", "Using C#");
        }
        private void btnUpdateUsingCaseStatement_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            bool Result = EmployeeData.IncreaseSalaryUsingCaseStatement();
            stopwatch.Stop();
            if (Result)
            {
                MessageBox.Show("Salary increased successfully.\n" +
                    $"It took : {stopwatch.ElapsedMilliseconds} ms.", "Using Case Statement");
            }
            else
            {
                MessageBox.Show("Something went wrong!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private float GetSalaryAVG(int TotalEmployees, float TotalSalaries)
        {
            if (TotalEmployees == 0)
                return 0;

            return TotalSalaries / TotalEmployees;
        }
        private void btnCategorizeEmployeesUsingCS_Click(object sender, EventArgs e)
        {
            DataTable dt = EmployeeData.GetAllEmployees();

            int HighCategoryEmployees = 0;
            int MediumCategoryEmployees = 0;
            int LowCategoryEmployees = 0;

            int HighCategorySalaries = 0;
            int MediumCategorySalaries = 0;
            int LowCategorySalaries = 0;

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int PerformanceRating = (int)row["PerformanceRating"];
                    int Salary = (int)row["Salary"];

                    if (PerformanceRating >= 80)
                    { 
                        HighCategoryEmployees++;
                        HighCategorySalaries += Salary;
                    }
                    else if (PerformanceRating >=60)
                    {
                        MediumCategoryEmployees++;
                        MediumCategorySalaries += Salary;
                    }
                    else
                    {
                        LowCategoryEmployees++;
                        LowCategorySalaries += Salary;
                    }
                }
            }

            MessageBox.Show($"Category: High, Number of employees: {HighCategoryEmployees}, Salary average : {GetSalaryAVG(HighCategoryEmployees, HighCategorySalaries)}\n" +
                $"Category: Medium, Number of employees: {MediumCategoryEmployees}, Salary average : {GetSalaryAVG(MediumCategoryEmployees, MediumCategorySalaries)}\n" +
                $"Category: Low, Number of employees: {LowCategoryEmployees}, Salary average : {GetSalaryAVG(LowCategoryEmployees, LowCategorySalaries)}\n");
        }
        
    }
}

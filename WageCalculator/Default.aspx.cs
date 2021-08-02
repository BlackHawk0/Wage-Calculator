using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WageCalculator
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double employeewage;
            Employee emp = new Employee();
        emp.EmployeeID = Convert.ToInt32(txtID.Text);
            emp.HourWorked = Convert.ToDouble(txtHoursWorked.Text);
            emp.RatePerHour = 12;
            lblWage.Text = Convert.ToString(emp.CalculateWage(emp.EmployeeID,emp.HourWorked));
            
                
                }
    }

    public class Employee
    {
        int employeeID;
        string employeeName;
        double rateperhour;
        double hourWorked;


        public double HourWorked
        {
            get
            {
                return hourWorked;
            }
            set
            {
                hourWorked = value;
            }
        }






        public double RatePerHour
        {
            get
            {
                return rateperhour;
            }
            set
            {
                rateperhour = value;
            }
        }

        public int EmployeeID
        {
            get
            {
                return employeeID;
            }
            set
            {
                employeeID = value;
            }
        }





        public double CalculateWage(int emploeeID,double hourWorked)
        {
          


            double wage=0.0;

            wage = hourWorked * RatePerHour;


            return wage;

        }

    }
    
}
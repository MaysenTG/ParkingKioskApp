using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void stepTwo()
        {
            customerOrStaff.Enabled = false;
            bCalculate.Enabled = true;
            tbHours.Enabled = true;

        }

        private void bMoveToHours_Click(object sender, EventArgs e)
        {
            if(rbCustomer.Checked)
            {
                CustomerParking newCustomer = new CustomerParking();
                labelParkingInfo.Text = newCustomer.ParkingInfo();
                stepTwo();
            }
             else if(rbStaff.Checked)
            {
                StaffParking newStaff = new StaffParking();
                labelParkingInfo.Text = newStaff.ParkingInfo();
                stepTwo();

            } else
            {
                MessageBox.Show("Choose an option!");
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            customerOrStaff.Enabled = true;
            rbCustomer.Checked = false;
            rbStaff.Checked = false;
            labelParkingInfo.Text = "";
            tbHours.Text = "";
            labelParkingAmount.Text = "";
            tbHours.Enabled = false;
            bCalculate.Enabled = false;
        }

        private void bCalculate_Click(object sender, EventArgs e)
        {
            if (rbCustomer.Checked)
            {
                CustomerParking newCustomer = new CustomerParking();
                double totalCost = newCustomer.Calculate(Double.Parse(tbHours.Text));
                labelParkingAmount.Text += "\r\n" + totalCost.ToString();
            }
            else if (rbStaff.Checked)
            {
                StaffParking newStaff = new StaffParking();
                double totalCost = newStaff.Calculate(Double.Parse(tbHours.Text));
                labelParkingAmount.Text += "\r\n" + totalCost.ToString();
            }
        }
    }
}

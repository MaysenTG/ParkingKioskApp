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
        public ParkingType myObj;
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
                myObj = new CustomerParking();
                labelParkingInfo.Text = myObj.ParkingInfo();
                stepTwo();
            }
             else if(rbStaff.Checked)
            {
                myObj = new StaffParking();
                labelParkingInfo.Text = myObj.ParkingInfo();
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
            if (tbHours.Text != "")
            {
                try
                {
                    double totalCost = myObj.Calculate(Double.Parse(tbHours.Text));
                    labelParkingAmount.Text = "$"+totalCost.ToString();
                }
                catch (ParkingException pe)
                {
                    MessageBox.Show(pe.Message);
                }
            }
            else
            {
                MessageBox.Show("Enter a value!");
            }
        }

        private void labelParkingAmount_Click(object sender, EventArgs e)
        {

        }
    }
}

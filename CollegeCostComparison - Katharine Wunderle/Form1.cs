using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeCostComparison___Katharine_Wunderle
{
    //Author: Katharine Wunderle
    //ID: 623748
    //Date: 02/21/2021
    //Goal: compare costs of 2 colleges
    public partial class collegeCostComparison : Form
    {
        //Declare constants
        private const decimal GAS_PRICE = 2.50m;
        private const int MPG = 25;
        public collegeCostComparison()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            //Declare variables
            int trips1;
            int trips2;
            double distance1;
            double distance2;
            decimal app1;
            decimal app2;
            decimal tuition1;
            decimal tuition2;
            decimal room1;
            decimal room2;
            decimal fuelTotal1;
            decimal fuelTotal2;
            decimal totalCost1;
            decimal totalCost2;

            //Get trip number input from user
            trips1 = int.Parse(college1TripsInput.Text);
            trips2 = int.Parse(college2TripsInput.Text);

            //Get distance input from user
            distance1 = double.Parse(college1Distance.Text);
            distance2 = double.Parse(college2Distance.Text);

            //Get application fee cost input from user
            app1 = decimal.Parse(college1AppFee.Text);
            app2 = decimal.Parse(college2AppFee.Text);

            //Get annual tuition cost input from user
            tuition1 = decimal.Parse(college1Tuition.Text);
            tuition2 = decimal.Parse(college2Tuition.Text);

            //Get annual room and board cost input from user
            room1 = decimal.Parse(college1RoomCost.Text);
            room2 = decimal.Parse(College2RoomCost.Text);

            //Calculate total fuel cost for each college
            fuelTotal1 = (decimal)((trips1 * distance1) / MPG) * GAS_PRICE;
            fuelTotal2 = (decimal)((trips2 * distance2) / MPG) * GAS_PRICE;

            //Calculate all costs for 4 years
            totalCost1 = (decimal)app1 + (fuelTotal1 * 4) + (tuition1 * 4) + (room1 * 4);
            totalCost2 = (decimal)app2 + (fuelTotal2 * 4) + (tuition1 * 4) + (room2 * 4);

            //Display total fuel costs
            college1FuelCost.Text = fuelTotal1.ToString("c");
            college2FuelCost.Text = fuelTotal2.ToString("c");

            //Display 4 year total of all costs
            college1TotalCost.Text = totalCost1.ToString("c");
            college2TotalCost.Text = totalCost2.ToString("c");

            //Highlight higher cost in red
            if (totalCost1 > totalCost2) 
            { college1TotalCost.BackColor = Color.Red;
                college2TotalCost.BackColor = Color.White;
            }
            if (totalCost1 < totalCost2) 
            {   college1TotalCost.BackColor = Color.White;
                college2TotalCost.BackColor = Color.Red;
            }
            if (totalCost1 == totalCost2)
            {   college1TotalCost.BackColor = Color.White;
                college2TotalCost.BackColor = Color.White;
            }
            }
        }
    }

using System;
using System.Windows.Forms;

namespace C_Lunch_Order
{
    public partial class LunchOrder : Form
    {
        public LunchOrder()
        {
            InitializeComponent();

            // Initializing for changing Addons in running form
            rdHamburger.Click += rdHamburger_Click;
            rdPizza.Click += rdPizza_Click;
            rdSalad.Click += rdSalad_Click;
        }

        private void LunchOrder_Load(object sender, EventArgs e)
        {
            // Base upon launch
            rdHamburger.Checked = true;
        }

        // Clearing the Totals
        private void ClearTotals()
        {
            txtSubtotal.Clear();
            txtTax.Clear();
            txtOrderTotal.Clear();
        }


        // Clearing Addons
        private void ClearAddOns()
        {
            chkLettuce.Checked = false;
            chkKetchup.Checked = false;
            chkFries.Checked = false;
        }

        private void rdHamburger_Click(object sender, EventArgs e)
        {
            grpAddons.Text = "Addons ($1.25/each)";
            chkLettuce.Text = "Lettuce, tomato, and onions";
            chkKetchup.Text = "Ketchup, mustard, and mayo";
            chkFries.Text = "French Fries";
            ClearAddOns();
            ClearTotals();
        }

        private void rdPizza_Click(object sender, EventArgs e)
        {
            grpAddons.Text = "Addons ($0.75/each)";
            chkLettuce.Text = "Pepperoni";
            chkKetchup.Text = "Sausage";
            chkFries.Text = "Olives";
            ClearAddOns();
            ClearTotals();
        }

        private void rdSalad_Click(object sender, EventArgs e)
        {
            grpAddons.Text = "Addons ($0.50/each)";
            chkLettuce.Text = "Croutons";
            chkKetchup.Text = "Bacon bits";
            chkFries.Text = "Bread sticks";
            ClearAddOns();
            ClearTotals();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            // Base price
            double mainCoursePrice = 0;
            double addonPrice = 0;

            // For grpMainCourse prices
            if (rdHamburger.Checked) mainCoursePrice = 7.95;
            if (rdPizza.Checked) mainCoursePrice = 6.95;
            if (rdSalad.Checked) mainCoursePrice = 6.75;

            // For grpAddons price set
            double addonUnitPrice = 0;

            if (rdHamburger.Checked) addonUnitPrice = 1.25;
            if (rdPizza.Checked) addonUnitPrice = 0.75;
            if (rdSalad.Checked) addonUnitPrice = 0.50;

            // Calculating addons
            if (chkLettuce.Checked) addonPrice += addonUnitPrice;
            if (chkKetchup.Checked) addonPrice += addonUnitPrice;
            if (chkFries.Checked) addonPrice += addonUnitPrice;

            // Formulas to Calculate
            double subtotal = mainCoursePrice + addonPrice;
            double tax = 0.0775 * subtotal;
            double total = subtotal + tax;

            // Part to show Calculations in the fields
            txtSubtotal.Text = subtotal.ToString("C");
            txtTax.Text = tax.ToString("C");
            txtOrderTotal.Text = total.ToString("C");
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

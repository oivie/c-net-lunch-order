namespace C_Lunch_Order
{
    partial class LunchOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpMainCourse = new System.Windows.Forms.GroupBox();
            this.rdSalad = new System.Windows.Forms.RadioButton();
            this.rdPizza = new System.Windows.Forms.RadioButton();
            this.rdHamburger = new System.Windows.Forms.RadioButton();
            this.grpAddons = new System.Windows.Forms.GroupBox();
            this.chkFries = new System.Windows.Forms.CheckBox();
            this.chkKetchup = new System.Windows.Forms.CheckBox();
            this.chkLettuce = new System.Windows.Forms.CheckBox();
            this.grpOrderTotal = new System.Windows.Forms.GroupBox();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.lbOrderTotal = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.lbTax = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpMainCourse.SuspendLayout();
            this.grpAddons.SuspendLayout();
            this.grpOrderTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMainCourse
            // 
            this.grpMainCourse.Controls.Add(this.rdSalad);
            this.grpMainCourse.Controls.Add(this.rdPizza);
            this.grpMainCourse.Controls.Add(this.rdHamburger);
            this.grpMainCourse.Location = new System.Drawing.Point(58, 53);
            this.grpMainCourse.Name = "grpMainCourse";
            this.grpMainCourse.Size = new System.Drawing.Size(361, 274);
            this.grpMainCourse.TabIndex = 0;
            this.grpMainCourse.TabStop = false;
            this.grpMainCourse.Text = "Main Course";
            // 
            // rdSalad
            // 
            this.rdSalad.AutoSize = true;
            this.rdSalad.Location = new System.Drawing.Point(33, 214);
            this.rdSalad.Name = "rdSalad";
            this.rdSalad.Size = new System.Drawing.Size(171, 29);
            this.rdSalad.TabIndex = 2;
            this.rdSalad.TabStop = true;
            this.rdSalad.Text = "Salad - $6.75";
            this.rdSalad.UseVisualStyleBackColor = true;
            // 
            // rdPizza
            // 
            this.rdPizza.AutoSize = true;
            this.rdPizza.Location = new System.Drawing.Point(33, 146);
            this.rdPizza.Name = "rdPizza";
            this.rdPizza.Size = new System.Drawing.Size(169, 29);
            this.rdPizza.TabIndex = 1;
            this.rdPizza.TabStop = true;
            this.rdPizza.Text = "Pizza - $6.95";
            this.rdPizza.UseVisualStyleBackColor = true;
            // 
            // rdHamburger
            // 
            this.rdHamburger.AutoSize = true;
            this.rdHamburger.Location = new System.Drawing.Point(33, 73);
            this.rdHamburger.Name = "rdHamburger";
            this.rdHamburger.Size = new System.Drawing.Size(222, 29);
            this.rdHamburger.TabIndex = 0;
            this.rdHamburger.TabStop = true;
            this.rdHamburger.Text = "Hamburger - $7.95";
            this.rdHamburger.UseVisualStyleBackColor = true;
            // 
            // grpAddons
            // 
            this.grpAddons.Controls.Add(this.chkFries);
            this.grpAddons.Controls.Add(this.chkKetchup);
            this.grpAddons.Controls.Add(this.chkLettuce);
            this.grpAddons.Location = new System.Drawing.Point(483, 53);
            this.grpAddons.Name = "grpAddons";
            this.grpAddons.Size = new System.Drawing.Size(563, 274);
            this.grpAddons.TabIndex = 1;
            this.grpAddons.TabStop = false;
            this.grpAddons.Text = "Addons ($1.25/each)";
            // 
            // chkFries
            // 
            this.chkFries.AutoSize = true;
            this.chkFries.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.chkFries.Location = new System.Drawing.Point(31, 214);
            this.chkFries.Name = "chkFries";
            this.chkFries.Size = new System.Drawing.Size(165, 29);
            this.chkFries.TabIndex = 2;
            this.chkFries.Text = "French Fries";
            this.chkFries.UseVisualStyleBackColor = false;
            // 
            // chkKetchup
            // 
            this.chkKetchup.AutoSize = true;
            this.chkKetchup.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.chkKetchup.Location = new System.Drawing.Point(31, 146);
            this.chkKetchup.Name = "chkKetchup";
            this.chkKetchup.Size = new System.Drawing.Size(312, 29);
            this.chkKetchup.TabIndex = 1;
            this.chkKetchup.Text = "Ketchup, mustard and mayo";
            this.chkKetchup.UseVisualStyleBackColor = false;
            // 
            // chkLettuce
            // 
            this.chkLettuce.AutoSize = true;
            this.chkLettuce.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.chkLettuce.Location = new System.Drawing.Point(31, 74);
            this.chkLettuce.Name = "chkLettuce";
            this.chkLettuce.Size = new System.Drawing.Size(304, 29);
            this.chkLettuce.TabIndex = 0;
            this.chkLettuce.Text = "Lettuce, tomato and onions";
            this.chkLettuce.UseVisualStyleBackColor = false;
            // 
            // grpOrderTotal
            // 
            this.grpOrderTotal.Controls.Add(this.txtOrderTotal);
            this.grpOrderTotal.Controls.Add(this.lbOrderTotal);
            this.grpOrderTotal.Controls.Add(this.txtTax);
            this.grpOrderTotal.Controls.Add(this.lbTax);
            this.grpOrderTotal.Controls.Add(this.txtSubtotal);
            this.grpOrderTotal.Controls.Add(this.label1);
            this.grpOrderTotal.Location = new System.Drawing.Point(58, 368);
            this.grpOrderTotal.Name = "grpOrderTotal";
            this.grpOrderTotal.Size = new System.Drawing.Size(361, 279);
            this.grpOrderTotal.TabIndex = 2;
            this.grpOrderTotal.TabStop = false;
            this.grpOrderTotal.Text = "Order Total:";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.BackColor = System.Drawing.SystemColors.Info;
            this.txtOrderTotal.Location = new System.Drawing.Point(155, 188);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.ReadOnly = true;
            this.txtOrderTotal.Size = new System.Drawing.Size(179, 31);
            this.txtOrderTotal.TabIndex = 5;
            // 
            // lbOrderTotal
            // 
            this.lbOrderTotal.AutoSize = true;
            this.lbOrderTotal.Location = new System.Drawing.Point(31, 195);
            this.lbOrderTotal.Name = "lbOrderTotal";
            this.lbOrderTotal.Size = new System.Drawing.Size(126, 25);
            this.lbOrderTotal.TabIndex = 4;
            this.lbOrderTotal.Text = "Order Total:";
            // 
            // txtTax
            // 
            this.txtTax.BackColor = System.Drawing.SystemColors.Info;
            this.txtTax.Location = new System.Drawing.Point(151, 123);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(179, 31);
            this.txtTax.TabIndex = 3;
            // 
            // lbTax
            // 
            this.lbTax.AutoSize = true;
            this.lbTax.Location = new System.Drawing.Point(27, 130);
            this.lbTax.Name = "lbTax";
            this.lbTax.Size = new System.Drawing.Size(135, 25);
            this.lbTax.TabIndex = 2;
            this.lbTax.Text = "Tax (7.75%):";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BackColor = System.Drawing.SystemColors.Info;
            this.txtSubtotal.Location = new System.Drawing.Point(153, 61);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(179, 31);
            this.txtSubtotal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal:";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlaceOrder.Location = new System.Drawing.Point(483, 386);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(227, 50);
            this.btnPlaceOrder.TabIndex = 3;
            this.btnPlaceOrder.Text = "Place an order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(483, 565);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(227, 50);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LunchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 677);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.grpOrderTotal);
            this.Controls.Add(this.grpAddons);
            this.Controls.Add(this.grpMainCourse);
            this.Name = "LunchOrder";
            this.Text = "Lunch Order";
            this.Load += new System.EventHandler(this.LunchOrder_Load);
            this.grpMainCourse.ResumeLayout(false);
            this.grpMainCourse.PerformLayout();
            this.grpAddons.ResumeLayout(false);
            this.grpAddons.PerformLayout();
            this.grpOrderTotal.ResumeLayout(false);
            this.grpOrderTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMainCourse;
        private System.Windows.Forms.RadioButton rdSalad;
        private System.Windows.Forms.RadioButton rdPizza;
        private System.Windows.Forms.RadioButton rdHamburger;
        private System.Windows.Forms.GroupBox grpAddons;
        private System.Windows.Forms.CheckBox chkFries;
        private System.Windows.Forms.CheckBox chkKetchup;
        private System.Windows.Forms.CheckBox chkLettuce;
        private System.Windows.Forms.GroupBox grpOrderTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Label lbOrderTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label lbTax;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnExit;
    }
}


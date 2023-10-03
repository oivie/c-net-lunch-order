# c-net-lunch-order

You've presented the code for a Windows Forms application that models a lunch order form. Users can choose between a hamburger, pizza, or salad and then select relevant add-ons for each option.

Here's a brief overview of the logic and functionality of the application:

1. **Initialization**:
    - When the form first loads (`LunchOrder_Load`), the hamburger option is pre-selected.
    - Event handlers for the three radio buttons (`rdHamburger`, `rdPizza`, `rdSalad`) are associated with respective methods to respond to clicks on these options.

2. **Changing Add-ons based on Main Course**:
    - Depending on the main course chosen, the group of add-ons (`grpAddons`) and their checkboxes change their text to show relevant add-ons for that course.
        - **Hamburger**: Add-ons cost $1.25 each and include lettuce, tomato, onions, ketchup, mustard, mayo, and French fries.
        - **Pizza**: Add-ons cost $0.75 each and include pepperoni, sausage, and olives.
        - **Salad**: Add-ons cost $0.50 each and include croutons, bacon bits, and bread sticks.
    - When switching between main courses, all previously chosen add-ons and totals are cleared. 

3. **Order Calculation**:
    - When the "Place Order" button (`btnPlaceOrder_Click`) is clicked:
        - The base price of the main course is determined based on the selected option.
        - The cost of add-ons is calculated based on the chosen main course and its respective add-on unit price.
        - The subtotal, tax (7.75% of the subtotal), and total amounts are calculated and displayed.

4. **Exiting the Application**:
    - Clicking the "Exit" button (`btnExit_Click`) will close the form/application.


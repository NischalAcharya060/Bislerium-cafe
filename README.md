# Bislerium-cafe

Bislerium-cafe is a simple C# application for managing orders in a coffee shop. This application provides a user-friendly interface for customers to place their coffee orders.

## Project Overview

The application consists of several features, including:

1. **Login Form:**
   - Allows users (admin and staff) to log in.
   - Admin and staff have different access levels.

2. **Order Form:**
   - Customers can select different coffee types and add-ins.
   - Calculates the total cost of the order.
   - Provides options to reset and exit.

3. **Landing Page:**
   - Welcomes users to BrewHub Cafe.
   - Allows users to navigate to the Order Form or Login Page.

4. **Viewing Orders:**
   - Page to view all taken orders.

5. **Payment Functionality:**
   - Payment requires the username or phone number of the customer.
   - No external payment gateways (e.g., Esewa or Khalti).
   - Payment is done by Admin or Staff through the application, and money is given by the customer.

6. **Viewing Payments and Reports:**
   - Page to view payments.
   - Downloadable PDF reports with:
     - Total revenue of daily or monthly sales.
     - Top 5 most sold coffee and add-ins with corresponding quantities and revenue.

7. **Membership System:**
   - Customers can be regular or members.
   - Members receive discounts and redemption opportunities.
   - Complimentary coffee redemption after every 10 purchases for members.
   - Flat 10% discount for regular members for an entire month.
   - Automatic monthly membership renewal.
   - It is not defined what makes the customer a member of the café in your coursework scenario, so you can do that manually.

8. **Functionality Restrictions:**
   - Admin-only functionality:
     - Viewing add-ins of coffee.
     - Editing the price of add-ins.
   - Password verification required for editing add-ins prices.

9. **Database Format:**
   - Use JSON, CSV, or Excel format documents as the database.

## TODO

- [x] Implement Login functionality.
- [x] Create Order Form with coffee and add-in options.
- [x] Calculate the total cost of the order.
- [x] Add a landing page for user navigation.
- [ ] Implement Viewing Orders functionality.
- [ ] Implement Payment Functionality.
- [ ] Implement Viewing Payments and Reports.
- [ ] Implement Membership System.
- [ ] Implement Functionality Restrictions.
- [ ] ...

## How to Run

1. Clone the repository:

   ```bash
   git clone https://github.com/NischalAcharya060/Bislerium-cafe.git

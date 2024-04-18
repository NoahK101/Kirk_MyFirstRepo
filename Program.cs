namespace Kirk_Module5CodingChallenge
{
    class Program
    {
        //Main Method is called when program exec
        public static void Main()
        {
            //the using keyword creates a code block of limited scope, ensures db connection is closed
            //when code block exec then context.Dispose() to close db connection
            using (var context = new NorthwindContext())
            {
                //query db to retrieve the customer with bottm
                var customers = (from customer
                                 in context.Customers
                                 where customer.CustomerID.Equals("BOTTM")
                                 select customer).ToList();

                //loop through list of customers and display customer id and company name
                foreach (var customer in customers)
                {
                    //the $ character before a string literal is used for interpolated string. This allows you to insert
                    //expressions directly into the string enclosed in {}
                    Console.WriteLine($"Customer ID: {customer.CustomerID}, Company Name: {customer.CompanyName}");
                }//end foreach loop

                //Query the database to retrieve the customer with the specified phone number
                //using a lambda expression
                customers = context.Customers.Where(customer => customer.Phone.Equals("(206) 555-4112")).ToList();

                //Loop through the list of customers and display the customer ID and company name
                foreach (var customer in customers)
                {
                    Console.WriteLine($"Customer ID: {customer.CustomerID}, Company Name: {customer.CompanyName}");
                }//end foreach loop

                //Add a customer to the customers table
                //Create a new instance of a customer
                var newCustomer = new Customer
                {
                    CustomerID = "NEW02", // set cust id
                    CompanyName = "Anoka Grocery", //set company name
                    ContactName = "Noah Kirk",
                    ContactTitle = "Sales Manager",
                    Address = "123 Main St.",
                    City = "Anoka",
                    Region = "MN",
                    PostalCode = "55303",
                    Country = "USA",
                    Phone = "(763) 555-5555",
                    Fax = "(763) 555-5556"
                };

                //Add new customer to database context
                context.Customers.Add(newCustomer);

                //Save the changes to the database
                context.SaveChanges();

                //Output to the console that record was inserted correctly\
                Console.WriteLine($"New customer inserted succesfully: {newCustomer.CompanyName}");
            }//end using block
        }//end main method
    }//end class
}//end namespace
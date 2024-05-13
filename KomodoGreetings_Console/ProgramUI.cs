using System.ComponentModel.Design;


public class ProgramUI
{
    public void Run()
   {

   }

    public void Menu()
    {
        bool keepRunning = true;

        while (keepRunning)
        {
        System.Console.WriteLine("Welcome to the Komodo E-Mail Greetings App. Please select your menu option:\n" +
        "1. Send a greeting to a current customer\n" +
        "2. Send a greeting to a PAST customer\n" +
        "3. Send a greeting to a new and/or prospective customer\n" +
        "4. Exit the app");

        //Get the user's input here...
         
         string input = Console.ReadLine();

         //Evaluating user input here and carry them out...
         switch (input)
            {
            case "1":
               SendGreetingToCurrentCustomer();
               break;
            case "2":
                SendGreetingToPastCustomer();
                break;
            case "3":
                SendGreetingToNewCustomer();
                break;
            case "4":
                System.Console.WriteLine("Goodbye.");
            keepRunning = false;
            break;
                
            default:
            System.Console.WriteLine("Please enter a valid number.");
            break;
            }
            System.Console.WriteLine("Please press any key to continue...");
            System.Console.ReadKey();
            System.Console.Clear();
        }
    }
    // Send Greetings to Current Customer
    
    public void SendGreetingToCurrentCustomer();
    {
        
    
    }
    //Send Greetings to Past Customer
    
    public void SendGreetingToPastCustomer();
    {

    }

    // Send a greeting to a new and/or prospective customer

    public void SendGreetingToNewCustomer();
    {

    }
    

    


}
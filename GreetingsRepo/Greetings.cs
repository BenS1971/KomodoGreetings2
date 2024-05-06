namespace GreetingsRepo.repository;

public enum GreetingsType
{
    PotentialCustomer = 1,
    CurrentLoyalCustomer,
    PastLoyalty,
    DesireForACustomerToReturn,
}
public enum GreetingsEmail
{
    WeHaveTheLowestRates = 1,
    ThankYouForYourLoyaltyHeresYourDiscountCoupon,
    ItsBeenALongTimeSinceWeHeardFromYou,
    WeWantYouBack,
}

//This is the repository for the Komodo outings with the POCOs...
 public class Greetingss
{
    public DateTime GreetingsDate { get; set;}
    public 

    
    public Greetings(string outingDate, string numberOfPeople, double costPerPerson, double totalCostPerPerson, string typeOfOuting)
     
        
    

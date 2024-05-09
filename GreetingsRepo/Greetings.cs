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
    ItsBeenALongTimeSinceWeHeardFromYouWeWantYouBack,
    
}

//This is the repository for the Komodo outings with the POCOs...
 public class Greetings
{
    public DateTime GreetingsDate { get; set;}
    
}
        
    

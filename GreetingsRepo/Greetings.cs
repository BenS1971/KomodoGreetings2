namespace GreetingsRepo.repository;

public enum GreetingsType
{
    PotentialCustomer = 1,
    CurrentLoyalCustomer =2,
    PastLoyalty =3,
    DesireForACustomerToReturn =4,
}
public enum GreetingsEmail
{
    WeHaveTheLowestRates = 1,
    ThankYouForYourLoyaltyHeresYourDiscountCoupon =2,
    ItsBeenALongTimeSinceWeHeardFromYouWeWantYouBack =3,
    
}

//This is the repository for the Komodo Greetings with the POCOs...
 public class Greetings
{
    public DateTime GreetingsDate { get; set;}

    public string? GreetingsType { get; set;}

    public string? GreetingsEmail { get; set; }
}
        
    

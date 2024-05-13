using GreetingsRepo.repository;

namespace GreetingsRepo.Repository;

public class GreetingsRepo
{
    private List<GreetingsRepo> _listOfGreetings = new List <GreetingsRepo>();
     // Create Greetings...
   {
     public void AddGreetingsToList(GreetingsRepo greetings)
      {
        Greetings.Add(greetings);
      }
     //Read Greetings...
     public List<GreetingsRepo> GetGreetingList(greetings);
      {
        return new List<Greetings>(_listOfGreetings);
      }
     //Update greetings...
     public bool UpdateGreetings(string greetings, GreetingsRepo newGreetings)

         //Find that greetings content...
     Greetings oldContent = GetGreetingsList(greetings);

         //...And then UPDATE those greetings.
     if (oldContent != null)
      {
        oldContent.
      }
   }
}

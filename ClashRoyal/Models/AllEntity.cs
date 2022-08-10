namespace ClashRoyal.Models
{
    public class AllEntity
    {
        public List<Entity> AllCreatures { get;  }

        public AllEntity(string field)
        {
            AllCreatures = new List<Entity>();
            AllCreatures.Add(new Entity("Inferno Dragon", 450, 1800, 79, 10, 4, ""));
            AllCreatures.Add(new Entity("Barbarian", 370, 10, 89, 10, 3, ""));
            AllCreatures.Add(new Entity("Wizard", 300, 60, 79, 10, 4, ""));
          
        }
    }
}

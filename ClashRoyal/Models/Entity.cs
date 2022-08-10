namespace ClashRoyal.Models
{
    public class Entity
    {
        public string TypeEntity { get; }
        public int HealthEntity { get; }
        public int AtackEntity { get; }
        public int DistanceEntity { get; }
        public int SpeedEntity { get; }
        public int PriceEntity { get; }
        public string CardEntity { get; }

        public Entity(string nameType, int health, int distance, int atack, int speed, int price, string card)
        {
            TypeEntity = nameType;
            HealthEntity = health;
            AtackEntity = atack;
            DistanceEntity = distance;
            SpeedEntity = speed;
            PriceEntity = price;
            CardEntity = card;          

        }
    }
}

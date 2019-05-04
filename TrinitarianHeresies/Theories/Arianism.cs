namespace TrinitarianHeresies.Theories
{
    public class Arianism : God
    {
        class Creator : God
        {
            public readonly Entity Power = new Entity();
        }
        class Creature : Entity {}
        
        public Arianism()
        {
            Father = new Creator();
            Son = new Creature();
            Spirit = (Father as Creator).Power;
        }
    }
}
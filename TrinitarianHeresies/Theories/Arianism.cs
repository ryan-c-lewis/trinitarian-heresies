namespace TrinitarianHeresies.Theories
{
    public class Arianism : God<Arianism>, IGod
    {
        class Creator : PersonOfGodhead
        {
            public readonly object Power = new object();
        }
        class Creature {}
        
        public Arianism()
        {
            Father = new Creator();
            Son = new Creature();
            Spirit = (Father as Creator).Power;
        }
    }
}
namespace TrinitarianHeresies.Theories
{
    public class Arianism : God
    {
        class Creator : God
        {
            public readonly Entity Power = new Entity();
        }
        
        public Arianism()
        {
            Father = new Creator();
            Son = new Jesus {IsHuman = true, IsDivine = false};
            Spirit = (Father as Creator).Power;
        }
    }
}
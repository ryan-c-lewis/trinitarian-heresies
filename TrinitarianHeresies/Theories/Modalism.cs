namespace TrinitarianHeresies.Theories
{
    public class Modalism : God<Modalism>, IGod
    {
        public Modalism()
        {
            Father = Son = Spirit = this;
        }
    }
}
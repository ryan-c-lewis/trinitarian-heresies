namespace TrinitarianHeresies.Theories
{
    public class OrthodoxTheory : God<OrthodoxTheory>, IGod
    {
        public OrthodoxTheory()
        {
            Father = new PersonOfGodhead();
            Son = new PersonOfGodhead();
            Spirit = new PersonOfGodhead();
        }
    }
}
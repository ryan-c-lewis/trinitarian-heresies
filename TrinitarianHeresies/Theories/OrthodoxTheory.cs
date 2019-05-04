namespace TrinitarianHeresies.Theories
{
    public class OrthodoxTheory : God
    {
        public OrthodoxTheory()
        {
            Father = new PersonOfGodhead();
            Son = new PersonOfGodhead();
            Spirit = new PersonOfGodhead();
        }
    }
}
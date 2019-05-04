namespace TrinitarianHeresies.Theories
{
    public class Docetism : God
    {
        public Docetism()
        {
            Father = new PersonOfGodhead();
            Son = new Jesus {IsHuman = false, IsDivine = true};
            Spirit = new PersonOfGodhead();
        }
    }
}
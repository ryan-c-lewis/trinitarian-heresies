namespace TrinitarianHeresies.Theories
{
    public class Tritheism : God<Tritheism>, IGod
    {
        public Tritheism()
        {
            Father = new object();
            Son = new object();
            Spirit = new object();
        }
    }
}
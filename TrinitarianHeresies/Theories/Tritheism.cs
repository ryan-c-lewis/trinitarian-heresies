namespace TrinitarianHeresies.Theories
{
    public class Tritheism : God
    {
        public Tritheism()
        {
            Father = new God();
            Son = new Jesus {IsHuman = true, Divinity = DivinityStatus.Full};
            Spirit = new God();
        }

        public override bool IsOne()
        {
            return false;
        }
    }
}
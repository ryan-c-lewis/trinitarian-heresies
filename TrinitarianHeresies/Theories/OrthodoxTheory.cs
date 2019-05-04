namespace TrinitarianHeresies.Theories
{
    public class OrthodoxTheory : God
    {
        public OrthodoxTheory()
        {
            Father = new PersonOfGodhead();
            Son = new Jesus {IsHuman = true, Divinity = DivinityStatus.Full};
            Spirit = new PersonOfGodhead();
        }
    }
}
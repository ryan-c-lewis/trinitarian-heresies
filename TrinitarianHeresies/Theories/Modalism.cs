namespace TrinitarianHeresies.Theories
{
    public class Modalism : God
    {
        public Modalism()
        {
            Father = Son = Spirit = new Jesus {IsHuman = true, Divinity = DivinityStatus.Full};
        }
    }
}
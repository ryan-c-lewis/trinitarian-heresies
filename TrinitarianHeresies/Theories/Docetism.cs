using TrinitarianHeresies.Model;

namespace TrinitarianHeresies.Theories
{
    public class Docetism : God
    {
        public Docetism()
        {
            Father = new PersonOfGodhead();
            Son = new Jesus {IsHuman = false, Divinity = DivinityStatus.Full};
            Spirit = new PersonOfGodhead();
        }
    }
}
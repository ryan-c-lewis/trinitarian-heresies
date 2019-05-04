using TrinitarianHeresies.Model;

namespace TrinitarianHeresies.Theories
{
    public class Partialism : God
    {
        class PartialGod : PersonOfGodhead
        {
            public override bool IsFullyGod()
            {
                return false;
            }
        }
        
        public Partialism()
        {
            Father = new PartialGod();
            Son = new Jesus {IsHuman = true, Divinity = DivinityStatus.Partial};
            Spirit = new PartialGod();
        }
    }
}
using TrinitarianHeresies.Model;

namespace TrinitarianHeresies.Theories
{
    public class Tritheism : God
    {
        class PolytheistGod : Jesus
        {
            public override bool IsFullyGod()
            {
                return false;
            }
        }
        
        public Tritheism()
        {
            Father = new PolytheistGod();
            Son = new PolytheistGod {IsHuman = true, Divinity = DivinityStatus.Full};
            Spirit = new PolytheistGod();
        }

        public override bool IsOne()
        {
            return false;
        }
    }
}
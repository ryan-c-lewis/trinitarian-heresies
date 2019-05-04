using TrinitarianHeresies.Model;

namespace TrinitarianHeresies.Theories
{
    public class Arianism : God
    {
        public Arianism()
        {
            Father = new FatherAloneAsGod();
            Son = new Jesus {IsHuman = true, Divinity = DivinityStatus.Partial};
            Spirit = (Father as FatherAloneAsGod).Power;
        }
    }
}
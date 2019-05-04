namespace TrinitarianHeresies.Theories
{
    public class Ebionitism : God
    {
        public Ebionitism()
        {
            Father = new FatherAloneAsGod();
            Son = new Jesus {IsHuman = true, Divinity = DivinityStatus.None};
            Spirit = (Father as FatherAloneAsGod).Power;
        }
    }
}
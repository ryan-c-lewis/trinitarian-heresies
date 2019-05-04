using System.Threading;
using System.Threading.Tasks;

namespace TrinitarianHeresies.Theories
{
    public class Adoptionism : God
    {
        public Adoptionism()
        {
            Father = new FatherAloneAsGod();
            Son = new Jesus {IsHuman = true, Divinity = DivinityStatus.None};
            Spirit = (Father as FatherAloneAsGod).Power;

            Task.Run(() =>
            {
                Thread.Sleep(SomePeriodOfTime);
                (Son as Jesus).Divinity = DivinityStatus.Full;
            });
        }
    }
}
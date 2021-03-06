using System.Threading;
using System.Threading.Tasks;
using TrinitarianHeresies.Model;

namespace TrinitarianHeresies.Theories
{
    public class Macedonianism : God
    {
        public Macedonianism()
        {
            Father = new PersonOfGodhead();
            Son = new Jesus {IsHuman = true, Divinity = DivinityStatus.Full};
            Spirit = null;

            Task.Run(() =>
            {
                Thread.Sleep(SomePeriodOfTime);
                Spirit = new Entity();
            });
        }
    }
}
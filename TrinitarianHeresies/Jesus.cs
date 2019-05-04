namespace TrinitarianHeresies
{
    public enum DivinityStatus
    {
        None,
        Partial,
        Full
    }
    public class Jesus : PersonOfGodhead
    {
        public bool IsHuman { get; set; }
        public DivinityStatus Divinity { get; set; }

        public override bool IsFullyGod()
        {
            return base.IsFullyGod() && Divinity == DivinityStatus.Full;
        }
    }
}
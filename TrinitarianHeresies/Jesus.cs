namespace TrinitarianHeresies
{
    public class Jesus : PersonOfGodhead
    {
        public bool IsHuman { get; set; }
        public bool IsDivine { get; set; }

        public override bool IsFullyGod()
        {
            return base.IsFullyGod() && IsDivine;
        }
    }
}
namespace TrinitarianHeresies
{
    public class God : Entity, IShema
    {
        public Entity Father { get; protected set; }
        public Entity Son { get; protected set; }
        public Entity Spirit { get; protected set; }

        public override bool IsFullyGod()
        {
            return true;
        }
        
        public virtual bool IsOne()
        {
            return true;
        }
    }
}
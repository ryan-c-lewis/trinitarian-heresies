namespace TrinitarianHeresies
{
    public abstract class God<T> where T : God<T>, IGod, new()
    {
        public object Father { get; protected set; }
        public object Son { get; protected set; }
        public object Spirit { get; protected set; }
        
        public override bool Equals(object other)
        {
            if (other == null)
                return false;
            return other == this || other is PersonOfGodhead;
        }
    }
}
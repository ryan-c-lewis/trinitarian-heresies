using System;

namespace TrinitarianHeresies.Model
{
    public class God : Entity
    {
        public TimeSpan SomePeriodOfTime = TimeSpan.FromDays(999);
        
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
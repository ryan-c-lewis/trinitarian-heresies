using TrinitarianHeresies.Theories;

namespace TrinitarianHeresies
{
    public class PersonOfGodhead
    {
        public override bool Equals(object other)
        {
            if (other == null)
                return false;
            if (other == this || other is OrthodoxTheory)
                return true;
            return false;
        }
    }
}
using NUnit.Framework;
using TrinitarianHeresies.Theories;

namespace TrinitarianHeresies
{
    [TestFixtureSource(nameof(Theories))]
    public class OrthodoxyTests
    {
        static object[] Theories =
        {
            new OrthodoxTheory(),
            new Modalism(),
            new Tritheism(),
            new Arianism()
        };
        
        protected virtual God God { get; }

        public OrthodoxyTests(God god)
        {
            God = god;
        }

        [Test]
        public void FatherIsGod()
        {
            Assert.IsTrue(God.Equals(God.Father));
        }
        
        [Test]
        public void SonIsGod()
        {
            Assert.IsTrue(God.Equals(God.Son));
        }
        
        [Test]
        public void SpiritIsGod()
        {
            Assert.IsTrue(God.Equals(God.Spirit));
        }
        
        [Test]
        public void FatherIsNotSon()
        {
            Assert.IsFalse(God.Father.Equals(God.Son));
        }
        
        [Test]
        public void FatherIsNotSpirit()
        {
            Assert.IsFalse(God.Father.Equals(God.Spirit));
        }
        
        [Test]
        public void SonIsNotSpirit()
        {
            Assert.IsFalse(God.Son.Equals(God.Spirit));
        }
    }
}
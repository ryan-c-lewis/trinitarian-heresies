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
            new Arianism(),
            new Docetism()
        };
        
        protected virtual God God { get; }

        public OrthodoxyTests(God god)
        {
            God = god;
        }

        [Test]
        public void FatherIsGod()
        {
            Assert.IsTrue(God.Father.IsFullyGod());
        }
        
        [Test]
        public void SonIsGod()
        {
            Assert.IsTrue(God.Son.IsFullyGod());
        }
        
        [Test]
        public void SpiritIsGod()
        {
            Assert.IsTrue(God.Spirit.IsFullyGod());
        }
        
        [Test]
        public void FatherIsNotSon()
        {
            Assert.AreNotSame(God.Father, God.Son);
        }
        
        [Test]
        public void FatherIsNotSpirit()
        {
            Assert.AreNotSame(God.Father, God.Spirit);
        }
        
        [Test]
        public void SonIsNotSpirit()
        {
            Assert.AreNotSame(God.Son, God.Spirit);
        }

        [Test]
        public void IsTheLordOne()
        {
            Assert.IsTrue(God.IsOne());
        }
        
        [Test]
        public void JesusIsHuman()
        {
            Assert.IsTrue(((Jesus) God.Son).IsHuman);
        }
        
        [Test]
        public void JesusIsDivine()
        {
            Assert.IsTrue(((Jesus) God.Son).IsDivine);
        }
    }
}
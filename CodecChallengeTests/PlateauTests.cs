using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodecChallenge;

namespace CodecChallengeTests
{
    public  class PlateauTests
    {
        private Plateau plateau;
        [SetUp]
        public void SetUp()
        {
            plateau = new Plateau(5, 5);
        }
        [Test]
        public void IsValidMove_ShouldReturnTrueForValidMove()
        {
            Assert.True(plateau.IsValidMove(1, 1));
        }
        [Test]
        public void IsValidMove_ShouldReturnFalseForInvalidMove()
        {
            Assert.False(plateau.IsValidMove(6, 6));
        }
    }
}

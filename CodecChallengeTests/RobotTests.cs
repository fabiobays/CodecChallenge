using CodecChallenge;

namespace CodecChallengeTests
{
    public class RobotTests
    {
        private Robot robot;
        private Plateau plateau;

        [SetUp]
        public void SetUp()
        {
            robot = new Robot();
            plateau = new Plateau(5, 5);
        }

        [Test]
        public void Move_ShouldMoveNorthWhenFacingNorth()
        {
            // Arrange
            this.SetUp();
            // Act
            robot.Move("F", plateau);
            // Assert
            Assert.That(robot.Y, Is.EqualTo(2));
        }

        [Test]
        public void Move_ShouldMoveEastWhenFacingEast()
        {
            // Arrange
            this.SetUp();
            // Act
            robot.Move("R", plateau);
            robot.Move("F", plateau);
            // Assert
            Assert.That(robot.X, Is.EqualTo(2));
        }

        [Test]
        public void Move_ShouldMoveWestWhenFacingWest()
        {
            // Arrange
            this.SetUp();
            // Act
            robot.Move("R", plateau);
            robot.Move("F", plateau);
            robot.Move("L",plateau);
            robot.Move("L", plateau);
            robot.Move("F", plateau);
            // Assert
            Assert.That(robot.X, Is.EqualTo(1));
        }

        [Test]
        public void Move_ShouldMoveSouthWhenFacingSouth()
        {
            // Arrange
            this.SetUp();
            // Act
            robot.Move("F", plateau);
            robot.Move("R", plateau);
            robot.Move("R", plateau);
            robot.Move("F", plateau);
            // Asert
            Assert.That(robot.Y, Is.EqualTo(1));
        }

        [Test]
        public void Move_ShouldIgnoreCommandWhenMoveIsInvalid()
        {
            // Arrange
            this.SetUp();
            // Act
            robot.Move("F", plateau);
            robot.Move("F", plateau);
            robot.Move("F", plateau);
            robot.Move("F", plateau);
            robot.Move("F", plateau);
            robot.Move("F", plateau);
            // Assert
            Assert.That(robot.Y, Is.EqualTo(5));
        }

        [Test]
        public void Move_ShouldFollowAllCommands()
        {
            // Arrange
            this.SetUp();
            // Act
            robot.Move("FFRFLFLF", plateau);
            // Assert
            Assert.That(robot.X, Is.EqualTo(1));
            Assert.That(robot.Y, Is.EqualTo(4));
            Assert.That(robot.Facing, Is.EqualTo("West"));
        }
    }
}